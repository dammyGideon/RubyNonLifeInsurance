using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ApprovalWorks
{
    public class WorkFlowApproval : BaseEntity
    {
        [ForeignKey(nameof(Workflows))]
        public int WorkFlowId { get; set; }
        public Workflow Workflows { get; set; }
        public int ApproverUserId { get; set; }

        public int ApprovalLevel { get; set; }
        public bool IsApproved { get; set; }
        public string Comment { get; set; }
      
        public bool IsCompleted { get; set; }
        public bool? IsDeleted { get; set; }
        [ForeignKey(nameof(WorkflowApprovingOffice))]
        public int WorkflowApprovingOfficeId { get; set; }
        public WorkflowApprovingOffice WorkflowApprovingOffice { get; set; }
    
    }
}





