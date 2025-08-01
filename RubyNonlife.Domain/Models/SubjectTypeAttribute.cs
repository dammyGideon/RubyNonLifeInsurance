using System;
using System.Collections.Generic;
using RubyNonlife.Domain.Models.Lookups;

namespace RubyNonlife.Domain.Models;

public partial class SubjectTypeAttribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public short? ProductClassId { get; set; }

    public bool? IsDeleted { get; set; }

    public DateOnly? DateDeleted { get; set; }

    //public virtual ProductClass? ProductClass { get; set; }
}
