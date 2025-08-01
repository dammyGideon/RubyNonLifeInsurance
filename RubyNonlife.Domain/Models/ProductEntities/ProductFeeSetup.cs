using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductFeeSetup : BaseEntity
    {
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string FeeName { get; set; }
        public decimal PercentageValue { get; set; }
        public string Description { get; set; }
    }
}
