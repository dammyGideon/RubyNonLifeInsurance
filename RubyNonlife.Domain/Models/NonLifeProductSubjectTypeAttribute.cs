using System;
using System.Collections.Generic;
using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;

namespace RubyNonlife.Domain.Models;

public partial class NonLifeProductSubjectTypeAttribute
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public int ProductSubjectTypeId { get; set; }

    public int? SubjectValueId { get; set; }

    public string FieldType { get; set; } = null!;

    public bool IsRequired { get; set; }

    public string SubFieldType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime? DateDeleted { get; set; }

    public int? Length { get; set; }

    public bool IsSumInsured { get; set; }

    public bool IsRequiredForQuoteGeneration { get; set; }
    public virtual ProductSubjectType ProductSubjectType { get; set; } = null!;

    //public virtual SubjectValue? SubjectValue { get; set; }
}
