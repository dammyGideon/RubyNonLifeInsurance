using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Helper.UtitlityModel;
using RubyNonlife.Application.Utitlies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RubyNonlife.Application.Dtos.Responses.Finance;
using RubyNonlife.Application.Dtos.Requests.FinanceRequest;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Application.Contract;
using AccountResponse = RubyNonlife.Application.Dtos.Responses.Finance.AccountResponse;
using RubyNonlife.Domain.Enums;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Net.Http;

namespace RubyNonlife.Application.Implementations
{
    public class FinanceService :  IFinanceService
    {
        private readonly ConfigModels _configModel;
        private readonly IMemoryCache _cache;
        private readonly IConfiguration _configuration;
        private readonly ILogger<FinanceService> _logger;
        private readonly FinanceAuthenticationHelper _financeHelper;
        public string Message { get; set; }
        public FinanceService(IConfiguration config, IOptions<ConfigModels> configModel, ILogger<FinanceService> logger,
            IMemoryCache cache, FinanceAuthenticationHelper finance) 
        {
            _configuration = config;
            _configModel = configModel.Value;
            _logger = logger;
            _cache = cache;
            _financeHelper = finance;
        }
        public async Task<FinanceBaseResponse<AccountResponse>> CreateLedger(AccountRequestDto request)
        {
            var baseUrl = "http://172.20.5.27:1380/finance/api/v1/accounts/requests";
            var token = await _financeHelper.GetAccessToken();

            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var httpResponse = await httpClient.PostAsJsonAsync(baseUrl, request); // Use PostAsJsonAsync for the request

            // Check if the response is successful
            if (!httpResponse.IsSuccessStatusCode)
            {
                return new FinanceBaseResponse<AccountResponse>
                {
                    Status = RequestExecutionStatus.Failed.ToString(),
                    Message = "Failed to create ledger account."
                };
            }

            // Read the response content and deserialize it
            var content = await httpResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FinanceBaseResponse<AccountResponse>>(content);
        }
    }
}
