using Microsoft.EntityFrameworkCore;
using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;
using System.ComponentModel.DataAnnotations.Schema;


namespace RubyNonlife.Domain.Models.GenericEntities
{
    public class LineOfBusinessAttributeItem : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public LineOfBusinessAttributeCategory LineOfBusinessAttributeCategory { get; set; }
        public bool IsSumAssured { get; set; }

        [Column(TypeName = "json")]
        public List<BusinessAttributeItemDropdownValues> BusinessAttributeItemDropdownValues { get; set; }

        public string DataType { get; set; }
        public bool RequiredAtQuoting { get; set; }
        public bool ViolationSpecification { get; set; }
        public bool IsNew { get; set; } = false;
        public bool IsEditable { get; set; } = false;

        public virtual ICollection<LineOfBusinessAttributeDropdownMapping> LineOfBusinessAttributeDropdownMapping { get; set; }
    }
}

[Owned]
public class BusinessAttributeItemDropdownValues
{
    public string Value { get; set; }
}
