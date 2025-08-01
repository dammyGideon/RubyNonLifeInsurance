using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomerModification : BaseEntity
    {
        public CustomerModification()
        {
            CustomerModificationDocuments = new HashSet<CustomerModificationDocument>();
        }
        public int CustomerId { get; set; }
        public int? CustomerApprovalId { get; set; }
        public string CustomerOldJson { get; set; }
        public string CustomerModificationJson { get; set; }
        public string CreatedBy { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CustomerOnboardingApproval CustomerApproval { get; set; }
        public virtual ICollection<CustomerModificationDocument> CustomerModificationDocuments { get; set; }
    }
}
