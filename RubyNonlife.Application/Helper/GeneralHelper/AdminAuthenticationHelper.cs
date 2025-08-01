using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public class AdminAuthenticationHelper : IDisposable
    {
        private string _cachedToken;
        private DateTime _tokenExpiry;
        private readonly HttpClient _httpClient;
        private readonly AdminAuthOptions _adminAuth;
        private static readonly SemaphoreSlim _tokenLock = new(1, 1); // Prevent race conditions

        public AdminAuthenticationHelper(HttpClient httpClient, IOptions<ApiSettings> options)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _adminAuth = options.Value.AdminAuth ?? throw new ArgumentNullException(nameof(options));
        }

        public async Task<string> GetAccessToken()
        {
            // If the token is still valid, return it
            if (!string.IsNullOrEmpty(_cachedToken) && _tokenExpiry > DateTime.UtcNow)
            {
                Console.WriteLine("Returning cached token.");
                return _cachedToken;
            }

            // Lock to prevent multiple token refresh requests
            await _tokenLock.WaitAsync();
            try
            {
                // Check again in case another request already refreshed the token
                if (!string.IsNullOrEmpty(_cachedToken) && _tokenExpiry > DateTime.UtcNow)
                {
                    Console.WriteLine("Returning cached token after lock.");
                    return _cachedToken;
                }

                return await RefreshToken();
            }
            finally
            {
                _tokenLock.Release();
            }
        }

        private async Task<string> RefreshToken()
        {
            var requestContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", "rubypandc@admin.com"),
                new KeyValuePair<string, string>("password", "Ruby@PCAdmin123"),
            });

            int retryCount = 3; // Number of retries
            for (int attempt = 1; attempt <= retryCount; attempt++)
            {
                try
                {
                    // Log the token URL for debugging
                    Console.WriteLine($"Requesting token from: {_adminAuth.TokenUrl}");

                    var response = await _httpClient.PostAsync(_adminAuth.TokenUrl, requestContent);
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Log status code and response content for debugging
                    Console.WriteLine($"Response Status Code: {response.StatusCode}");
                    Console.WriteLine($"Response Content: {responseContent}");

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"Failed to authenticate: {responseContent}");
                    }

                    var tokenResponse = JsonSerializer.Deserialize<TokenResponse>(responseContent, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (tokenResponse == null || string.IsNullOrEmpty(tokenResponse.AccessToken))
                    {
                        throw new Exception($"Invalid token response received. Response content: {responseContent}");
                    }

                    // ✅ Cache token for 30 minutes (override API expiry)
                    _cachedToken = tokenResponse.AccessToken;
                    _tokenExpiry = DateTime.UtcNow.AddMinutes(30); // Set expiry to 30 minutes
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

                    // Wait before retrying
                    await Task.Delay(TimeSpan.FromSeconds(2));
                }
            }

            return null; // This should never be reached if retries are successful
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }

    public class TokenResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
