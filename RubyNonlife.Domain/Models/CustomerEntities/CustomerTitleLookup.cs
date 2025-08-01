using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomerTitleLookup : BaseEntity
    {
        public CustomerTitleLookup()
        {
            ContactPeople = new HashSet<ContactPerson>();
            Customers = new HashSet<Customer>();
        }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
