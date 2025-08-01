using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomerModificationDocument : BaseEntity
    {
        public int CustomerModificationId { get; set; }
        public int CustomerId { get; set; }
        public int DocumentTypeId { get; set; }
        public int DocumentName { get; set; }
        public string MimeType { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }

        public virtual CustomerModification CustomerModification { get; set; }
        public virtual DocumentLookup DocumentType { get; set; }
    }
}
