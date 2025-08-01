using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.QuoteEntities
{
    public class QuotationAdditionalCover : BaseEntity
    {
      
        [ForeignKey(nameof(ProductAdditionalSubjectTypeCover))]
        public int ProductAdditionalSubjectTypeCoverId { get; set; }

        public int QuotationId { get; set; }
        public Quotation Quotation { get; set; }
        public string CoverStatus { get; set;}
        public string CoverName { get; set; }
        public decimal Price { get; set;}
        public string Comment { get; set; } = string.Empty;
        public Guid EntityId { get; set; }
        public bool Indicator { get; set; } = false;
        public ProductAdditionalSubjectTypeCover ProductAdditionalSubjectTypeCover { get; set; }
    }
}
