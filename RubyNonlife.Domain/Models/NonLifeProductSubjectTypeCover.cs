using System;
using System.Collections.Generic;
using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;
using RubyNonlife.Domain.Models.QuoteEntitties;

namespace RubyNonlife.Domain.Models;

public partial class ProductSubjectTypeCover
{
    public int Id { get; set; }

    public int ProductSubjectTypeId { get; set; }

    public int CoverId { get; set; }

    public string CoverStatus { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime? DateDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public string? LimitType { get; set; }

    public string? FormulaDisplay { get; set; }

    //public virtual BaseCover Cover { get; set; } = null!;

    //public virtual ICollection<QuotationSubjectCover> QuotationSubjectCovers { get; set; } = new List<QuotationSubjectCover>();

    public virtual ProductSubjectType ProductSubjectType { get; set; } = null!;
}
