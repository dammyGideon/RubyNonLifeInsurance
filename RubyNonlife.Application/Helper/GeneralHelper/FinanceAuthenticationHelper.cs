using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public class FinanceAuthenticationHelper : IDisposable
    {
        private string _cachedToken;
        private DateTime _tokenExpiry;
        private readonly HttpClient _httpClient;
        private readonly FinanceAuthOptions _financeAuth;
        private static readonly SemaphoreSlim _tokenLock = new(1, 1); // Prevent race conditions

        public FinanceAuthenticationHelper(HttpClient httpClient, IOptions<ApiSettings> options)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _financeAuth = options.Value.FinanceAuth ?? throw new ArgumentNullException(nameof(options));
        }

        public async Task<string> GetAccessToken()
        {
            // If the token is still valid, return it
            if (!string.IsNullOrEmpty(_cachedToken) && _tokenExpiry > DateTime.UtcNow)
            {
                Console.WriteLine("Returning cached token.");
                return _cachedToken;
            }

            // Lock to prevent multiple token refresh requests simultaneously
            await _tokenLock.WaitAsync();
            try
            {
                // Double-check after acquiring the lock to prevent race conditions
                if (!string.IsNullOrEmpty(_cachedToken) && _tokenExpiry > DateTime.UtcNow)
                {
                    Console.WriteLine("Returning cached token after lock.");
                    return _cachedToken;
                }

                // Refresh token if expired
                return await RefreshToken();
            }
            finally
            {
                _tokenLock.Release();
            }
        }

        private async Task<string> RefreshToken()
        {
            // Set up request content for the login API
            var requestContent = new StringContent(
                JsonSerializer.Serialize(new
                {
                    userId = "pandc", // Replace with actual login credentials if needed
                    password = "axalands123!!"
                }),
                Encoding.UTF8, "application/json"
            );

            int retryCount = 3; // Number of retries
            for (int attempt = 1; attempt <= retryCount; attempt++)
            {
                try
                {
                    // Log the token URL for debugging
                    Console.WriteLine($"Requesting token from: {_financeAuth.AdminUrl}");

                    // POST request to the login endpoint
                    var response = await _httpClient.PostAsync("http://172.20.5.27:1380/finance/api/v1/authentication/login", requestContent);
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Log status code and response content for debugging
                    Console.WriteLine($"Response Status Code: {response.StatusCode}");
                    Console.WriteLine($"Response Content: {responseContent}");

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"Failed to authenticate: {responseContent}");
                    }

                    // Parse the response JSON to get the token
                    var loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseContent, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (loginResponse == null || string.IsNullOrEmpty(loginResponse.Data.Token.Token))
                    {
                        throw new Exception($"Invalid token response received. Response content: {responseContent}");
                    }

                    // ✅ Cache token and set expiry time from response
                    _cachedToken = loginResponse.Data.Token.Token;

                    // Add a buffer of 5 minutes to handle slight timing discrepancies
                    _tokenExpiry = DateTime.Parse(loginResponse.Data.Token.ExpiryTime).AddMinutes(-5);

                    Console.WriteLine("Token successfully retrieved and cached.");
                    return _cachedToken;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Attempt {attempt} failed: {ex.Message}");

                    if (attempt == retryCount)
                    {
                        throw new Exception($"Error occurred after {retryCount} attempts: {ex.Message}");
                    }

                    // Wait before retrying with exponential backoff
                    await Task.Delay(TimeSpan.FromSeconds(Math.Pow(2, attempt)));
                }
            }

            return null; // This should never be reached if retries are successful
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }

    public class LoginResponse
    {
        public string Code { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public LoginData Data { get; set; }
    }

    public class LoginData
    {
        public TokenInfo Token { get; set; }
        public UserInfo User { get; set; }
    }

    public class TokenInfo
    {
        public string Token { get; set; }
        public string ExpiryTime { get; set; }
    }

    public class UserInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string ExternalUserId { get; set; }
        public bool IsChannelUser { get; set; }
        public object Role { get; set; }
    }
}
