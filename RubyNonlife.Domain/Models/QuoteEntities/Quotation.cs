using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Domain.Models.CustomerEntities;
using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;

namespace RubyNonlife.Domain.Models.QuoteEntities
{
    public partial class Quotation: BaseEntity
    {
        public string QuoteId { get; set; }
        [ForeignKey(nameof(BusinessType))]
        public int BusinessTypeId { get; set; }
        [ForeignKey(nameof(QuoteType))]
        public int QuoteTypeId { get; set; }

        [ForeignKey(nameof(PolicyDuration))]
        public int PolicyDurationId { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        [ForeignKey(nameof(QuotePreferences))]

        public string ProductClass { get; set; }
        public int QuotePreferencesId { get; set; }
        public string RiskLocation { get; set; }
        public string StateOfOperation { get; set; }
        public string Channel { get; set; }
        public double SLA { get; set; }
        public decimal SLAUsage { get; set; }
        public DateTime CreateAt { get; set; }
        public string? CreateBy { get; set; }
        public string? Customer { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerAddress { get; set; }
        public bool IsLocked { get; set; } = false;
        public string? LockedBy { get; set; }
        public int? ProgressPercentage { get; set; }
        public decimal? SumInsured { get; set; }
        public decimal? Premium { get; set; }
        public decimal? Rate { get; set; }
        public int? AgentId { get; set; }
        public string? Currency { get; set; }
        public decimal? LostRatio { get; set; }
        public bool RequiresUnderwritingApproval { get; set; }
        public string QuoteStatus { get; set; }
        public DateTime? AcceptedAt { get; set; }
        public DateTime? RejectedAt { get; set; }
        public string? RejectionReason { get; set; }
        public int? PreviousQuoteId { get; set; } // Reference to the predecessor quote
        public int VersionNumber { get; set; } 
        public decimal? Discount {  get; set; } 
        public string? FleetNumber { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual BusinessType BusinessType { get; set; }
        public virtual QuoteType QuoteType { get; set; }
        public virtual PolicyDuration PolicyDuration { get; set; }
        public virtual Product Product { get; set; }
        public virtual QuotePreferences QuotePreferences { get; set; }



        public virtual ICollection<QuotationAttributeValue> QuotationAttributeValues { get; set; }
        public virtual ICollection<QuoteNegotiation> QuoteNegotiation { get; set; }
        public virtual ICollection<QuotationAdditionalCover> QuotationAdditionalCovers { get; set; }
        public virtual ICollection<QuotationBaseCover> QuotationBaseCovers { get; set; }
        public virtual ICollection<QuotationPriceCalculationAudit> QuotationPriceCalculationAudits { get; set; }
    }

}
