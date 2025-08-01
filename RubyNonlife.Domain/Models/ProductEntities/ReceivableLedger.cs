using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ReceivableLedger : BaseEntity
    {
      
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string AccountNumber { get; set; }
        public string Description { get; set; } 
        public string AccountName {  get; set; }
    }



}
