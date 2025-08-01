using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.QuoteEntities
{
    public class QuotationPriceCalculationAudit : BaseEntity
    {

        [ForeignKey(nameof(Quotation))]
        public int QuoteId { get; set; }
        public Quotation Quotation { get; set; }
        public int AttributeId { get; set; }
        public int CoverId { get; set; }
        public decimal AppliedRate { get; set; }
        public decimal AdjustedPremium { get; set; }
        public string Affects { get; set; }  // "Sum Assured", "Final Quote", etc.
        public DateTime Timestamp { get; set; }
        public string Comment { get; set; }  // 
    }
}
