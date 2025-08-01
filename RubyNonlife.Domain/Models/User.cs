using System;
using System.Collections.Generic;

namespace RubyNonlife.Domain.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateTime DateCreated { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsAgent { get; set; }

    public long? AgentId { get; set; }

    public bool? TwoFaenabled { get; set; }

    public int TeamId { get; set; }

    public virtual RelationshipManager? Agent { get; set; }
}
