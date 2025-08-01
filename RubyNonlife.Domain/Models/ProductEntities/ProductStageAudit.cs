using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities;

    public class ProductStageAudit : BaseEntity
    {

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string Status { get; set; } = string.Empty;
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime? DateDeleted { get; set; }

        

    


}
