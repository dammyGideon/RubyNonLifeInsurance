using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductDurationDetail : BaseEntity
    {

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int DurationInDays { get; set; }
        public decimal Rate { get; set; }
        public string AppliedFor { get; set; } // "Annual Premium", "Quarterly Premium", etc.
    } 
}
