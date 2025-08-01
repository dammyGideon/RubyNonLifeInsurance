using Microsoft.AspNetCore.Mvc;
using RubyNonlife.Application.Dtos.Requests.WorkFlowRequest;
using RubyNonlife.Application.Dtos.Responses.WorkFlow;
using RubyNonlife.Application.Dtos.Responses;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Utitlies;

namespace RubyNonlife.Api.Controllers
{

    public class WorkflowController : BaseController
    {
        private readonly IWorkflowService _workflowService;
        public WorkflowController(IWorkflowService workflowService)
        {
           
            _workflowService = workflowService ?? throw new ArgumentNullException(nameof(workflowService));
        }

        [Authorize]
        [HttpPost("request-approval")]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<bool>))]
        public async Task<IActionResult> Approvals([FromBody] WorkflowApprovalRequest workFlowApprovalRequest)
        {
            var response = await _workflowService.ProcessApproval(workFlowApprovalRequest);
            return StatusCode((int)response.StatusCode, response);

        }

        [Authorize]
        [HttpPost("reminder")]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<bool>))]
        public async Task<IActionResult> SendReminder([FromBody] WorkflowReminderRequest workFlowApprovalRequest)
        {
            var response = await _workflowService.SendReminder(workFlowApprovalRequest);
            return StatusCode((int)response.StatusCode, response);
        }

        [Authorize]
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<WorkflowResponse>))]
        public async Task<IActionResult> GetWorkflow(int id)
        {
            var response = await _workflowService.GetWorkflow(id);
            return StatusCode((int)response.StatusCode, response);
        }


        [Authorize]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<WorkflowResponse>>))]
        public async Task<IActionResult> GetWorkflows([FromQuery] WorkflowFilter request)
        {
            var response = await _workflowService.GetAllPendingWorkflow(request);
            return StatusCode((int)response.StatusCode, response);
        }


        [Authorize]
        [HttpGet("modules")]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<AdminWorkflowResponse>>))]
        public async Task<IActionResult> GetWorkflowsByModule()
        {
            var response = await _workflowService.GetAllWorkflowProcessByModule();
            return StatusCode((int)response.StatusCode, response);
        }

        //[Authorize]
        //[HttpGet("modules")]
        //[ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<AdminWorkflowResponse>>))]
        //public async Task<IActionResult> GetAllModule()
        //{
        //    var response = await _workflowService.GetAllModule();
        //    return StatusCode((int)response.StatusCode, response);
        //}

        [Authorize]
        [HttpGet("approval-setup/{workflowProcessid}")]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<AdminWorkflowResponse>>))]
        public async Task<IActionResult> GetAllApproval(int workflowProcessId)
        {
            var response = await _workflowService.GetApprovalSetup(workflowProcessId);
            return StatusCode((int)response.StatusCode, response);
        }

        [Authorize]
        [HttpGet("approvals/{workflowid}")]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<AdminWorkflowResponse>>))]
        public async Task<IActionResult> GetApprovalConfig(int workflowId)
        {
            var response = await _workflowService.GetFullApprovalSetup(workflowId);
            return StatusCode((int)response.StatusCode, response);
        }


        [Authorize]
        [HttpGet("approving-offices")]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<AdminWorkflowResponse>>))]
        public async Task<IActionResult> GetAllApprovingOfficesForProductSetup()
        {
            var response = await _workflowService.GetAllApprovingOfficesForProductSetup();
            return StatusCode((int)response.StatusCode, response);
        }


        //[Authorize]
        //[HttpGet("get-product-setup-approval")]
        //[ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<AdminWorkflowResponse>>))]
        //public async Task<IActionResult> GetProductSetupApproval([FromQuery]ProductApprovalFilterDto request)
        //{
        //    var response = await _workflowService.GetProductSetupApproval(request);
        //    return StatusCode((int)response.StatusCode, response);
        //}

        [Authorize]
        [HttpGet("get-approval-names")]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<ApprovingOfficeApproval>>))]
        public async Task<IActionResult> GetApprovalNames(int approvingId, int workflowId)
        {
            var response = await _workflowService.GetApprovalNames(approvingId, workflowId);
            return StatusCode((int)response.StatusCode, response);
        }



        [Authorize]
        [HttpGet("get-policy-book-module")]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<ApprovingOfficeApproval>>))]
        public async Task<IActionResult> GetAllWorkflowProcessByModuleForPolicyBook()
        {
            var response = await _workflowService.GetAllWorkflowProcessByModuleForPolicyBook();
            return StatusCode((int)response.StatusCode, response);
        }


        [Authorize]
        [HttpGet("get-all-pending-workflow-for-policy-booking")]
        [ProducesResponseType((int)HttpStatusCode.OK, StatusCode = (int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<ApprovingOfficeApproval>>))]
        public async Task<IActionResult> GetAllPendingWorkflowForPolicyBooking([FromQuery] WorkflowFilter request)
        {
            var response = await _workflowService.GetAllPendingWorkflowForPolicyBooking(request);
            return StatusCode((int)response.StatusCode, response);
        }

    }
}



