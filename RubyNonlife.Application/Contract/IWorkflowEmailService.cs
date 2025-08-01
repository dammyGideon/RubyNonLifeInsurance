using RubyNonlife.Domain.Enums;
using RubyNonlife.Domain.Models.ApprovalWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Contract
{
    public interface IWorkflowEmailService
    {
        public Task<RequestExecutionStatus> WorkflowLogged(List<string> emails, Workflow workflow);
        public Task<RequestExecutionStatus> WorkflowApproved(List<string> emails, Workflow workflow);
        public Task<RequestExecutionStatus> WorkflowDeclined(List<string> emails, Workflow workflow);
        public Task<RequestExecutionStatus> WorkflowFinalApproval(List<string> emails, Workflow workflow);
        public Task<RequestExecutionStatus> WorkflowReminder(List<string> emails, Workflow workflow);
    }
}
