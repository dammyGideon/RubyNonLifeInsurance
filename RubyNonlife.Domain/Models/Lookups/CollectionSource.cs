using RubyNonlife.Domain.Models.ProductEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RubyNonlife.Domain.Models.Lookups;

public partial class CollectionSource :BaseEntity
{
    public string Name { get; set; }

}
