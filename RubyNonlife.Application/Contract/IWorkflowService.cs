using RubyNonlife.Application.Dtos.Requests.WorkFlowRequest;
using RubyNonlife.Application.Dtos.Responses.WorkFlow;
using RubyNonlife.Application.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RubyNonlife.Application.Utitlies;

namespace RubyNonlife.Application.Contract
{
    public interface IWorkflowService
    {

        Task<BaseResponse<WorkflowLogResponse>> InitiateApproval(WorkflowLogRequest model);
        Task<BaseResponse<bool>> ProcessApproval(WorkflowApprovalRequest model);
        Task<BaseResponse<WorkflowResponse>> GetWorkflow(int id);
        Task<BaseResponse<PaginatedWorkflowResponse>> GetAllPendingWorkflow(WorkflowFilter model);
        Task<BaseResponse<List<AdminModulesResponse>>> GetAllModule();
        Task<BaseResponse<bool>> SendReminder(WorkflowReminderRequest request);
        Task<BaseResponse<List<Approvalsetup>>> GetApprovalSetup(int workflowProcessId);
        Task<BaseResponse<List<Approvalsetup>>> GetFullApprovalSetup(int workflowId);

        Task<BaseResponse<List<AdminWorkflowResponse>>> GetAllWorkflowProcessByModule();
        Task<BaseResponse<List<GenericNameResponse>>> GetAllApprovingOfficesForProductSetup();


        Task<BaseResponse<List<ApprovingOfficeApproval>>> GetApprovalNames(int approvingId, int workflowId);
        Task<BaseResponse<List<AdminWorkflowResponse>>> GetAllWorkflowProcessByModuleForPolicyBook();
        Task<BaseResponse<PaginatedWorkflowResponse>> GetAllPendingWorkflowForPolicyBooking(WorkflowFilter model);

    }
            //Task<BaseResponse<PaginatedProductApprovalResponse>> GetProductSetupApproval(ProductApprovalFilterDto request);
        
}
