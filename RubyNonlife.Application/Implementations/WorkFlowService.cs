using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.EMMA;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto;
using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Dtos.Requests.WorkFlowRequest;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.Quotation;
using RubyNonlife.Application.Dtos.Responses.WorkFlow;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Application.Helper.UtitlityModel;
using RubyNonlife.Application.Implementations;
using RubyNonlife.Application.ModelFactory;
using RubyNonlife.Application.Utitlies;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Domain.Models.ApprovalWorks;
using RubyNonlife.Domain.Models.ProductEntities;
using RubyNonlife.Infrastructure.Contract;
using RubyNonlife.Infrastructure.Persistence;
using System.Net;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static RubyNonlife.Application.Implementations.PolicyBookingService;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace RubyNonlife.Infrastructure.Implementations
{
    public class WorkFlowService : IWorkflowService
    {
        private readonly RubyDbContext _dbContext;
        private readonly IAdminServiceIntegration _adminService;
        private readonly IWorkflowEmailService _workflowEmailService;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;
        private readonly IServiceProvider _serviceProvider;

        private readonly ConfigModels _configModels;

        private readonly IHttpContextAccessor _contextAccessor;


        private readonly string GetallWorkflowsEndpoint = "/api/v1/workflow";
        private readonly string GetSingleWorkflowEndpoint = "/api/v1/workflow/";
        private readonly string InitiateApprovalWorkflowEndpoint = "/api/v1/workflow/log-approval-request";

        private readonly IFinanceServiceIntegration _serviceIntegration;
        public WorkFlowService(RubyDbContext dbContext,
            HttpClient httpClient, IOptions<ConfigModels> options,
            IAdminServiceIntegration adminService, IServiceProvider serviceProvider, IHttpContextAccessor contextAccessor,
            IWorkflowEmailService workflowEmailService, IConfiguration config, IOptions<ConfigModels> configOptions,
            IFinanceServiceIntegration financeService
            )
        {
            _dbContext = dbContext;
            _adminService = adminService;
            _httpClient = httpClient;
            _serviceProvider = serviceProvider;
            _contextAccessor = contextAccessor;
            _workflowEmailService = workflowEmailService;
            _config = config;
            _configModels = configOptions.Value;
            _serviceIntegration = financeService;
        }



        public async Task<BaseResponse<List<GenericNameResponse>>> GetAllApprovingOfficesForProductSetup()
        {
            var ids = new List<int> { _configModels.FirstAprovingOffice, _configModels.SecondApprovingOffice };
            var response = await _adminService.GetAllApprovingOfficesByIds(ids);


            // Transform List<ApprovingOfficeLookup> into GenericNameResponse
            var genericResponse = response.Data.Select(d => new GenericNameResponse()
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();
           

            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(genericResponse, "Approving offices retrieved successfully.");
        }

     
        private async Task<IQueryable<Workflow>> FilterWorkflow(IQueryable<Workflow> model, List<SearchParam> searchBaseRequest)
        {
            if (searchBaseRequest is null)
            {
                return model;
            }
            foreach (var item in searchBaseRequest)
            {
                switch (item.ColumnName.ToLower())
                {
                    case "status":
                        model = model.Where(x => x.Status == item.Value);
                        break;
                    default:
                        break;
                }
            }

            return model;
        }
        public async Task<BaseResponse<List<AdminWorkflowResponse>>> GetAllWorkflowProcessByModule()
        {
            var moduleId = _configModels.ProductWorkflowModuleId;
            var workflowRequest = await _adminService.GetAllWorkflows(moduleId);

            Task<BaseResponse<ApprovingOfficeLookup>> approvingOffice;
            Task<BaseResponse<AdminFunction>> function;
            Task<BaseResponse<ApprovingPosition>> approvingPosition;
            Task<BaseResponse<UserAdminResponse>> userAdmin;
            foreach (var item in workflowRequest.Data)
            {
                foreach (var approvalItem in item.ApprovalSetups)
                {
                    approvingOffice = Task.FromResult<BaseResponse<ApprovingOfficeLookup>>(new BaseResponse<ApprovingOfficeLookup>());
                    function = Task.FromResult<BaseResponse<AdminFunction>>(new BaseResponse<AdminFunction>());
                    approvingPosition = Task.FromResult<BaseResponse<ApprovingPosition>>(new BaseResponse<ApprovingPosition>());
                    userAdmin = Task.FromResult<BaseResponse<UserAdminResponse>>(new BaseResponse<UserAdminResponse>());

                    if (approvalItem.ApprovingOfficeId.HasValue)
                    {
                        approvingOffice = _adminService.GetApprovingOfficeById(approvalItem.ApprovingOfficeId.Value);
                    }

                    if (approvalItem.ApprovingPositionId.HasValue)
                    {
                        approvingPosition = _adminService.ApprovingPositionId(approvalItem.ApprovingPositionId.Value);
                    }

                    if (approvalItem.FunctionId.HasValue)
                    {
                        function = _adminService.GetFunctionById(approvalItem.FunctionId.Value);
                    }

                    if (approvalItem.ApprovingOfficeId.HasValue)
                    {

                    }

                    await Task.WhenAll(approvingOffice, approvingPosition, function);

                    approvalItem.ApprovingPosition = approvingPosition?.Result?.Data?.Caption;
                    approvalItem.Function = function?.Result?.Data?.Caption;
                    approvalItem.ApprovingOffice = approvingOffice?.Result?.Data?.Name;
                }
            }
            return workflowRequest;

        }

        public async Task<BaseResponse<List<AdminWorkflowResponse>>> GetAllWorkflowProcessByModuleForPolicyBook()
        {
            var moduleId = _configModels.PolicyWorkflowModuleId;
            var workflowRequest = await _adminService.GetAllWorkflows(moduleId);

            Task<BaseResponse<ApprovingOfficeLookup>> approvingOffice;
            Task<BaseResponse<AdminFunction>> function;
            Task<BaseResponse<ApprovingPosition>> approvingPosition;
            Task<BaseResponse<UserAdminResponse>> userAdmin;
            foreach (var item in workflowRequest.Data)
            {
                foreach (var approvalItem in item.ApprovalSetups)
                {
                    approvingOffice = Task.FromResult<BaseResponse<ApprovingOfficeLookup>>(new BaseResponse<ApprovingOfficeLookup>());
                    function = Task.FromResult<BaseResponse<AdminFunction>>(new BaseResponse<AdminFunction>());
                    approvingPosition = Task.FromResult<BaseResponse<ApprovingPosition>>(new BaseResponse<ApprovingPosition>());
                    userAdmin = Task.FromResult<BaseResponse<UserAdminResponse>>(new BaseResponse<UserAdminResponse>());

                    if (approvalItem.ApprovingOfficeId.HasValue)
                    {
                        approvingOffice = _adminService.GetApprovingOfficeById(approvalItem.ApprovingOfficeId.Value);
                    }

                    if (approvalItem.ApprovingPositionId.HasValue)
                    {
                        approvingPosition = _adminService.ApprovingPositionId(approvalItem.ApprovingPositionId.Value);
                    }

                    if (approvalItem.FunctionId.HasValue)
                    {
                        function = _adminService.GetFunctionById(approvalItem.FunctionId.Value);
                    }

                    if (approvalItem.ApprovingOfficeId.HasValue)
                    {

                    }

                    await Task.WhenAll(approvingOffice, approvingPosition, function);

                    approvalItem.ApprovingPosition = approvingPosition?.Result?.Data?.Caption;
                    approvalItem.Function = function?.Result?.Data?.Caption;
                    approvalItem.ApprovingOffice = approvingOffice?.Result?.Data?.Name;
                }
            }
            return workflowRequest;

        }

        public async Task<BaseResponse<List<Approvalsetup>>> GetApprovalSetup(int workflowProcessId)
        {
            var workflowRequest = await _adminService.GetWorkflowApprovalSetup(workflowProcessId);
            Task<BaseResponse<ApprovingOfficeLookup>> approvingOffice;
            Task<BaseResponse<AdminFunction>> function;
            Task<BaseResponse<ApprovingPosition>> approvingPosition;

            foreach (var approvalItem in workflowRequest.Data)
            {
                approvingOffice = Task.FromResult<BaseResponse<ApprovingOfficeLookup>>(new BaseResponse<ApprovingOfficeLookup>());
                function = Task.FromResult<BaseResponse<AdminFunction>>(new BaseResponse<AdminFunction>());
                approvingPosition = Task.FromResult<BaseResponse<ApprovingPosition>>(new BaseResponse<ApprovingPosition>());

                if (approvalItem.ApprovingOfficeId.HasValue)
                {
                    approvingOffice = _adminService.GetApprovingOfficeById(approvalItem.ApprovingOfficeId.Value);
                }

                if (approvalItem.ApprovingPositionId.HasValue)
                {
                    approvingPosition = _adminService.ApprovingPositionId(approvalItem.ApprovingPositionId.Value);
                }

                if (approvalItem.FunctionId.HasValue)
                {
                    function = _adminService.GetFunctionById(approvalItem.FunctionId.Value);
                }

                await Task.WhenAll(approvingOffice, approvingPosition, function);

                approvalItem.ApprovingPosition = approvingPosition?.Result?.Data?.Caption;
                approvalItem.Function = function?.Result?.Data?.Caption;
                approvalItem.ApprovingOffice = approvingOffice?.Result?.Data?.Name;
            }
            return workflowRequest;
        }

        public async Task<BaseResponse<PaginatedWorkflowResponse>> GetAllPendingWorkflow(WorkflowFilter model)
        {
            var workFlowQuery = _dbContext.Workflows
                .Include(d => d.WorkflowApprovingOffices)
                .Where(x => x.WorkflowProcessIds.Contains(model.WorkFlowId))
                .OrderByDescending(x => x.Id)
                .AsQueryable();

            var officeResult = await _adminService.GetAllWorkflows(_configModels.ProductWorkflowModuleId);
            var office = officeResult.Data.FirstOrDefault(w => w.Id == model.WorkFlowId);

            if (office == null)
            {
                return ResponseFactory.CreateError<PaginatedWorkflowResponse>("No office found for the provided WorkFlowId.", HttpStatusCode.NotFound);
            }

            var approvingOfficeId = office?.ApprovalSetups?.FirstOrDefault()?.ApprovingOfficeId;

            workFlowQuery = workFlowQuery
                .Where(x => x.WorkflowApprovingOffices.Any(a => a.ApprovingOfficeId == approvingOfficeId));

            if (model.IsPendingRequest.HasValue)
            {
                workFlowQuery = workFlowQuery.Where(x =>
                    x.WorkflowApprovingOffices.Any(a =>
                        a.ApprovingOfficeId == approvingOfficeId &&
                        (model.IsPendingRequest.Value
                            ? a.ApprovalStatus == ApprovalStatusEnum.Pending.GetDescription()
                            : a.ApprovalStatus == ApprovalStatusEnum.Approved.GetDescription())));
            }

            workFlowQuery = await FilterWorkflow(workFlowQuery, model.SearchParams);

            var pagedWorkFlow = await PagedList<Workflow>.ToPagedList(workFlowQuery, model.PageNumber, model.PageSize);

            var productList = await _dbContext.Products.ToListAsync();
            var productMap = productList.ToDictionary(p => p.Id, p => p);

            var responseData = pagedWorkFlow.Select(x =>
            {
                var relevantApprovals = x.WorkflowApprovingOffices
                    .Where(a => a.ApprovingOfficeId == approvingOfficeId)
                    .ToList();

                var total = relevantApprovals.Count;
                var approved = relevantApprovals.Count(a => a.ApprovalStatus == ApprovalStatusEnum.Approved.GetDescription());
                var rejected = relevantApprovals.Any(a => a.ApprovalStatus == ApprovalStatusEnum.Rejected.GetDescription());
                var onHold = relevantApprovals.Any(a => a.IsOnHold);

                string status;
                int progress;

                if (onHold)
                {
                    status = "On Hold";
                    progress = 0;
                }
                else if (rejected)
                {
                    status = "Rejected";
                    progress = 0;
                }
                else if (approved == total && total > 0)
                {
                    status = "Approved";
                    progress = 100;
                }
                else
                {
                    status = "Pending";
                    progress = (int)(((double)approved / total) * 100);
                }

                return new WorkflowResponse
                {
                    WorkflowProcessId = model.WorkFlowId,
                    CreatedBy = x.CreatedBy,
                    Date = x.DateCreated,
                    Id = x.Id,
                    Status = status,
                    RequestTitle = x.RequestTitle,
                    IsRequestCompleted = status == "Approved",
                    ProgressPercentage = progress,
                    SourceId = x.SourceId,
                    ProductAlias = productMap.ContainsKey(x.SourceId.GetValueOrDefault())
                                                            ? productMap[x.SourceId.GetValueOrDefault()].Alias
                                                            : null,
                    ProductDescription = productMap.ContainsKey(x.SourceId.GetValueOrDefault()) ? productMap[x.SourceId.GetValueOrDefault()].Description : null,
                    ApprovingOfficeId = approvingOfficeId
                };
            }).ToList();

            var paginatedResponse = new PaginatedWorkflowResponse
            {
                PageNumber = pagedWorkFlow.PageNumber,
                PageSize = pagedWorkFlow.PageSize,
                TotalCount = pagedWorkFlow.TotalCount,
                TotalPages = pagedWorkFlow.TotalPages,
                HasPreviousPage = pagedWorkFlow.HasPreviousPage,
                HasNextPage = pagedWorkFlow.HasNextPage,
                WorkflowResponse = responseData
            };

            return ResponseFactory.CreateSuccess(paginatedResponse, "");
        }



        public async Task<BaseResponse<PaginatedWorkflowResponse>> GetAllPendingWorkflowForPolicyBooking(WorkflowFilter model)
        {
            var workFlowQuery = _dbContext.Workflows
                .Include(d => d.WorkflowApprovingOffices)
                .Where(x => x.WorkflowProcessIds.Contains(model.WorkFlowId))
                .OrderByDescending(x => x.Id)
                .AsQueryable();

            var officeResult = await _adminService.GetAllWorkflows(_configModels.PolicyWorkflowModuleId);
            var office = officeResult.Data.FirstOrDefault(w => w.Id == model.WorkFlowId);

            if (office == null)
            {
                return ResponseFactory.CreateError<PaginatedWorkflowResponse>("No office found for the provided WorkFlowId.", HttpStatusCode.NotFound);
            }

            var approvingOfficeId = office?.ApprovalSetups?.FirstOrDefault()?.ApprovingOfficeId;

            workFlowQuery = workFlowQuery
                .Where(x => x.WorkflowApprovingOffices.Any(a => a.ApprovingOfficeId == approvingOfficeId));

            if (model.IsPendingRequest.HasValue)
            {
                workFlowQuery = workFlowQuery.Where(x =>
                    x.WorkflowApprovingOffices.Any(a =>
                        a.ApprovingOfficeId == approvingOfficeId &&
                        (model.IsPendingRequest.Value
                            ? a.ApprovalStatus == ApprovalStatusEnum.Pending.GetDescription()
                            : a.ApprovalStatus == ApprovalStatusEnum.Approved.GetDescription())));
            }

            workFlowQuery = await FilterWorkflow(workFlowQuery, model.SearchParams);

            var pagedWorkFlow = await PagedList<Workflow>.ToPagedList(workFlowQuery, model.PageNumber, model.PageSize);

            var productList = await _dbContext.Products.ToListAsync();
            var productMap = productList.ToDictionary(p => p.Id, p => p);

            var responseData = pagedWorkFlow.Select(x =>
            {
                var relevantApprovals = x.WorkflowApprovingOffices
                    .Where(a => a.ApprovingOfficeId == approvingOfficeId)
                    .ToList();

                var total = relevantApprovals.Count;
                var approved = relevantApprovals.Count(a => a.ApprovalStatus == ApprovalStatusEnum.Approved.GetDescription());
                var rejected = relevantApprovals.Any(a => a.ApprovalStatus == ApprovalStatusEnum.Rejected.GetDescription());
                var onHold = relevantApprovals.Any(a => a.IsOnHold);

                string status;
                int progress;

                if (onHold)
                {
                    status = "On Hold";
                    progress = 0;
                }
                else if (rejected)
                {
                    status = "Rejected";
                    progress = 0;
                }
                else if (approved == total && total > 0)
                {
                    status = "Approved";
                    progress = 100;
                }
                else
                {
                    status = "Pending";
                    progress = (int)(((double)approved / total) * 100);
                }

                return new WorkflowResponse
                {
                    WorkflowProcessId = model.WorkFlowId,
                    CreatedBy = x.CreatedBy,
                    Date = x.DateCreated,
                    Id = x.Id,
                    Status = status,
                    RequestTitle = x.RequestTitle,
                    IsRequestCompleted = status == "Approved",
                    ProgressPercentage = progress,
                    SourceId = x.SourceId,
                    ProductAlias = productMap.ContainsKey(x.SourceId.GetValueOrDefault()) ? productMap[x.SourceId.GetValueOrDefault()].Alias : null,
                    ProductDescription = productMap.ContainsKey(x.SourceId.GetValueOrDefault()) ? productMap[x.SourceId.GetValueOrDefault()].Description : null,
                    ApprovingOfficeId = approvingOfficeId
                };
            }).ToList();

            var paginatedResponse = new PaginatedWorkflowResponse
            {
                PageNumber = pagedWorkFlow.PageNumber,
                PageSize = pagedWorkFlow.PageSize,
                TotalCount = pagedWorkFlow.TotalCount,
                TotalPages = pagedWorkFlow.TotalPages,
                HasPreviousPage = pagedWorkFlow.HasPreviousPage,
                HasNextPage = pagedWorkFlow.HasNextPage,
                WorkflowResponse = responseData
            };

            return ResponseFactory.CreateSuccess(paginatedResponse, "");
        }
        public async Task<BaseResponse<List<Approvalsetup>>> GetFullApprovalSetup(int workflowId)
        {
            // Get workflow with included approvals
            var workflow = _dbContext.Workflows
                .Where(x => x.Id == workflowId)
                .Include(x => x.WorkflowApprovals)
                .FirstOrDefault();

            if (workflow == null)
            {
                return ResponseFactory.CreateError<List<Approvalsetup>>("Workflow not found", HttpStatusCode.NotFound);
            }

  
            throw new NotImplementedException();
        }
        public async Task<BaseResponse<WorkflowResponse>> GetWorkflow(int id)
        {
            throw new NotImplementedException ();
        }
        public async Task<BaseResponse<List<ApprovingOfficeApproval>>> GetApprovalNames(int approvingId, int workflowId)
        {
            // Step 1: Fetch WorkflowApprovingOffices for the given approvingId and workflowId
            var workflowApprovingOffices = await _dbContext.WorkflowApprovingOffices
                .Include(d => d.Workflows)
                .Where(x => x.ApprovingOfficeId == approvingId && x.WorkflowId == workflowId)
                .ToListAsync();

            if (!workflowApprovingOffices.Any())
            {
                return ResponseFactory.CreateError<List<ApprovingOfficeApproval>>(
                    "Could not retrieve workflow with the selected approving office", HttpStatusCode.NotFound);
            }

            // Step 2: Extract their IDs to find exact matching approvals
            var workflowApprovingOfficeIds = workflowApprovingOffices.Select(x => x.Id).ToList();

            // Step 3: Fetch WorkFlowApprovals based on WorkflowApprovingOfficeId
            var workflowApprovals = await _dbContext.WorkFlowApprovals
                .Where(wa => workflowApprovingOfficeIds.Contains(wa.WorkflowApprovingOfficeId))
                .ToListAsync();

            var officeResponse = new List<ApprovingOfficeApproval>();

            // Step 4: Loop through WorkflowApprovingOffices
            foreach (var workflowOffice in workflowApprovingOffices)
            {
                var functionId = workflowOffice.FunctionId;
                var approvalLevel = workflowOffice.ApprovalLevel;
                var workflowApprovingOfficeId = workflowOffice.Id;

                // Step 5: Get users for the office/function combo
                var usersResult = await _adminService.GetUsersInformation(functionId, approvingId);
                if (usersResult?.Data == null || !usersResult.Data.Any())
                    continue;

                // Step 6: Fetch the matching approval for this exact office-level
                var approval = workflowApprovals.FirstOrDefault(wa => wa.WorkflowApprovingOfficeId == workflowApprovingOfficeId);

                foreach (var user in usersResult.Data)
                {
                    officeResponse.Add(new ApprovingOfficeApproval
                    {
                        ApprovalName = user.User.FullName,
                        Sequence = approvalLevel,
                        Comment = approval?.Comment,
                        ApproveDate = approval?.DateCreated
                    });
                }
            }

            if (!officeResponse.Any())
            {
                return ResponseFactory.CreateError<List<ApprovingOfficeApproval>>("No approvals found", HttpStatusCode.NotFound);
            }

            return ResponseFactory.CreateSuccess(officeResponse, "Approvals successfully retrieved");
        }
        public async Task<BaseResponse<bool>> SendReminder(WorkflowReminderRequest request)
        {
            var workflow = await _dbContext.Workflows.Where(x => x.Id == request.WorkflowId).FirstOrDefaultAsync();
            if (workflow is null)
            {
                return ResponseFactory.CreateError<bool>("Could not retrieve workflow with the selected id", HttpStatusCode.NotFound);
            }
            return ResponseFactory.GetSuccessResponse<bool>(true, "");

        }
        public async Task<BaseResponse<WorkflowLogResponse>> InitiateApproval(WorkflowLogRequest model)
        {

            throw new NotImplementedException();

           
        }


        #region Approval Process
        public async Task<BaseResponse<bool>> ProcessApproval(WorkflowApprovalRequest model)
        {
            var workflow = await _dbContext.Workflows.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (workflow == null)
                return ResponseFactory.CreateError<bool>("No record found.", HttpStatusCode.NotFound);


            var workflowApprovingOffices = await _dbContext.WorkflowApprovingOffices
                .Include(d => d.Workflows)
                .Where(x => x.ApprovingOfficeId == model.ApprovingOfficeId && x.WorkflowId == workflow.Id)
                .OrderBy(x => x.ApprovalLevel)
                .ToListAsync();

            var firstIncompleteApproval = workflowApprovingOffices
                .FirstOrDefault(x => !x.IsApprovalCompleted && (!x.IsOnHold || x.HeldByUserId == GetUserId()));

            if (firstIncompleteApproval == null)
                return ResponseFactory.CreateError<bool>("All approval levels have already been completed", HttpStatusCode.BadRequest);

            var authenticatedUser = GetUserClaims();

            if (string.IsNullOrEmpty(authenticatedUser))
                return ResponseFactory.CreateError<bool>("Authenticated user not found", HttpStatusCode.Unauthorized);

            var workflowConfig = await _adminService.GetUsersInformation(firstIncompleteApproval.FunctionId, model.ApprovingOfficeId);
            if (workflowConfig?.Data == null || !workflowConfig.Data.Any())
                return ResponseFactory.CreateError<bool>("No workflow data found", HttpStatusCode.BadRequest);

            var userConfig = workflowConfig.Data.First();

            if (authenticatedUser != userConfig.User.AdUsername)
            {
                return ResponseFactory.CreateError<bool>(
                    $"User does not have the required privilege {authenticatedUser}",
                    HttpStatusCode.Unauthorized
                );
            }

            // Principal validation
            if (model.ApproveAs == ApprovalStatusEnum.Principal.GetDescription())
                 return await HandleApproval(model, workflow, firstIncompleteApproval);

            // Route to appropriate handler
            if (model.ApproveAs == ApprovalStatusEnum.Hold.GetDescription())
                     return await HandleHold(firstIncompleteApproval);

            if (model.IsApproved)
                return await HandleApproval(model, workflow, firstIncompleteApproval);

            return await HandleDecline(model, workflow, firstIncompleteApproval);
        }
        private async Task<BaseResponse<bool>> HandleHold(WorkflowApprovingOffice approvalOffice)
        {
          
            approvalOffice.IsOnHold = true;
            approvalOffice.HeldByUserId = GetUserId();
           
            _dbContext.WorkflowApprovingOffices.Update(approvalOffice);
            await _dbContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccess<bool>(true, "Approval placed on hold.");
        }
        private async Task<BaseResponse<bool>> HandleApproval(WorkflowApprovalRequest model, Workflow workflow, WorkflowApprovingOffice approvalOffice)
        {
            var approval = new WorkFlowApproval
            {
                ApproverUserId = GetUserId(),
                Comment = model.Comment,
                IsApproved = true,
                ApprovalLevel = approvalOffice.ApprovalLevel,
                WorkFlowId = workflow.Id,
                DateCreated = DateTime.Now,
                WorkflowApprovingOfficeId = approvalOffice.Id,
                
            };

            approvalOffice.IsOnHold = false;
            approvalOffice.HeldByUserId = null;
            approvalOffice.IsApprovalCompleted = true;
            approvalOffice.ApprovalStatus = ApprovalStatusEnum.Approved.GetDescription();
            _dbContext.WorkflowApprovingOffices.Update(approvalOffice);

            await _dbContext.WorkFlowApprovals.AddAsync(approval);
            await _dbContext.SaveChangesAsync();

            await UpdateWorkflowProgress(workflow.Id);

            // Re-check after updating progress if all are approved
            var allApproved = await _dbContext.WorkflowApprovingOffices
                .Where(x => x.WorkflowId == workflow.Id)
                .AllAsync(x => x.IsApprovalCompleted);

            if (allApproved)
            {
                _dbContext.Workflows.Update(workflow);
                await _dbContext.SaveChangesAsync();
            }

            return ResponseFactory.CreateSuccess<bool>(true, $"Approval processed.");
        }
        private async Task<BaseResponse<bool>> HandleDecline(WorkflowApprovalRequest model, Workflow workflow, WorkflowApprovingOffice approvalOffice)
        {
            var approval = new WorkFlowApproval
            {
                ApproverUserId = GetUserId(),
                Comment = model.Comment,
                IsApproved = false,
                ApprovalLevel = approvalOffice.ApprovalLevel,
                WorkFlowId = workflow.Id,
                DateCreated = DateTime.Now,
                WorkflowApprovingOfficeId = approvalOffice.Id
            };

            // Reset all approval levels for the workflow
            var allApprovals = await _dbContext.WorkflowApprovingOffices
                .Where(x => x.WorkflowId == workflow.Id)
                .ToListAsync();

            foreach (var item in allApprovals)
            {
                item.IsApprovalCompleted = false;
                item.IsOnHold = false;
                item.HeldByUserId = null;
                item.ApprovalStatus = ApprovalStatusEnum.Rejected.GetDescription();
            }

            _dbContext.WorkflowApprovingOffices.UpdateRange(allApprovals);

           
            if(workflow.Type == "Product")
            {
                var product = await _dbContext.Products.FirstOrDefaultAsync(d => d.Id == model.SourceId);

                if (product != null)
                {
                    product.PercentageProgress = 0;
                    product.ApprovalStatus = ApprovalStatusEnum.Rejected.GetDescription();
                    product.SetupStatus = ApprovalStatusEnum.Rejected.GetDescription();

                    workflow.Status = ApprovalStatusEnum.Rejected.GetDescription();
                    workflow.ProgressPercentage = 0;
                    workflow.IsApprovalCompleted = false;

                    _dbContext.Products.Update(product);

                }
            }
            else
            {
                var policy = await _dbContext.PolicyBookings.FirstOrDefaultAsync(d => d.Id == model.SourceId);
                _dbContext.Update(policy);

                    

            }

           

            _dbContext.Workflows.Update(workflow);

            await _dbContext.WorkFlowApprovals.AddAsync(approval); 
            await _dbContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccess<bool>(false, "Approval declined. All progress reset.");
        }
        
        
        private async Task UpdateWorkflowProgress(int workflowId)
        {
            var productService = _serviceProvider.GetRequiredService<IProductSetupService>();
            var policyService  = _serviceProvider.GetRequiredService<IPolicyBookingService>();

            var workflow = await _dbContext.Workflows.FirstOrDefaultAsync(w => w.Id == workflowId);
            if (workflow == null) return;

            var workflowApprovingOffices = await _dbContext.WorkflowApprovingOffices
                .Where(x => x.WorkflowId == workflowId)
                .ToListAsync();

            var completedApprovals = workflowApprovingOffices.Count(x => x.IsApprovalCompleted);
            var totalApprovals = workflowApprovingOffices.Count;

            var progressPercentage = totalApprovals == 0 ? 0 : (completedApprovals / (double)totalApprovals) * 100;

            workflow.ProgressPercentage = (int)progressPercentage;

            // Only set to approved when all approvals are completed and progress is 100%
            workflow.IsApprovalCompleted = progressPercentage == 100;
            workflow.Status = progressPercentage == 100 ? ApprovalStatusEnum.Approved.GetDescription() : "Pending";

            _dbContext.Workflows.Update(workflow);

            // Approve the associated product if the workflow is approved
            if (progressPercentage == 100 && workflow.SourceId.HasValue)
            {
                if(workflow.Type == "Product")
                {
                    await productService.ApproveProduct(workflow.SourceId.GetValueOrDefault());
                }
                else if (workflow.Type == "Policy")
                {
                    await policyService.ApprovePolicy(workflow.SourceId.GetValueOrDefault());

                }

                
            }

            await _dbContext.SaveChangesAsync();
        }



        #endregion


        public async Task<BaseResponse<List<AdminModulesResponse>>> GetAllModule()
        {
            var response = await _adminService.GetAllModules();

            foreach (var module in response.Data)
            {
                module.PendingCount = _dbContext.Workflows.Count(x => x.ModuleId == module.Id && !x.IsApprovalCompleted);
            }
            return ResponseFactory.CreateSuccess<List<AdminModulesResponse>>(response.Data, "All Modules Retrieved Successfully");
        }
       
        private string GetUserClaims()
        {
            var userNameClaim = _contextAccessor.HttpContext?.User?.FindFirst("UserName")?.Value;
            return !string.IsNullOrEmpty(userNameClaim) ? userNameClaim : "Anonymous";
        }
        private int GetUserId()
        {
            var userNameClaim = _contextAccessor.HttpContext?.User?.FindFirst("UserId")?.Value;

            if (int.TryParse(userNameClaim, out int userId))
            {
                return userId;
            }
            return 0;
        }

        //private string GetUserUuid()
        //{
        //    return _contextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        //}


        public async Task<string> GeneratePolicyKeyAsync(int policyId)
        {
            string prefix = "G/";
            string business = "";

            // Get the ProductId from PolicyBookings
            var productId = await _dbContext.PolicyBookings
                .Where(d => d.Id == policyId)
                .Select(d => d.ProductId)
                .FirstOrDefaultAsync();

            if (productId == 0)
                return null; // ProductId not found, handle error if needed

            // Get the first letter of Location from BookingSbus
            var firstLetter = await _dbContext.BookingSbus
                .Where(d => d.BookingId == policyId)
                .Select(d => d.Location)
                .Distinct()
                .FirstOrDefaultAsync();

            if (firstLetter == null)
                return null;

            var firstLetterOfLocation = firstLetter.Length > 0 ? firstLetter[0].ToString().ToUpper() : string.Empty;

            // Get BusinessType and handle accordingly
            var businessType = await _dbContext.BookingBusinessInformation
                .FirstOrDefaultAsync(d => d.BookingId == policyId);

            if (businessType != null)
            {
                if (businessType.BusinessType == "Co-Insurance")
                {
                    business = "Co";
                }
                else if (businessType.BusinessType == "Sole Insurance")
                {
                    business = "D";
                }
                else
                {
                    business = "F";
                }
            }
            else
            {
                business = "F"; // Default to "F" if no business type is found
            }

            // Construct the suffix
            string suffix = $"/{firstLetterOfLocation}/{business}";

            // Get the product name and abbreviation
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null)
                return null; // Handle missing product case

            string productAbbreviation = GetAbbreviation(product.Name ?? "XX"); // fallback to "XX" if product name is null

            // Get the year suffix
            string yearSuffix = DateTime.UtcNow.Year.ToString().Substring(2); // e.g., "25"

            // Construct the final Policy Key
            return $"{prefix}{productAbbreviation}/{554283}/{yearSuffix}{suffix}";
        }

        public static string GetAbbreviation(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
                return "XX";

            var words = productName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 1)
            {
                return new string(productName
                    .Where(char.IsLetter)
                    .Take(2)
                    .Select(char.ToUpper)
                    .ToArray());
            }

            return string.Concat(words.Select(w => char.ToUpper(w[0])));
        }


    }


}
