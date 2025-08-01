using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class PolicyNumberCounter : BaseEntity
    {
        public string ProductAbbreviation { get; set; }
        public string Year { get; set; } // e.g., "25"
        public int LastNumber { get; set; }
    }
}
