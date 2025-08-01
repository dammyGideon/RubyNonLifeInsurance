using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BookingSubSbuAgent : BaseEntity
    {
        [ForeignKey(nameof(BookingSbuAgent))]
        public int BookingSbuAgentId { get; set; }
        public BookingSbuAgent BookingSbuAgent { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ExternalId { get; set; }
        public decimal ProportionPercentage { get; set; }
    }


}



