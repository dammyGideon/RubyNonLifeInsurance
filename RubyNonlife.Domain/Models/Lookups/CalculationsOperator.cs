using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RubyNonlife.Domain.Models.Lookups;

public partial class CalculationsOperator :BaseEntity
{
    public string Operators { get; set; }
    public string Sign { get; set; }

}
