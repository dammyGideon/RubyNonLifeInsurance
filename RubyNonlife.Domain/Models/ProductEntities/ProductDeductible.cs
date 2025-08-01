using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductDeductible : BaseEntity
    {
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string InsuredSubject { get; set; } // e.g., Car, Truck, etc.
        public decimal FixedAmount { get; set; }
        public decimal DeductibleRate { get; set; }
        public string ApplicationType { get; set; } // "Which is greater" or "Which is smaller"
    }
}
