using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RubyNonlife.Domain.Models.QuoteEntitties;

namespace RubyNonlife.Domain.Models
{
    public partial class PolicyDuration
    {
        public int Id { get; set; }
        public int DurationMonths { get; set; }
        public string DurationLabel { get; set; }
      

        public virtual ICollection<Quotation> Quotation { get; set; }
    }
}
