using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BusinessBrokeredDetail : BaseEntity
    {


        [ForeignKey(nameof(BookingBusinessInformation))]
        public int BusinessInfoId { get; set; }
        public BookingBusinessInformation BookingBusinessInformation { get; set; }
        public int BrokerId { get; set; }
       
    }


}
