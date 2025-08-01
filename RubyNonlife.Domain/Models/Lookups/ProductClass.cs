using RubyNonlife.Domain.Models.ProductEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RubyNonlife.Domain.Models.Lookups;

public partial class ProductClass : BaseEntity
{
    public string Name { get; set; }

    public string ImageName { get; set; }

    public bool IsDeleted { get; set; }
    public DateTime? DateUpdated { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
   
}
