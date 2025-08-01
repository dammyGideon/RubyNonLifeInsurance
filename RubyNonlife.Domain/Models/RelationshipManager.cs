using System;
using System.Collections.Generic;

namespace RubyNonlife.Domain.Models;

public partial class RelationshipManager
{
    public long Id { get; set; }

    public string AgentNumber { get; set; } = null!;

    public int SbuId { get; set; }

    public int OfficeId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime DateCreated { get; set; }


    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
