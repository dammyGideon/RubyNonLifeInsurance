using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class NatureOfBusinessLookup : BaseEntity
    {
        public NatureOfBusinessLookup()
        {
            Customers = new HashSet<Customer>();
        }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
