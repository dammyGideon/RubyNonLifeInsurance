using RubyNonlife.Domain.Models.PolicyEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.Lookups
{
    public class PolicyBookingInsurer : BaseEntity
    {
        public string Name { get; set; }
      
       
        //public ICollection<FacultativeInsurer> FacultativeInsurers { get; set; }
    }
}
