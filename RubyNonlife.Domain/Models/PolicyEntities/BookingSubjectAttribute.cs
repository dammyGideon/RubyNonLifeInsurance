using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BookingSubjectAttribute : BaseEntity
    {

        [ForeignKey(nameof(PolicyBooking))]
        public int BookingId { get; set; }
        public virtual PolicyBooking PolicyBooking { get; set; }

        [ForeignKey(nameof(ProductSubjectTypeAttribute))]
        public int AttributeId { get; set; }
        public virtual ProductSubjectTypeAttribute ProductSubjectTypeAttribute { get; set; } = null!;

        public string AttributeName { get; set; } = string.Empty;
        public string AttributeValue { get; set; } = string.Empty;
        public Guid EntityId { get; set; }

      


        

    }

}
