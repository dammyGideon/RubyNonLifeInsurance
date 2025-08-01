using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ApprovalWorks
{
    public class Workflow : BaseEntity
    {

        public int ModuleId { get; set; }

        public string Status { get; set; } = null!;

        public string RequestTitle { get; set; } = null!;

        public List<int> WorkflowProcessIds { get; set; } = new List<int>();

        public string CreatedBy { get; set; } = null!;

        public int ProgressPercentage { get; set; }

        public int? SourceId { get; set; }

        public bool IsServiceNotified { get; set; }

        public bool IsApprovalCompleted { get; set; }
        public int? PolicySourceId { get; set; }

        public string Type { get; set; }

        public ICollection<WorkFlowApproval> WorkflowApprovals { get; set; } = new List<WorkFlowApproval>();
        public ICollection<WorkflowApprovingOffice> WorkflowApprovingOffices = new List<WorkflowApprovingOffice>();

    }


    public class WorkflowApprovingOffice : BaseEntity
    {
        public int WorkflowId {  get; set; }
        public Workflow Workflows {  get; set; }
        public bool IsApprovalCompleted { get; set; }

        public string? ApprovingOffice { get; set; }

        public int ApprovingOfficeId { get; set; }

        public int FunctionId { get; set; }

        public int ApprovalLevel { get; set; }

        public bool IsOnHold { get; set; } = false;
        public int? HeldByUserId { get; set; }
        public string ApprovalStatus { get; set; } = string.Empty;
        public ICollection<WorkFlowApproval> WorkFlowApprovals {  get; set; }

    }
}
