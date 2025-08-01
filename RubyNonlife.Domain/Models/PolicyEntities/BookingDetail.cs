using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BookingDetail : BaseEntity
    {
        [ForeignKey(nameof(PolicyBooking))]
        public int BookingId { get; set;}
        public PolicyBooking PolicyBooking { get; set; }
        public string PaymentType { get; set; }
        public DateTime PolicyActiveStateDate { get; set; }
        public DateTime PolicyActiveEndDate {  get; set; }
        public string Duration {get; set; }
        public string PaymentCycle { get; set; }
        public bool InitiatedWithCreditNote { get; set; } = false;
        public ICollection<PaymentTypeBookingDetail> PaymentTypeBookings { get; set; }
        public ICollection<CreditNotePayment> CreditNotePayments { get; set; }
    } 
}

