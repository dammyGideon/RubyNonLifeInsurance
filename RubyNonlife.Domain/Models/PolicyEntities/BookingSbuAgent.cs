using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BookingSbuAgent : BaseEntity
    {
        [ForeignKey(nameof(BookingSbu))]
        public int BookingSbuId { get; set; }
        public BookingSbu BookingSbu { get; set; }
        public string Name { get; set; }
       
        public decimal ProportionPercentage { get; set; }
        public Guid ExternalId { get; set; }
        public ICollection<BookingSubSbuAgent> BookingSubSbuAgent { get; set; } 
    }


}



