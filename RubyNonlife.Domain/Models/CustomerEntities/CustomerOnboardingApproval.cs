using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomerOnboardingApproval : BaseEntity
    {
        public CustomerOnboardingApproval()
        {
            CustomerModifications = new HashSet<CustomerModification>();
        }
        public int CustomerId { get; set; }
        public string ApprovalStage { get; set; }
        public string Status { get; set; }
        public string Justification { get; set; }
        public string Comment { get; set; }
       // public int? RmId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateStatusChanged { get; set; }

        public virtual Customer Customer { get; set; }
       // public virtual RelationshipManager Rm { get; set; }
        public virtual ICollection<CustomerModification> CustomerModifications { get; set; }
    }
}
