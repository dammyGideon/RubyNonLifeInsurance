using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductCategorySelection : BaseEntity
    {
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; } 
        public bool IsGeneric { get; set; } 
        public int CategoryId { get; set; }
        public virtual Product Product { get; set; }
    }
}
