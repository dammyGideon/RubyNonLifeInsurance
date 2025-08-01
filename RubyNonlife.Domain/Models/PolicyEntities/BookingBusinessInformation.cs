using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BookingBusinessInformation :BaseEntity
    {
        [ForeignKey(nameof(PolicyBooking))]
        public int BookingId { get; set; }
        public PolicyBooking PolicyBooking { get; set; }

        public string BusinessType { get; set; } 
        public string BusinessSource { get; set; } 
        public string AdditionalInformation {  get; set; }


        public List<CoInsuranceDetail> CoInsuranceDetails { get; set; }
        public FacultativeInsurer FacultativeInsurer { get; set; }
        public BusinessBrokeredDetail BusinessBrokeredDetail { get; set; }

    }

}
