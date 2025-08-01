using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities;


    public class ProductDisapproval
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public string Reason { get; set; } = null!;

        public DateTime DateCommented { get; set; }

        public int ActionUserId { get; set; }

       

        
    }



