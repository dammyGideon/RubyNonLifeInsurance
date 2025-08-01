using Azure.Core;
using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductDocumentCategory : BaseEntity
    {
        
        public string CategoryName { get; set; }
        public string SubCategory {  get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<ProductDocument> ProductDocuments { get; set; } = new List<ProductDocument>();
    }
}
