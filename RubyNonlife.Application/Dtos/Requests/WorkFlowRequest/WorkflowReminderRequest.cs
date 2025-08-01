using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.WorkFlowRequest
{
    public class WorkflowReminderRequest
    {
        public int WorkflowId { get; set; }
    }

    public class WorkflowLogRequest
    {
        public int WorkFlowProcessId { get; set; }
        public int SourceId { get; set; }
        public string RequestTitle { get; set; }
    }

    public class WorkflowApprovalRequest : BaseApprovalRequest
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
    }

    public class BaseApprovalRequest
    {
        public bool IsApproved { get; set; }
        public string Comment { get; set; }
        public int ApprovingOfficeId { get; set; }
        public string ApproveAs { get; set; } = string.Empty;
    }

}
