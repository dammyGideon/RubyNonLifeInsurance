using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomerOccupation : BaseEntity
    {
        public int CustomerId { get; set; }
        public string JobTitle { get; set; }
        public string Employer { get; set; }
        public string EmploymentType { get; set; }
        public decimal AnnualIncomeBand { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? DateLastModified { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
