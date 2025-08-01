using RubyNonlife.Domain.Models.CustomerEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.Lookups
{
    public class State : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<LocalGovernmentAreaLookup> LocalGovernmentAreaLookups { get; set; }
    }
}
