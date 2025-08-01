using System;
using System.Collections.Generic;

namespace RubyNonlife.Domain.Models;

public partial class ProductSetupStage
{
    public long Id { get; set; }

    public int ProductId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    //public virtual Prod Product { get; set; } = null!;

   
}
