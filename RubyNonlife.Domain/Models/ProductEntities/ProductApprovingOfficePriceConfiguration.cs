using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductApprovingOfficePriceConfiguration : BaseEntity
    {

        [ForeignKey(nameof(ProductPriceConfiguration))]
        public int ConfigurationId { get; set; }
        public ProductPriceConfiguration ProductPriceConfiguration { get; set; }  

        public int FunctionId { get; set; }

        public decimal MinPricePercentage { get; set; }
        public decimal MaxPricePercentage { get; set; }
    }
}
