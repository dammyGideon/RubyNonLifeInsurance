using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    // 3. Duration Rate Model
    public class ProductDurationRate : BaseEntity
    {
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public bool DurationRate {  get; set; }
     
        
    }
}
