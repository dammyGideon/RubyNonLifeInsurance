using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.QuoteEntities
{
    public class QuotationAttribute : BaseEntity
    {
        public string AttributeName { get; set; }   
        public string DataType { get; set; }        
                

        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

       
    }

}
