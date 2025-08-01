using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.GenericEntities
{
    public class LineOfBusinessAttributeDropdownMapping :BaseEntity
    {
        [ForeignKey(nameof(LineOfBusinessAttributeItem))]
        public int ParentAttributeId { get; set; }
        public string ParentValue { get; set; }
        [ForeignKey(nameof(LineOfBusinessAttributeItem))]
        public int ChildAttributeId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string ChildValues { get; set; }
        public int CategoryId { get; set; }

        // Navigation property to the parent ProductSubjectTypeAttribute
        [ForeignKey("ParentAttributeId")]
        public virtual LineOfBusinessAttributeItem ParentAttribute { get; set; }

        // Navigation property to the child ProductSubjectTypeAttribute
        [ForeignKey("ChildAttributeId")]
        public virtual LineOfBusinessAttributeItem ChildAttribute { get; set; }
    }
}
