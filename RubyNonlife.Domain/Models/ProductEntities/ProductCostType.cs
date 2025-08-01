using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RubyNonlife.Domain.Models.Lookups;

namespace RubyNonlife.Domain.Models.ProductEntities;

public partial class ProductCostType : BaseEntity
{
    public string? Remark { get; set; }
    public bool IsDeleted { get; set; }
    public int CostTypeId { get; set; }
    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
}
