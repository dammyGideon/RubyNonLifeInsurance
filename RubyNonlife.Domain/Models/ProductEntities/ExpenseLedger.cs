using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ExpenseLedger
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string AccountNumber { get; set; }
        public string Description { get; set; } 
        public string AccountName { get; set; }
        
    }



}
