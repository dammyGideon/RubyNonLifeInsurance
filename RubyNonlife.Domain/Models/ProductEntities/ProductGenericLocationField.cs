using RubyNonlife.Domain.Enums;
using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.PolicyEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductGenericLocationField : BaseEntity
    {
        [ForeignKey(nameof(ProductGenericLocation))]
        public int GenericLocationId { get; set; }
        public ProductGenericLocation ProductGenericLocation { get; set; }
        public string FieldName { get; set; }
        public FieldType FieldType { get; set; }
        public bool IsRequired { get; set; }

        public ICollection<ProductGenericLocationDropdownOption> ProductGenericLocationDropdownOptions { get; set; }
        public ICollection<PolicyBookingGenericLocation> GenericLocationAttribute { get; set; }
    }

}
