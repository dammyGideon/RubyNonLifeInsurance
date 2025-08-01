using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RubyNonlife.Application.Dtos.Responses;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net;
using System.Text.Json;
using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Helper.GeneralHelper;
using Newtonsoft.Json;
using RubyNonlife.Application.Dtos.Responses.WorkFlow;
using RubyNonlife.Application.Utitlies;
using Microsoft.Extensions.Logging;
using static RubyNonlife.Infrastructure.Exceptions.CustomExceptions;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using System.Text;
using RubyNonlife.Application.Dtos.Responses.Jwt;
using RubyNonlife.Application.Helper.UtitlityModel;

namespace RubyNonlife.Infrastructure.Implementations
{
    public class AdminServiceIntegration : IAdminServiceIntegration
    {
        private readonly IConfiguration _configuration;
        private readonly AdminUrlConfig _apiSettings;
        private readonly AdminAuthenticationHelper _adminHelper;
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _memoryCache;  
        private ILogger<AdminServiceIntegration> _logger;
        private readonly JwtSettings _jwtSettings;

      
        public AdminServiceIntegration(IHttpContextAccessor httpContext,
            IConfiguration configuration, IOptions<ApiSettings> apiSettings, AdminAuthenticationHelper admin,
            HttpClient http, IMemoryCache memory, ILogger<AdminServiceIntegration> logger,
            IOptions<JwtSettings> jwtSettings
            ) {

            _configuration = configuration;
            _apiSettings = apiSettings.Value.AdminUrl;
            _adminHelper = admin;
            _httpClient = http;
            _memoryCache = memory;
            _jwtSettings = jwtSettings.Value;
        }

        ///Rider/Search?Filters.LineOfBusinessId={lineOfBusinessId}

        public async Task<BaseResponse<string>> GetSubjectType(int id)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Call external API with the dynamic id inserted in the URL
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<AdminNameMappingResponse>>(
                    $"{baseUrl}/SubjectOfInsurance/GetById/{id}", jsonOptions
                );

                // Ensure we got a valid response and Payload is not null
                if (result?.Payload == null)
                {
                    return ResponseFactory.CreateError<string>("Subject type not found.", HttpStatusCode.NotFound);
                }

                // Get the caption for the provided ID
                var caption = result.Payload.Caption;

                if (caption == null)
                {
                    return ResponseFactory.CreateError<string>("Subject type not found.", HttpStatusCode.NotFound);
                }

                // Return the caption as a simple string
                return ResponseFactory.GetSuccessResponse(caption, "Subject Type name successfully retrieved.");
            }
            catch (System.Text.Json.JsonException jsonEx)
            {
                // Handle JSON deserialization errors
                return ResponseFactory.CreateError<string>($"JSON Deserialization failed: {jsonEx.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                // Handle other errors
                return ResponseFactory.CreateError<string>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<string>> GetCoverNameById(int id)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Call external API with the dynamic id inserted in the URL
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<AdminNameMappingResponse>>(
                    $"{baseUrl}/Rider/GetById/{id}", jsonOptions
                );

                // Ensure we got a valid response and Payload is not null
                if (result?.Payload == null)
                {
                    return ResponseFactory.CreateError<string>("Subject type not found.", HttpStatusCode.NotFound);
                }

                // Get the caption for the provided ID
                var caption = result.Payload.Caption;

                if (caption == null)
                {
                    return ResponseFactory.CreateError<string>("Subject type not found.", HttpStatusCode.NotFound);
                }

                // Return the caption as a simple string
                return ResponseFactory.GetSuccessResponse(caption, "Subject Type name successfully retrieved.");
            }
            catch (System.Text.Json.JsonException jsonEx)
            {
                // Handle JSON deserialization errors
                return ResponseFactory.CreateError<string>($"JSON Deserialization failed: {jsonEx.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                // Handle other errors
                return ResponseFactory.CreateError<string>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<string>>> GetSingleCover(List<int> ids)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Make API calls for each id in the list
                var tasks = ids.Select(id => _httpClient.GetFromJsonAsync<AdminBaseResponse<AdminNameMappingResponse>>(
                    $"{baseUrl}/Rider/GetById/{id}", jsonOptions
                )).ToList();

                // Wait for all the requests to complete
                var results = await Task.WhenAll(tasks);

                // Create a list to hold the captions
                var captions = new List<string>();

                // Loop through the results and handle the response
                foreach (var result in results)
                {
                    if (result?.Payload?.Caption != null)
                    {
                        captions.Add(result.Payload.Caption);
                    }
                    else
                    {
                        captions.Add("Not found");
                    }
                }

                // Return the list of captions
                return ResponseFactory.GetSuccessResponse(captions, "Covers retrieved successfully.");
            }
            catch (System.Text.Json.JsonException jsonEx)
            {
                // Handle JSON deserialization errors
                return ResponseFactory.CreateError<List<string>>($"JSON Deserialization failed: {jsonEx.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                // Handle other errors
                return ResponseFactory.CreateError<List<string>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<string>>> GetCostTypeNamesById(List<int> costTypeIds)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();
            var lineOfBusinessId = _apiSettings.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Construct API URL
                var url = $"{baseUrl}/CostType/Search?Filters.LineOfBusinessId={lineOfBusinessId}";

                // Make API call
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminNameMappingResponse>>>(url, jsonOptions);

                // Validate response
                if (result?.Payload == null || !result.Payload.Any())
                {
                    return ResponseFactory.CreateError<List<string>>("No cost types found.", HttpStatusCode.NotFound);
                }

                // Filter the response to match costTypeIds and get corresponding captions
                var captions = result.Payload
                    .Where(x => costTypeIds.Contains(x.Id)) // Filter by riderIds
                    .Where(x => x.Caption != null) // Ensure caption is not null
                    .Select(x => x.Caption) // Extract captions
                    .ToList();

                // Validate filtered captions
                if (!captions.Any())
                {
                    return ResponseFactory.CreateError<List<string>>("No matching rider names found.", HttpStatusCode.NotFound);
                }

                return ResponseFactory.GetSuccessResponse(captions, "rider names successfully retrieved.");
            }
            catch (System.Text.Json.JsonException jsonEx)
            {
                return ResponseFactory.CreateError<List<string>>($"JSON Deserialization failed: {jsonEx.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<string>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<string>>> RiderNamesById(List<int> riderIds)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();
            var lineOfBusinessId = _apiSettings.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Construct API URL
                var url = $"{baseUrl}/Rider/Search?Filters.LineOfBusinessId={lineOfBusinessId}";

                // Make API call
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminNameMappingResponse>>>(url, jsonOptions);

                // Validate response
                if (result?.Payload == null || !result.Payload.Any())
                {
                    return ResponseFactory.CreateError<List<string>>("No cost types found.", HttpStatusCode.NotFound);
                }

                // Filter the response to match riderIds and get corresponding captions
                var captions = result.Payload
                    .Where(x => riderIds.Contains(x.Id)) // Filter by riderIds
                    .Where(x => x.Caption != null) // Ensure caption is not null
                    .Select(x => x.Caption) // Extract captions
                    .ToList();

                // Validate filtered captions
                if (!captions.Any())
                {
                    return ResponseFactory.CreateError<List<string>>("No matching rider names found.", HttpStatusCode.NotFound);
                }

                return ResponseFactory.GetSuccessResponse(captions, "rider names successfully retrieved.");
            }
            catch (System.Text.Json.JsonException jsonEx)
            {
                return ResponseFactory.CreateError<List<string>>($"JSON Deserialization failed: {jsonEx.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<string>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<List<string>>> GetCostOfInsuranceNamesById(List<int> costOfInsuranceIds)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();
            var lineOfBusinessId = _apiSettings.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Construct API URL
                var url = $"{baseUrl}/SourceOfCollection/Search?Filters.LineOfBusinessId={lineOfBusinessId}";

                // Make API call
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminNameMappingResponse>>>(url, jsonOptions);

                // Validate response
                if (result?.Payload == null || !result.Payload.Any())
                {
                    return ResponseFactory.CreateError<List<string>>("Cost of Insurance found.", HttpStatusCode.NotFound);
                }

                // Filter the response to match costOfInsuranceIds and get corresponding captions
                var captions = result.Payload
                    .Where(x => costOfInsuranceIds.Contains(x.Id)) // Filter by riderIds
                    .Where(x => x.Caption != null) // Ensure caption is not null
                    .Select(x => x.Caption) // Extract captions
                    .ToList();

                // Validate filtered captions
                if (!captions.Any())
                {
                    return ResponseFactory.CreateError<List<string>>("No matching Cost of Insurance found.", HttpStatusCode.NotFound);
                }

                return ResponseFactory.GetSuccessResponse(captions, "Cost Of Insurance names successfully retrieved.");
            }
            catch (System.Text.Json.JsonException jsonEx)
            {
                return ResponseFactory.CreateError<List<string>>($"JSON Deserialization failed: {jsonEx.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<string>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<string>>> GetSubjectOfInsuranceNamesById(List<int> costOfInsuranceIds)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();
            var lineOfBusinessId = _apiSettings.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Construct API URL
                var url = $"{baseUrl}/SubjectOfInsurance/Search?Filters.LineOfBusinessId={lineOfBusinessId}";

                // Make API call
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminNameMappingResponse>>>(url, jsonOptions);

                // Validate response
                if (result?.Payload == null || !result.Payload.Any())
                {
                    return ResponseFactory.CreateError<List<string>>("Cost of Insurance found.", HttpStatusCode.NotFound);
                }

                // Filter the response to match costOfInsuranceIds and get corresponding captions
                var captions = result.Payload
                    .Where(x => costOfInsuranceIds.Contains(x.Id)) // Filter by riderIds
                    .Where(x => x.Caption != null) // Ensure caption is not null
                    .Select(x => x.Caption) // Extract captions
                    .ToList();

                // Validate filtered captions
                if (!captions.Any())
                {
                    return ResponseFactory.CreateError<List<string>>("No matching Cost of Insurance found.", HttpStatusCode.NotFound);
                }

                return ResponseFactory.GetSuccessResponse(captions, "Cost Of Insurance names successfully retrieved.");
            }
            catch (System.Text.Json.JsonException jsonEx)
            {
                return ResponseFactory.CreateError<List<string>>($"JSON Deserialization failed: {jsonEx.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<string>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
        //get Brokers 
        public async Task<BaseResponse<List<GenericNameResponse>>> GetBroker()
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();
            var lineOfBusinessId = _apiSettings.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Construct API URL
                var url = $"{baseUrl}/ExternalEntity/GetAll";

                // Make API call
                var apiResponse = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<GenericNameResponse>>>(url, jsonOptions);

                // Validate response
                if (apiResponse?.Payload == null || !apiResponse.Payload.Any())
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("Broker not found.", HttpStatusCode.NotFound);
                }

                var brokers = apiResponse?.Payload?.Select(b => new GenericNameResponse
                {
                    Id = b.Id,
                    Name = b.Name,
                }).ToList() ?? new List<GenericNameResponse>();

                // Validate filtered captions
               
                return ResponseFactory.GetSuccessResponse(brokers, "Broker retrieved successfully.");
            }
           
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<Dictionary<int, string>>> GetObjectOfInsuranceNamesById(List<int> objectOfInsuranceIds)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();
            var lineOfBusinessId = _apiSettings.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var result = await _httpClient.GetFromJsonAsync<AdminCentralApiResponse<object>>(
                $"{baseUrl}/SubjectOfInsurance/Search?Filters.LineOfBusinessId={lineOfBusinessId}",
                jsonOptions
            );

            if (result?.Payload == null)
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No cost of insurance found.", HttpStatusCode.NotFound);
            }

            // Force Deserialize as List
            var jsonString = System.Text.Json.JsonSerializer.Serialize(result.Payload);
            var costOfInsurance = System.Text.Json.JsonSerializer.Deserialize<List<AdminGenericResponse>>(jsonString, jsonOptions);

            if (costOfInsurance == null || !costOfInsurance.Any())
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No cost of Insurance found.", HttpStatusCode.NotFound);
            }

            var costOfInsuranceMapping = costOfInsurance
                .Where(p => objectOfInsuranceIds.Contains(p.Id))
                .ToDictionary(p => p.Id, p => p.Caption);

            return ResponseFactory.GetSuccessResponse(costOfInsuranceMapping, "Cost Of Insurance names successfully retrieved.");
        }
        public async Task<BaseResponse<List<AdminWorkflowResponse>>> GetAllWorkflows(int id)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<List<AdminWorkflowResponse>>("Unable to retrieve workflow", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var url = $"{baseUrl}/Workflow/Search?Filters.ModuleId={id}&Filters.IncludeApprovalSetupsProperty=true";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminWorkflowResponse>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<AdminWorkflowResponse>>("Received null response from API.",HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<AdminWorkflowResponse>>("An error occurred while retrieving the workflows.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.CreateSuccess<List<AdminWorkflowResponse>>(response.Payload,"");

            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<AdminWorkflowResponse>>($"HTTP request error: {ex.Message}",HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<AdminWorkflowResponse>>($"An unexpected error occurred: {ex.Message}",HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<AdminFunction>> GetFunctionById(int id)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<AdminFunction>("Unable to retrieve function", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/Function/GetById/{id}";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<AdminFunction>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<AdminFunction>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<AdminFunction>("An error occurred while retrieving the function.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse<AdminFunction>(response.Payload,"");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<AdminFunction>($"HTTP request error: {ex.Message}",HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<AdminFunction>($"An unexpected error occurred: {ex.Message}",HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<List<AdminFunction>>> GetAllFunctions()
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<List<AdminFunction>>("Unable to retrieve workflow", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var url = $"{baseUrl}/Function/GetAll";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminFunction>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<AdminFunction>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<AdminFunction>>("An error occurred while retrieving the workflows.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.CreateSuccess<List<AdminFunction>>(response.Payload, "");

            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<AdminFunction>>($"HTTP request error: {ex.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<AdminFunction>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<List<Approvalsetup>>> GetWorkflowApprovalSetup(int id)
        {

            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<List<Approvalsetup>>("Unable to retrieve function", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/WorkflowApprovalSetup/Search?Filters.WorkflowId={id}";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<Approvalsetup>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<Approvalsetup>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<Approvalsetup>>("An error occurred while retrieving the function.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse<List<Approvalsetup>>(response.Payload, "");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<Approvalsetup>>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<Approvalsetup>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }


        }
        public async Task<BaseResponse<List<AdminFunction>>> GetFunctionWithIdList(List<int> ids)
        {

            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();
            var lineOfBusinessId = _apiSettings.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var urlFilters = string.Join('&', ids.Select(x => $"Filters.Ids={x}"));


            var url = $"{baseUrl}/ApprovingOffice/Search?{urlFilters}";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminFunction>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<AdminFunction>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<AdminFunction>>("An error occurred while retrieving the function.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse<List<AdminFunction>>(response.Payload, "");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<AdminFunction>>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<AdminFunction>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }


            
        }
        public async Task<BaseResponse<ApprovingOfficeLookup>> GetApprovingOfficeById(int id)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<ApprovingOfficeLookup>("Unable to retrieve approving office", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/ApprovingOffice/GetById/{id}";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<ApprovingOfficeLookup>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<ApprovingOfficeLookup>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<ApprovingOfficeLookup>("An error occurred while retrieving the approving office.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse(response.Payload, "Approving office retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<ApprovingOfficeLookup>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<ApprovingOfficeLookup>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<ApprovingPosition>> ApprovingPositionId(int id)
        {

            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<ApprovingPosition>("Unable to retrieve approving office", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/ApprovingOfficerPosition/GetById/{id}";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<ApprovingPosition>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<ApprovingPosition>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<ApprovingPosition>("An error occurred while retrieving the approving office.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse(response.Payload, "Approving office retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<ApprovingPosition>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<ApprovingPosition>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }

           
           
        }
        public async Task<BaseResponse<List<ApprovingOfficeLookup>>> GetAllApprovingOffices(string search)
        {

            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>("Unable to retrieve approving office", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/ApprovingOffice/Search?Filters.Name={search}";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<ApprovingOfficeLookup>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>("An error occurred while retrieving the approving office.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse(response.Payload, "Approving office retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }



           
        }
        public async Task<BaseResponse<List<ApprovingOfficeLookup>>> GetAllApprovingOfficesByIds(List<int> ids)
        {
            var baseUrl = _apiSettings.BaseUrl;

            var token = await _adminHelper.GetAccessToken();

          

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>("Unable to retrieve approving office", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            // Construct URL with multiple Filters.Ids and always include Filters.IncludeOfficersProperty=true
            var queryParams = string.Join("&", ids.Select(id => $"Filters.Ids={id}"));
            var url = $"{baseUrl}/ApprovingOffice/Search?{queryParams}&Filters.IncludeOfficersProperty=true";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<ApprovingOfficeLookup>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>("An error occurred while retrieving the approving office.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse(response.Payload, "Approving office retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<List<Officer>>> GetAllApprovingOfficersWithApprovingOffice(int officeId)
        {

            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<List<Officer>>("Unable to retrieve approving office", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/ApprovingOfficer/Search?Filters.OfficeId={officeId}";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<Officer>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<Officer>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<Officer>>("An error occurred while retrieving the approving office.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse(response.Payload, "Approving office retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<Officer>>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<Officer>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<List<ApprovingOffice>>> GetUserApprovingOffices(Guid userId)
        {

            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<List<ApprovingOffice>>("unable to retrieve Approving Position", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/ApprovingOfficer/Search?Filters.UserId={userId}";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<ApprovingOffice>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<ApprovingOffice>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<ApprovingOffice>>("An error occurred while retrieving the approving office.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse(response.Payload, "Approving office retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<ApprovingOffice>>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<ApprovingOffice>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }


            
        }
        public async Task<BaseResponse<List<UserOfficeFunctionsAdminResponse>>> GetUsersInformation(int functionId, int approvingOfficeId)
        {


            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>("unable to retrieve Approving Position", HttpStatusCode.BadRequest);
            }

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/ApprovingOfficer/Search?Filters.OfficeId={approvingOfficeId}&Filters.FunctionId={functionId}&Filters.IncludeUserProperty=true";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<UserOfficeFunctionsAdminResponse>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>("An error occurred while retrieving the approving office.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse(response.Payload, "Approving office retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }



        }
        public async Task<BaseResponse<List<AdminModulesResponse>>> GetAllModules()
        {

            var baseUrl = _apiSettings.BaseUrl;
            var businessLineId = _apiSettings.LineOfBusinessId;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var url = $"{baseUrl}/Module/Search?Filters.LineOfBusinessId={businessLineId}";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminModulesResponse>>>(url, jsonOptions);

                if (response == null)
                {
                    throw new NotFoundException("Received null response from API");
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<AdminModulesResponse>>("An error occurred while retrieving the approving office.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse(response.Payload, "Approving office retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<AdminModulesResponse>>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<AdminModulesResponse>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }



           
        }
        public async Task<BaseResponse<AdminWorkflowResponse>> GetWorkflow(int id)
        {
            if (_memoryCache.TryGetValue($"{CacheConstants.SingleWorkflowConfig}{id}", out var config))
            {
                _logger.LogInformation($"Cached GetWorkflow value: {JsonConvert.SerializeObject(config)}");
                return ResponseFactory.CreateSuccess<AdminWorkflowResponse>((AdminWorkflowResponse)config, "");
            }

            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var url = $"{baseUrl}/Workflow/GetById/{id}";

            var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<AdminWorkflowResponse>>(url, jsonOptions);

            if (response == null)
            {
                
                throw new NotFoundException($"Workflow with ID {id} not found.");
            }

            if (response.HasErrors)
            {
                // Throw ValidationException or another suitable exception for errors
                throw new ValidationException("An error occurred while retrieving the workflow.");
            }

            return ResponseFactory.GetSuccessResponse(response.Payload, "Workflow retrieved successfully.");
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetStates()
        {
            if (_memoryCache.TryGetValue(CacheConstants.StateList, out var stateList))
            {
                _logger.LogInformation($"Cached state list value: {JsonConvert.SerializeObject(stateList)}");
                return ResponseFactory.CreateSuccess<List<GenericNameResponse>>((List<GenericNameResponse>)stateList," ");
            }
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/State/GetAll";

           
            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminStatesResponse>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("An error occurred while retrieving the workflows.",
                        HttpStatusCode.BadRequest);
                }

                var adminResponse =response.Payload.Select(x => new GenericNameResponse
                {
                    Name = x.Name,
                    Id = x.Id
                }).ToList();

                return ResponseFactory.CreateSuccess<List<GenericNameResponse>>(adminResponse, "State retrieved successfully.");

            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"HTTP request error: {ex.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }

        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetExternalEntity(int typeId)
        {
            if (_memoryCache.TryGetValue(CacheConstants.ExternalEntity, out var externalEntity))
            {
                _logger.LogInformation($"Cached externalEntity list value: {JsonConvert.SerializeObject(externalEntity)}");
                return ResponseFactory.CreateSuccess<List<GenericNameResponse>>((List<GenericNameResponse>)externalEntity, " ");
            }
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/ExternalEntity/Search?Filters.TypeId={typeId}";



            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminStatesResponse>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("An error occurred while retrieving the Brokers.",
                        HttpStatusCode.BadRequest);
                }

                var adminResponse = response.Payload.Select(x => new GenericNameResponse
                {
                    Name = x.Name,
                    Id = x.Id
                }).ToList();

                return ResponseFactory.CreateSuccess<List<GenericNameResponse>>(adminResponse, "State retrieved successfully.");

            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"HTTP request error: {ex.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }

        }
        public async Task<BaseResponse<List<AdminProductClassResponse>>> GetProductClass(int lineOfBusinessId)
        {

            if (_memoryCache.TryGetValue(CacheConstants.ProductClass, out var productClass))
            {
                _logger.LogInformation($"Cached externalEntity list value: {JsonConvert.SerializeObject(productClass)}");
                return ResponseFactory.CreateSuccess<List<AdminProductClassResponse>>((List<AdminProductClassResponse>)productClass, " ");
            }
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/BusinessClass/Search?Filters.LineOfBusinessId={lineOfBusinessId}&Filters.OrderByDescending=false";
           
            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminProductClassResponse>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<AdminProductClassResponse>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<AdminProductClassResponse>>("An error occurred while retrieving the Product Class.",
                        HttpStatusCode.BadRequest);
                }

                var adminResponse = response.Payload.Select(x => new AdminProductClassResponse
                {
                    Caption = x.Caption,
                    Id = x.Id,
                    Url = x.Url,
                }).ToList();

                return ResponseFactory.CreateSuccess<List<AdminProductClassResponse>>(adminResponse, "State retrieved successfully.");

            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<AdminProductClassResponse>>($"HTTP request error: {ex.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<AdminProductClassResponse>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }

        }
        public async Task<BaseResponse<string>> GetSingleProductClass(int id)
        {
           
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Call external API with the dynamic id inserted in the URL
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<AdminNameMappingResponse>>(
                    $"{baseUrl}/BusinessClass/GetById/{id}", jsonOptions
                );

                // Ensure we got a valid response and Payload is not null
                if (result?.Payload == null)
                {
                    return ResponseFactory.CreateError<string>("Subject type not found.", HttpStatusCode.NotFound);
                }

                // Get the caption for the provided ID
                var caption = result.Payload.Caption;

                if (caption == null)
                {
                    return ResponseFactory.CreateError<string>("Subject type not found.", HttpStatusCode.NotFound);
                }

                // Return the caption as a simple string
                return ResponseFactory.GetSuccessResponse(caption, "Subject Type name successfully retrieved.");
            }
            catch (System.Text.Json.JsonException jsonEx)
            {
                // Handle JSON deserialization errors
                return ResponseFactory.CreateError<string>($"JSON Deserialization failed: {jsonEx.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                // Handle other errors
                return ResponseFactory.CreateError<string>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }

        }
        public async Task<BaseResponse<Dictionary<int, string>>> GetProductClassNames(List<int> productClassId)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();
            var lineOfBusinessId = _apiSettings.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var result = await _httpClient.GetFromJsonAsync<AdminCentralApiResponse<object>>(
                $"{baseUrl}/BusinessClass/Search?Filters.LineOfBusinessId={lineOfBusinessId}",
                jsonOptions
            );

            if (result?.Payload == null)
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No Product found.", HttpStatusCode.NotFound);
            }

            // Force Deserialize as List
            var jsonString = System.Text.Json.JsonSerializer.Serialize(result.Payload);
            var productClass = System.Text.Json.JsonSerializer.Deserialize<List<AdminGenericResponse>>(jsonString, jsonOptions);

            if (productClass == null || !productClass.Any())
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No Product class found.", HttpStatusCode.NotFound);
            }

            var productClassMapping = productClass
                .Where(p => productClassId.Contains(p.Id))
                .ToDictionary(p => p.Id, p => p.Caption);

            return ResponseFactory.GetSuccessResponse(productClassMapping, "Product Class successfully retrieved.");
        }
        public async Task<BaseResponse<List<AdminRiderResponse>>> GetProductWithRiders(int productClassId, int lineOfBusiness)
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/Rider/Search?Filters.LineOfBusinessId={lineOfBusiness}&Filters.BusinessClassId={productClassId}";

            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminRiderResponse>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<AdminRiderResponse>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<AdminRiderResponse>>("An error occurred while retrieving Riders.", HttpStatusCode.BadRequest);
                }

                if (response.Payload == null)
                {
                    return ResponseFactory.CreateError<List<AdminRiderResponse>>("No data found for the given class and line of business.", HttpStatusCode.NotFound);
                }

                var adminResponse = response.Payload.Select(x => new AdminRiderResponse
                {
                    Id = x.Id,
                    Caption = x.Caption
                }).ToList();

                return ResponseFactory.CreateSuccess(adminResponse, "Riders retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<AdminRiderResponse>>($"HTTP request error: {ex.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<AdminRiderResponse>>($"Unexpected error: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<List<UserOfficeFunctionsAdminResponse>>> GetUserId(int OfficeId)
        {

            if (_memoryCache.TryGetValue(CacheConstants.UserIdList, out var userIdList))
            {
                _logger.LogInformation($"Cached state list value: {JsonConvert.SerializeObject(userIdList)}");
                return ResponseFactory.CreateSuccess<List<UserOfficeFunctionsAdminResponse>>((List<UserOfficeFunctionsAdminResponse>)userIdList, " ");
            }
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var url = $"{baseUrl}/ApprovingOfficer/Search?Filters.OfficeId={OfficeId}&Filters.IncludeUserProperty=true";


            try
            {
                var response = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<UserOfficeFunctionsAdminResponse>>>(url, jsonOptions);

                if (response == null)
                {
                    return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>("Received null response from API.", HttpStatusCode.BadRequest);
                }

                if (response.HasErrors)
                {
                    return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>("An error occurred while retrieving the approving office.",
                        HttpStatusCode.BadRequest);
                }

                return ResponseFactory.GetSuccessResponse(response.Payload, "Approving office retrieved successfully.");
            }
            catch (HttpRequestException ex)
            {
                return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>($"HTTP request error: {ex.Message}", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>($"An unexpected error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }



        }


        public async Task<BaseResponse<(string Token, bool IsAuthenticated)>> AuthenticateADUser(string username, string password)
        {
            if (_memoryCache.TryGetValue(CacheConstants.AdAuthentication, out var adAuthentication))
            {
                _logger.LogInformation($"Cached AD auth value: {JsonConvert.SerializeObject(adAuthentication)}");
                return ResponseFactory.CreateSuccess<(string, bool)>(("cached-token", true), "From cache");
            }

            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var requestBody = new
            {
                lineOfBusinessId = 1,
                username = username,
                password = password,
                includeStructuralBusinessUnitProperty = true,
                includeFunctionsProperty = true
            };

            var httpContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            var url = $"{baseUrl}/Auth/AuthenticateADUser";
            var response = await _httpClient.PostAsync(url, httpContent);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return ResponseFactory.CreateFailure<(string, bool)>("Authentication request failed with external API.");
            }

            // First pass: check if payload is invalid (e.g., false)
            var lightResponse = JsonConvert.DeserializeObject<LightweightAdminResponse>(responseContent);

            if (lightResponse.Payload is bool payloadBool && payloadBool == false)
            {
                var err = lightResponse.Errors?.FirstOrDefault() ?? "Invalid credentials or unexpected response from external API.";
                return ResponseFactory.CreateFailure<(string, bool)>(err);
            }

            // Now safely deserialize full object
            var responseObject = JsonConvert.DeserializeObject<AdminAuthenticationResponse>(responseContent);

            if (responseObject?.HasErrors == true)
            {
                var errorMessage = responseObject.Errors?.FirstOrDefault() ?? "An unknown authentication error occurred.";
                return ResponseFactory.CreateFailure<(string, bool)>(errorMessage);
            }

            if (responseObject?.Payload == null ||
                !string.Equals(responseObject.Payload.AdUsername, username, StringComparison.OrdinalIgnoreCase))
            {
                return ResponseFactory.CreateFailure<(string, bool)>("Invalid username or not found.");
            }

            var userId = responseObject.Payload.Id;
            var functions = responseObject.Payload.Functions;

            var jwtToken = TokenService.GenerateToken(userId, functions, _jwtSettings); // Assumes token service is now a class

            return ResponseFactory.CreateSuccess<(string, bool)>((jwtToken, true), "Authenticated successfully.");
        }

        public async Task<BaseResponse<(string Token, bool IsAuthenticated)>> AuthenticateByFullName(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return ResponseFactory.CreateFailure<(string, bool)>("Username (FullName or ADUsername) cannot be empty.");
            }

            var token = await _adminHelper.GetAccessToken();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var baseUrl = _apiSettings.BaseUrl;
            var encodedInput = Uri.EscapeDataString(input);

            // 🔄 Decide which field to search by based on the input format
            bool isFullNameLogin = !(input.Contains(".") || !input.Contains(" ")); // Heuristic: FullName contains space, ADUsername does not
            string searchUrl;

            if (isFullNameLogin)
            {
                // Search by FullName
                searchUrl = $"{baseUrl}/User/SearchUsers?Filters.FullName={encodedInput}";
            }
            else
            {
                // Search by ADUsername
                searchUrl = $"{baseUrl}/User/SearchUsers?Filters.ADUsername={encodedInput}";
            }

            var response = await _httpClient.GetAsync(searchUrl);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return ResponseFactory.CreateFailure<(string, bool)>($"Search failed: {content}");
            }

            var result = JsonConvert.DeserializeObject<AdminAuthResponse>(content);

            if (result?.Payload == null || !result.Payload.Any())
            {
                // If no match is found for FullName, try searching by ADUsername
                if (isFullNameLogin)
                {
                    searchUrl = $"{baseUrl}/User/SearchUsers?Filters.ADUsername={encodedInput}";
                    response = await _httpClient.GetAsync(searchUrl);
                    content = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        return ResponseFactory.CreateFailure<(string, bool)>($"Search failed: {content}");
                    }

                    result = JsonConvert.DeserializeObject<AdminAuthResponse>(content);

                    if (result?.Payload == null || !result.Payload.Any())
                    {
                        return ResponseFactory.CreateFailure<(string, bool)>("User not found.");
                    }
                }
                else
                {
                    return ResponseFactory.CreateFailure<(string, bool)>("User not found.");
                }
            }

            // 🎯 Try to match input precisely with ADUsername or FullName
            var user = result.Payload.FirstOrDefault(u =>
                u.AdUsername?.Equals(input, StringComparison.OrdinalIgnoreCase) == true ||
                u.FullName?.Equals(input, StringComparison.OrdinalIgnoreCase) == true);

            if (user == null)
            {
                return ResponseFactory.CreateFailure<(string, bool)>("Exact user match not found.");
            }

            // 🔐 Generate token using dynamic "UserName" claim logic
            var jwtToken = TokenService.GenerateFullNameToken(user.Id, user.FullName, user.AdUsername, isFullNameLogin, _jwtSettings);

            return ResponseFactory.CreateSuccess<(string, bool)>((jwtToken, true), "User authenticated.");
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> GetOfficeLocation()
        {
            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();
            var lineOfBusinessId = _apiSettings.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Construct API URL
                var url = $"{baseUrl}/Location/GetAll";

                // Make API call
                var apiResponse = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<GenericNameResponse>>>(url, jsonOptions);

                // Validate response
                if (apiResponse?.Payload == null || !apiResponse.Payload.Any())
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("Location not found.", HttpStatusCode.NotFound);
                }

                var brokers = apiResponse?.Payload?.Select(b => new GenericNameResponse
                {
                    Id = b.Id,
                    Name = b.Name,
                }).ToList() ?? new List<GenericNameResponse>();

                // Validate filtered captions

                return ResponseFactory.GetSuccessResponse(brokers, "Location retrieved successfully.");
            }

            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<BrokerAccountDetailsResponse>> GetExternalEntityById(int id)
        {

            if (_memoryCache.TryGetValue(CacheConstants.BrokerFee, out var brokerFee))
            {
                _logger.LogInformation($"Cached externalEntity list value: {JsonConvert.SerializeObject(brokerFee)}");
                return ResponseFactory.CreateSuccess<BrokerAccountDetailsResponse>((BrokerAccountDetailsResponse)brokerFee, "broker fee");
            }

            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                // Fix: Correct angle bracket placement for generic method call
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<BrokerAccountDetailsResponse>>(
                    $"{baseUrl}/ExternalEntity/GetById/{id}", jsonOptions
                );

                if (result?.Payload == null)
                {
                    return ResponseFactory.CreateError<BrokerAccountDetailsResponse>("Broker not found.", HttpStatusCode.NotFound);
                }

                // Only return the Name and PayableAccountNumber
                var brokerDetails = new BrokerAccountDetailsResponse
                {
                    Name = result.Payload.Name,
                    payableAccountNumber = result.Payload.payableAccountNumber
                };

                return ResponseFactory.GetSuccessResponse(brokerDetails, "Broker details retrieved.");
            }
            catch (System.Text.Json.JsonException jsonEx)
            {
                return ResponseFactory.CreateError<BrokerAccountDetailsResponse>($"JSON error: {jsonEx.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<BrokerAccountDetailsResponse>($"Unexpected error: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<CoInsuranceAccountDetailsResponse>>> GetExternalEntitiesByIds(int[] ids)
        {
            if (_memoryCache.TryGetValue(CacheConstants.ManagementFee, out var managementFee))
            {
                _logger.LogInformation($"Cached Management Fee list value: {JsonConvert.SerializeObject(managementFee)}");
                return ResponseFactory.CreateSuccess<List<CoInsuranceAccountDetailsResponse>>((List<CoInsuranceAccountDetailsResponse>)managementFee," management Fee");
            }


            var baseUrl = _apiSettings.BaseUrl;
            var token = await _adminHelper.GetAccessToken();

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<ExternalEntityResponse>>>(
                    $"{baseUrl}/ExternalEntity/GetAll", jsonOptions
                );

                if (result?.Payload == null || !result.Payload.Any())
                {
                    return ResponseFactory.CreateError<List<CoInsuranceAccountDetailsResponse>>("No external entities found.", HttpStatusCode.NotFound);
                }

                var filtered = result.Payload
                    .Where(x => ids.Contains(x.Id))
                    .Select(x => new CoInsuranceAccountDetailsResponse
                    {
                        Id = x.Id,
                        Name = x.Name,
                        payableAccountNumber = x.PayableAccountNumber
                    })
                    .ToList();

                return ResponseFactory.GetSuccessResponse(filtered, "Filtered broker details retrieved.");
            }
            catch (System.Text.Json.JsonException jsonEx)
            {
                return ResponseFactory.CreateError<List<CoInsuranceAccountDetailsResponse>>($"JSON error: {jsonEx.Message}", HttpStatusCode.InternalServerError);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<CoInsuranceAccountDetailsResponse>>($"Unexpected error: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

    }
}
