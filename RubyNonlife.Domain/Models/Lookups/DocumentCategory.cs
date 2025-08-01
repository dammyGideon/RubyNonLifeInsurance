using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.Lookups
{
    public partial class DocumentCategory : BaseEntity
    {
       
        public string Name { get; set; }
        public string AppModule { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<DocumentLookup> DocumentLookups { get; set; }
    }
}
