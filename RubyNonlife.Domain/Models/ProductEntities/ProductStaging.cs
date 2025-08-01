using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.NonLifeProduct
{
    public class ProductStaging : BaseEntity
    {
        public string ProductName { get; set; }
        public string Data {  get; set; }
        public int? UserId { get; set; }
        public string ProductStatus { get; set; }
    }
}
