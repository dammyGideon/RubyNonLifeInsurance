using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BookingSbu : BaseEntity
    {
        [ForeignKey(nameof(PolicyBooking))]
        public int BookingId { get; set; }
        public PolicyBooking PolicyBooking { get; set; }
        public decimal ProportionPercentage { get; set; }
        public int ExternalId { get; set; }
        public string Comments { get; set; }
        public string Location { get; set; }

        public string Name { get; set; }
        public ICollection<BookingSbuAgent> BookingSbuAgents { get; set; }
    }


}



