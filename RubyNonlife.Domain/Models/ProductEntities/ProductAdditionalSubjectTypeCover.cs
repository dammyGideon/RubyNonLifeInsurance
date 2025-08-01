using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RubyNonlife.Domain.Models.QuoteEntities;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductAdditionalSubjectTypeCover : BaseEntity
    {
        public string LimitType { get; set; }
        public string CoverStatus { get; set; }
        public bool RateTable { get; set; }
        public decimal RateApplied { get; set; } = decimal.Zero;
        public decimal MaximumAmount { get; set; } = decimal.Zero;
        public bool isFixed { get; set; }
        public decimal? FixedPremium { get; init; }
        public int AdditionalCoverId { get; set; }
        public string DisplayFormula { get; set; } = string.Empty;

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<QuotationAdditionalCover> QuotationAdditionalCover { get; set; }
      
    }
}
