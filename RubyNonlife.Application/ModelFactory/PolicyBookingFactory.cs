using RubyNonlife.Application.Dtos.Responses.WorkFlow;
using RubyNonlife.Domain.Models.ApprovalWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.ModelFactory
{
    public static class PolicyBookingFactory
    {
        public static WorkflowResponse ToWorkflowResponse(this Workflow model)
        {
            return model is null ? null : new WorkflowResponse
            {
                Id = model.Id,
                //ApprovalLevel = model.ApprovalLevel,
                //ApprovingOffice = model.ApprovingOffice,
                //ApprovingOfficeId = model.ApprovingOfficeId,
                //FunctionId = model.FunctionId,
                CreatedBy = model.CreatedBy,
                Status = model.Status,
                ProgressPercentage = model.ProgressPercentage,
                //WorkflowProcessId = model.WorkflowProcessId,
                Date = model.DateCreated,
                IsRequestCompleted = model.IsApprovalCompleted,
                SourceId = model.SourceId,
                RequestTitle = model.RequestTitle,
            };
        }
        public static WorkflowResponse ToWorkflowResponse(this Workflow model, bool isFullResponse = false)
        {
            return model is null ? null : new WorkflowResponse
            {
                Id = model.Id,
                Date = model.DateCreated,
                IsRequestCompleted = model.IsApprovalCompleted,
                SourceId = model.SourceId,
                //FunctionId = model.FunctionId,
                //ApprovingOfficeId = model.ApprovingOfficeId,
                Approvals = isFullResponse ? model.WorkflowApprovals.Select(x => x.ToWorkflowApprovalResponse()).ToList() : null,
                //ApprovalLevel = model.ApprovalLevel,
                CreatedBy = model.CreatedBy,
            };
        }
        public static WorkflowApprovalResponse ToWorkflowApprovalResponse(this WorkFlowApproval model)
        {
            return model is null ? null : new WorkflowApprovalResponse
            {
                DateCreated = model.DateCreated,
                ApproverUserId = model.ApproverUserId,
                Comment = model.Comment,
                //FullName = $"{model.ApproverUser?.Firstname} {model.ApproverUser?.Surname}",
                IsApproved = model.IsApproved,
                Id = model.Id,
            };
        }
    }
}
