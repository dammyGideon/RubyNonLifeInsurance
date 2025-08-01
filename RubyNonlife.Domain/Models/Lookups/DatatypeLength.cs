using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RubyNonlife.Domain.Models.Lookups;

public partial class DatatypeLength :BaseEntity
{
    public string Name { get; set; }
    public int Length { get; set; }

}
