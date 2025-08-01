using RubyNonlife.Domain.Models.QuoteEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.Lookups
{
    public class QuotePreferences : BaseEntity
    {
        public string Name { get; set; }
        public ICollection <Quotation> Quotation { get; set; }
    }
}
