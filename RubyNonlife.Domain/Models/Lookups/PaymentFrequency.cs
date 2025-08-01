using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.Lookups
{
    public class PaymentFrequency :BaseEntity
    {
        public string Name { get; set;}
        public DateTime DateTime { get; set; }
    }
}
