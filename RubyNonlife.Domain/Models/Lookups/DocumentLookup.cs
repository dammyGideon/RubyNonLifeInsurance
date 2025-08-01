using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RubyNonlife.Domain.Models.CustomerEntities;


#nullable disable

namespace RubyNonlife.Domain.Models.Lookups
{
    public partial class DocumentLookup : BaseEntity
    {
        public DocumentLookup()
        {
            CustomerDocuments = new HashSet<CustomerDocument>();
          
        }

        [ForeignKey(nameof(DocumentCategory))]
        public int DocumentCategoryId { get; set; }
        public string Name { get; set; }
        public string ApprovalDocUid { get; set; }
        public string Description { get; set; }
        public string AcceptableMimeTypes { get; set; }

        public virtual DocumentCategory DocumentCategory { get; set; }
        public virtual ICollection<CustomerDocument> CustomerDocuments { get; set; }
       
    }
}
