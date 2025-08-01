using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductGenericLocationDropdownOption : BaseEntity
    {
        [ForeignKey(nameof(ProductGenericLocationField))]
        public int LocationFieldId { get; set; }
        public ProductGenericLocationField ProductGenericLocationField { get; set; }
        public string Value { get; set; }
    }

}
