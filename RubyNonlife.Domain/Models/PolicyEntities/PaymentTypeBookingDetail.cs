using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class PaymentTypeBookingDetail : BaseEntity
    {
        [ForeignKey(nameof(BookingDetail))]
        public int BookingDetailId { get; set; }
        public BookingDetail BookingDetail { get; set; }
        public string VoucherType { get; set; }

    }



}
