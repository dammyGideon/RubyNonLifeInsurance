using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class CoInsuranceDetail : BaseEntity
    {

        [ForeignKey(nameof(BookingBusinessInformation))]
        public int BusinessInfoId { get; set; }
        public BookingBusinessInformation BookingBusinessInformation { get; set; }

        public int InsurerId { get; set; }
      
        public decimal Portion { get; set; }
        public bool IsLead { get; set; }



    }

}
