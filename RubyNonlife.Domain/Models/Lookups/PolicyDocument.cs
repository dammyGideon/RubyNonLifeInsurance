using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RubyNonlife.Domain.Models;

public partial class PolicyDocument :BaseEntity
{
    public string Name { get; set; }

    public bool IsDeleted { get; set; }

}
