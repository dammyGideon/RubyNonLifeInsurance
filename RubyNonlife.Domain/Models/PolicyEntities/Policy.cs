using System;
using System.Collections.Generic;
using RubyNonlife.Domain.Models.ProductEntities;
using RubyNonlife.Domain.Models.QuoteEntitties;

namespace RubyNonlife.Domain.Models.PolicyEntitites;

public partial class Policy
{
    public long Id { get; set; }

    public long? QuotationId { get; set; }

    public long? PolicyNumber { get; set; }

    public int? OfficeId { get; set; }

    public long? UserId { get; set; }

    public string? CustomerName { get; set; }

    public long? AgentId { get; set; }

    public decimal Premium { get; set; }

    public decimal SumInsured { get; set; }

    public string Status { get; set; } = null!;

    public int ProductId { get; set; }

    public int CustomerId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? PolicyStartDate { get; set; }

    public DateTime? PolicyEndDate { get; set; }

    public string? Narration { get; set; }

    public string? Currency { get; set; }

    public int? ProgressPercentage { get; set; }

    public bool IsActive { get; set; }

    public string? EndorsementRequestJson { get; set; }

    public bool ActiveEndorsement { get; set; }

    public int? BusinessTypeId { get; set; }

    public bool IsPremiumPorated { get; set; }

    public decimal FullPremium { get; set; }

    public int? PoratedTenure { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Mplrate { get; set; }

    public bool IsPolicyHollard { get; set; }

    public long? RmId { get; set; }



    public virtual ICollection<PolicyDocument> NonLifePolicyDocuments { get; set; } = new List<PolicyDocument>();

    public virtual ICollection<PolicyPremiumCostOfInsurance> NonLifePolicyPremiumCostOfInsurances { get; set; } = new List<PolicyPremiumCostOfInsurance>();

    public virtual ICollection<QuotationExtraCover> NonLifeQuotationExtraCovers { get; set; } = new List<QuotationExtraCover>();

    public virtual ICollection<QuotationSubject> NonLifeQuotationSubjects { get; set; } = new List<QuotationSubject>();

    public virtual Product Product { get; set; }
}
