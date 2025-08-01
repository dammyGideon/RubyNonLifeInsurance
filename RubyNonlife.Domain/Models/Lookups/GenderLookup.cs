using RubyNonlife.Domain.Models.CustomerEntities;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.Lookups
{
    public partial class GenderLookup : BaseEntity
    {
        public GenderLookup()
        {
            Customers = new HashSet<Customer>();
        }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
