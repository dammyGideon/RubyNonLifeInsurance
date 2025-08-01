using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.QuoteEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductBaseSubjectTypeCover : BaseEntity
    {
       
        public string LimitType { get; set; }
        public string CoverStatus { get; set; }
        public bool RateTable {  get; set; }
        public decimal RateApplied { get; set; }=decimal.Zero;
        public decimal MaximumAmount {  get; set; } = decimal.Zero;
        public int BaseCoverId { get; set; }
        public bool isFixed { get; set; }
        public decimal? FixedPremium { get; set; }
        public string DisplayFormula { get; set; } = string.Empty;
      
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<QuotationBaseCover> QuotationBaseCover {  get; set; }
       
    }
}


