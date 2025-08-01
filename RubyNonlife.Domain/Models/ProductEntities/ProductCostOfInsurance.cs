using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RubyNonlife.Domain.Models.Lookups;

namespace RubyNonlife.Domain.Models.ProductEntities;

public partial class ProductCostOfInsurance : BaseEntity
{
    public string? DebitAccount { get; set; }
    public string ExpenseAccountName { get; set; } = string.Empty;
    public string PayableAccountName { get; set; } = string.Empty;
    public string? CreditAccount { get; set; }

    public decimal? TermValue { get; set; }

    public string Rate { get; set; }

    public int Year { get; set; }

    public string CostBearer { get; set; }

    public string? Remark { get; set; }

    public string DisplayFormula { get; set; }

    public bool IsDeleted { get; set; }
    public int CollectionSourceId { get; set; }
    public int CostTypeId { get; set; }
 
    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; } 
}
