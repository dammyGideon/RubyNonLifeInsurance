using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.Lookups
{
    public partial class LocalGovernmentAreaLookup : BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey(nameof(State))]
        public int StateId { get; set; }
        public State State { get; set; }

    }
}
