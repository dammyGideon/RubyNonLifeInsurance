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
    public class QuotationBaseCover : BaseEntity
    {
        
        [ForeignKey(nameof(ProductBaseSubjectTypeCover))]
        public int ProductBaseSubjectTypeCoverId { get; set; }
        public int QuotationId { get; set; }
        public Quotation Quotation { get; set; }
        public string CoverStatus { get; set; }
        public string CoverName { get; set; }
        public decimal Price { get; set; }
        public string Comment { get; set; } = string.Empty;
        public Guid  EntityId { get; set; }
        public bool Indicator { get; set; } = false;
        public ProductBaseSubjectTypeCover ProductBaseSubjectTypeCover  { get; set; }

    }

}
