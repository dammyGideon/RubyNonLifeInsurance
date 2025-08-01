using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RubyNonlife.Application.Dtos.Responses.WorkFlow;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Application.Utitlies;
using RubyNonlife.Infrastructure.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Application.Contract;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json.Linq;

namespace RubyNonlife.Application.Implementations
{
    public class FinanceServiceIntegration : IFinanceServiceIntegration
    {
        private readonly IConfiguration _configuration;
        private readonly FinanceUrlConfig _apiSettings;
        private readonly FinanceAuthenticationHelper _financeHelper;
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _memoryCache;
        private ILogger<FinanceServiceIntegration> _logger;

        public FinanceServiceIntegration(IHttpContextAccessor httpContext,
            IConfiguration configuration, IOptions<ApiSettings> apiSettings, FinanceAuthenticationHelper finance,
            HttpClient http, IMemoryCache memory, ILogger<FinanceServiceIntegration> logger)
        {
            _configuration = configuration;

            _configuration = configuration;
            _apiSettings = apiSettings.Value.FinanceBaseUrl;
            _financeHelper = finance;
            _httpClient = http;
            _memoryCache = memory;
        }





        public async Task<BaseResponse<List<AccountResponse>>> FinanceAccountSetup(string searchParam , string searchKeyword = null)
        {
            if (_memoryCache.TryGetValue("ProductIncomeAccount", out var productIncomeAccount))
            {
                _logger.LogInformation($"Cached state list value: {JsonConvert.SerializeObject(productIncomeAccount)}");
                return ResponseFactory.CreateSuccess<List<AccountResponse>>((List<AccountResponse>)productIncomeAccount, " ");
            }
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _financeHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<List<AccountResponse>>("Unable to retrieve approving office", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

          

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/accounts/{Uri.EscapeDataString(searchParam)}/search";


            try
            {
                var apiResponse = await _httpClient.GetFromJsonAsync<Root>(url, jsonOptions);

                if (apiResponse == null || apiResponse.Data?.Accounts == null)
                {
                    return ResponseFactory.CreateError<List<AccountResponse>>("Received null or incomplete response from API.", HttpStatusCode.BadRequest);
                }

              
                return ResponseFactory.CreateSuccess<List<AccountResponse>>(apiResponse.Data.Accounts, "Account retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }


        }

        
       


        public async Task<FinanceApiBaseResponse> PostToFinanceSystemAsync(object financePayload)
        {
            // Manually refresh the token before API call
            var token = await _financeHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                throw new Exception("Unable to retrieve access token for Finance System.");
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var json = JsonConvert.SerializeObject(financePayload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var endpoint = $"http://172.20.5.27:1380/finance/api/v2/transactions";

            var response = await _httpClient.PostAsync(endpoint, content);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                var errorJson = JsonConvert.DeserializeObject<JObject>(responseContent);
                var message = errorJson?["message"]?.ToString() ?? "Finance system error occurred.";

                throw new Exception(message);
               
            }

            var apiResponse = JsonConvert.DeserializeObject<FinanceApiBaseResponse>(responseContent);

            if (apiResponse?.Status?.ToLower() != "successful")
            {
                throw new Exception($"Finance API call failed: {apiResponse.Message}");
            }

            return apiResponse;
        }



    }
}
