using Newtonsoft.Json;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Helper;
using RubyNonlife.Application.Dtos.Responses.WorkFlow;
using System.Net;
using RubyNonlife.Application.Utitlies;
using RubyNonlife.Infrasture.Persistence;



namespace RubyNonlife.Application.Implementations
{
    public class AdminIntegrationService
    {
        private readonly RubyDbContext _rubyDbContext;
        private readonly AdminAuthenticationHelper _authenticationHelper;
        private readonly HttpClient _httpClient;
        private readonly AdminUrlConfig _apiSettings;
        private readonly IMemoryCache _cache;


        public AdminIntegrationService(RubyDbContext dbContext,HttpClient httpClient, IOptions<ApiSettings> options, AdminAuthenticationHelper admin, IMemoryCache cache)
        {
            _rubyDbContext = dbContext;
            _authenticationHelper = admin;
            _httpClient = httpClient;
            _apiSettings = options.Value.AdminUrl;
            _cache = cache;
        }




        public async Task<BaseResponse<AdminWorkflowResponse>> GetWorkflow(int id)
        {
            if (_cache.TryGetValue($"{CacheConstants.SingleWorkflowConfig}{id}", out var config))
            {
                return ResponseFactory.CreateError<AdminWorkflowResponse>((AdminWorkflowResponse)config);
            }
            var token = await _authenticationHelper.GetAccessToken();
            if (token is null)
            {
                return ResponseFactory.CreateError<AdminWorkflowResponse>("unable to retrieve workflow",HttpStatusCode.BadRequest);
            }
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/Workflow/GetById/{id}", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflow = JsonConvert.DeserializeObject<AdminBaseResponse<AdminWorkflowResponse>>(content);
                if (workflow.HasErrors)
                {
                    return ResponseFactory.CreateError<AdminWorkflowResponse>($"An error occured while retrieving the work flow with Id {workflow.Errors}.", HttpStatusCode.BadRequest);
                   
                }
                if (workflow.Payload != null)
                {
                    _cache.Set($"{CacheConstants.SingleWorkflowConfig}{id}", workflow.Payload, DateTimeOffset.UtcNow.AddHours(1));
                }
                return ResponseFactory.CreateSuccess<AdminWorkflowResponse>(workflow.Payload,"");
            }
            return ResponseFactory.CreateError<AdminWorkflowResponse>("An error occured while retrieving the work flows.",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<List<AdminWorkflowResponse>>> GetAllWorkflows(int id)
        {
            var token = await _authenticationHelper.GetAccessToken();
            if (token is null)
            {
                return ResponseFactory.CreateError<List<AdminWorkflowResponse>>("unable to retrieve workflow",HttpStatusCode.NotFound);
            }
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/Workflow/Search?Filters.ModuleId={id}&Filters.IncludeApprovalSetupsProperty=true", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<List<AdminWorkflowResponse>>>(content);
                if (workflows.HasErrors)
                {
                    return ResponseFactory.CreateError<List<AdminWorkflowResponse>>("An error occured while retrieving the work flows.", HttpStatusCode.InternalServerError);
                    
                }

                return ResponseFactory.CreateSuccess<List<AdminWorkflowResponse>>(workflows.Payload,"");
            }
            return ResponseFactory.CreateError<List<AdminWorkflowResponse>>("An error occured while retrieving the work flows.",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<Function>> GetFunctionById(int id)
        {
            var token = await _authenticationHelper.GetAccessToken();
            var baseUrl = _apiSettings.BaseUrl;
            if (token is null)
            {
                return ResponseFactory.CreateError<Function>("unable to retrieve function",HttpStatusCode.BadRequest);
            }
            var response = await GetAsync(baseUrl, $"/api/v1/Function/GetById/{id}", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<Function>>(content);
                if (workflows.HasErrors)
                {
                    return ResponseFactory.CreateError<Function>("An error occured while retrieving function", HttpStatusCode.BadRequest);

                    
                }

                return ResponseFactory.CreateSuccess<Function>(workflows.Payload,"Function Retrieved Successfully");
            }
            return ResponseFactory.CreateError<Function>("An error occured while retrieving the functions",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<List<Approvalsetup>>> GetWorkflowApprovalSetup(int id)
        {
            var token = await _authenticationHelper.GetAccessToken();
            if (token is null)
            {
                return ResponseFactory.CreateError<List<Approvalsetup>>("unable to retrieve workflow",HttpStatusCode.NotFound);
            }
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/WorkflowApprovalSetup/Search?Filters.WorkflowId={id}", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<List<Approvalsetup>>>(content);
                if (workflows.HasErrors)
                {
                    return ResponseFactory.CreateError<List<Approvalsetup>>("An error occured while retrieving the work flows.", 
                        HttpStatusCode.BadRequest);
                   
                }

                return ResponseFactory.CreateSuccess<List<Approvalsetup>>(workflows.Payload,"Work retrieved successfully");
            }
            return ResponseFactory.CreateError<List<Approvalsetup>>("An error occured while retrieving the work flows.",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<List<Function>>> GetFunctionWithIdList(List<int> ids)
        {
            var token = await GetToken();
            if (token is null)
            {
                return  ResponseFactory.CreateError<List<Function>>("unable to retrieve function",HttpStatusCode.NotFound);
            }
            var urlFilters = string.Join('&', ids.Select(x => $"Filters.Ids={x}"));
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/ApprovingOffice/Search?{urlFilters}", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<List<Function>>>(content);
                if (workflows.HasErrors)
                {
                    return ResponseFactory.CreateError<List<Function>>("An error occured while retrieving function", HttpStatusCode.BadRequest);
                   
                }

                return ResponseFactory.CreateSuccess<List<Function>>(workflows.Payload,"Function Retrieved successfully");
            }
            return ResponseFactory.CreateError<List<Function>>("An error occured while retrieving the functions",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<ApprovingOfficeLookup>> GetApprovingOfficeById(int id)
        {
            var token = await _authenticationHelper.GetAccessToken();
            if (token is null)
            {
                return ResponseFactory.CreateError<ApprovingOfficeLookup>("unable to retrieve approving office",HttpStatusCode.NotFound);
            }
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/ApprovingOffice/GetById/{id}", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<ApprovingOfficeLookup>>(content);
                if (workflows.HasErrors)
                {
                    return  ResponseFactory.CreateError<ApprovingOfficeLookup>("An error occured while retrieving  approving office", HttpStatusCode.BadRequest);
                }

                return  ResponseFactory.CreateSuccess<ApprovingOfficeLookup>(workflows.Payload,"Approving Office retrieved sucessfully");
            }
            return ResponseFactory.CreateError<ApprovingOfficeLookup>("An error occured while retrieving the  approving office",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<ApprovingPosition>> ApprovingPositionId(int id)
        {
            var token = await GetToken();
            if (token is null)
            {
                return ResponseFactory.CreateError<ApprovingPosition>("unable to retrieve Approving Position",HttpStatusCode.NotFound);
            }
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/ApprovingOfficerPosition/GetById/{id}", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<ApprovingPosition>>(content);
                if (workflows.HasErrors)
                {
                    return ResponseFactory.CreateError<ApprovingPosition>("An error occured while retrieving  approving office", HttpStatusCode.BadRequest);

                   
                }

                return  ResponseFactory.CreateSuccess<ApprovingPosition>(workflows.Payload, "Approving office successfully retrieved");
            }
            return ResponseFactory.CreateError<ApprovingPosition>("An error occured while retrieving the  approving office",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<List<ApprovingOfficeLookup>>> GetAllApprovingOffices(string search)
        {
            var token = await _authenticationHelper.GetAccessToken();
            if (token is null)
            {
                return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>("unable to retrieve Approving Offices",HttpStatusCode.NotFound);
            }
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/ApprovingOffice/Search?Filters.Name={search}", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<List<ApprovingOfficeLookup>>>(content);
                if (workflows.HasErrors)
                {
                    return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>("An error occured while retrieving  approving office",HttpStatusCode.BadRequest);
                }

                return ResponseFactory.CreateSuccess<List<ApprovingOfficeLookup>>(workflows.Payload,"Approving Office sucessfully retrived");
            }
            return ResponseFactory.CreateError<List<ApprovingOfficeLookup>>("An error occured while retrieving the  approving office",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<List<Officer>>> GetAllApprovingOfficersWithApprovingOffice(long officeId)
        {
            var token = await GetToken();
            if (token is null)
            {
                return ResponseFactory.CreateError<List<Officer>>("unable to retrieve functions",HttpStatusCode.NotFound);
            }
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/ApprovingOfficer/Search?Filters.OfficeId={officeId}", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<List<Officer>>>(content);
                if (workflows.HasErrors)
                {
                    return ResponseFactory.CreateError<List<Officer>>("An error occured while retrieving  approving office",HttpStatusCode.BadRequest);

                }

                return ResponseFactory.CreateSuccess<List<Officer>>(workflows.Payload,"Approving Office successfully retrieved");
            }
            return ResponseFactory.CreateError<List<Officer>>("An error occured while retrieving the  approving office",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<List<AdminModulesResponse>>> GetAllModules()
        {
            var token = await _authenticationHelper.GetAccessToken();
            if (token is null)
            {
                return ResponseFactory.CreateError<List<AdminModulesResponse>>("unable to retrieve modules",HttpStatusCode.NotFound);
            }
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/Module/Search?Filters.LineOfBusinessId={_options.Value.LifeLineOfBusinessId}", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<List<AdminModulesResponse>>>(content);
                if (workflows.HasErrors)
                {
                    return ResponseFactory.CreateError<List<AdminModulesResponse>>("An error occured while retrieving  modules", HttpStatusCode.BadRequest);
                }

                return ResponseFactory.CreateSuccess<List<AdminModulesResponse>>(workflows.Payload,"Modules sucessfully retrived");
            }
            return ResponseFactory.CreateError<List<AdminModulesResponse>>("An error occured while retrieving the  modules",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<List<ApprovingOffice>>> GetUserApprovingOffices(Guid userId)
        {
            var token = await GetToken();
            if (token is null)
            {
                return ResponseFactory.CreateError<List<ApprovingOffice>>("unable to retrieve Approving Position",HttpStatusCode.NotFound);
            }
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/ApprovingOfficer/Search?Filters.UserId={userId}", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<List<ApprovingOffice>>>(content);
                if (workflows.HasErrors)
                {
                    return ResponseFactory.CreateError<List<ApprovingOffice>>("An error occured while retrieving  approving office",HttpStatusCode.BadRequest);
                }

                return ResponseFactory.CreateSuccess<List<ApprovingOffice>>(workflows.Payload,"Approving Office sucessfully retrieved");
            }
            return ResponseFactory.CreateError<List<ApprovingOffice>>("An error occured while retrieving the  approving office",HttpStatusCode.InternalServerError);
        }
        public async Task<BaseResponse<List<UserOfficeFunctionsAdminResponse>>> GetUsersInformation(int functionId, int approvingOfficeId)
        {
            var token = await _authenticationHelper.GetAccessToken();
            if (token is null)
            {
                return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>("unable to retrieve Approving Position",HttpStatusCode.NotFound);
            }
            var response = await GetAsync(_options.Value.RubyAdminUrl, $"/api/v1/ApprovingOfficer/Search?Filters.OfficeId={approvingOfficeId}&Filters.FunctionId={functionId}&Filters.IncludeUserProperty=true", new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("Authorization", $"Bearer {token}") });
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workflows = JsonConvert.DeserializeObject<AdminBaseResponse<List<UserOfficeFunctionsAdminResponse>>>(content);
                if (workflows.HasErrors)
                {
                    return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>("An error occured while retrieving  approving office", HttpStatusCode.InternalServerError);
                    
                }

                return ResponseFactory.CreateSuccess<List<UserOfficeFunctionsAdminResponse>>(workflows.Payload,"Approving office retrieved sucessfully");
            }
            return ResponseFactory.CreateError<List<UserOfficeFunctionsAdminResponse>>("An error occured while retrieving the  approving office",HttpStatusCode.InternalServerError);
        }

    }
}



