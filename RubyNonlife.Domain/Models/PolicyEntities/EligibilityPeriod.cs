using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class EligibilityPeriod : BaseEntity
    {
        [ForeignKey(nameof(PolicyBooking))]
        public int BookingId { get; set; }
        public DateTime EligibilityStartDate { get; set; }
        public DateTime EligibilityEndDate { get; set; }
        public int DurationInMonths { get; set; }
        public string? ReceiptReference { get; set; }
        public bool IsExtended { get; set; } = false;
        public string Remarks { get; set; } = string.Empty;
        public decimal VoucherAmount { get; set; } = decimal.Zero;
        public PolicyBooking PolicyBooking { get; set; }

    }


    //public class BookingVoucher : BaseEntity {
    //    [ForeignKey(nameof(PolicyBooking))]
    //    public int BookingId { get; set; }

    //    public string VouchNumber { get; set; }

    //    public PolicyBooking PolicyBooking { get; set; }
    //}
}

