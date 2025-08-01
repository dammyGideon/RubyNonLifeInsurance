using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductSubjectCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public bool IsDeleted { get; set; }
       

        public List<ProductSubjectTypeAttribute> ProductSubjectTypeAttributes { get; set; }
        public ICollection<ProductPriceConfiguration> ProductPriceConfigurations { get; set; }
        public ICollection<ProductSubjectType> ProductSubjectTypes { get; set; }
    }
}
