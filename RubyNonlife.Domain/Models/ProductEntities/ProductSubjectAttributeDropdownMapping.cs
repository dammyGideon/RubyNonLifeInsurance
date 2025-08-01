using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductSubjectAttributeDropdownMapping : BaseEntity
    {
       
        [ForeignKey(nameof(ProductSubjectTypeAttribute))]
        public int ParentAttributeId { get; set; }
        public string ParentValue { get; set; }
        [ForeignKey(nameof(ProductSubjectTypeAttribute))]
        public int ChildAttributeId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string ChildValues { get; set; }
        public int ProductId { get; set; }

        // Navigation property to the parent ProductSubjectTypeAttribute
        [ForeignKey("ParentAttributeId")]
        public virtual ProductSubjectTypeAttribute ParentAttribute { get; set; }

        // Navigation property to the child ProductSubjectTypeAttribute
        [ForeignKey("ChildAttributeId")]
        public virtual ProductSubjectTypeAttribute ChildAttribute { get; set; }

       
      


    }

}
