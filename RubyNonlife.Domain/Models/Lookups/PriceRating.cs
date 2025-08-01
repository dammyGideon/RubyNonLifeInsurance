using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RubyNonlife.Domain.Models.Lookups;

public partial class PriceRating : BaseEntity
{
    public string Name { get; set; }
}
