using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.QuoteEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class PolicyBooking : BaseEntity
    {
        [ForeignKey(nameof(Quotation))]
        public int QuotationId { get; set; }
        public Quotation Quotation { get; set; }
        public string PolicyId { get; set; }
        public string PolicyKey { get; set; } = string.Empty;
        public string Customer {  get; set; }
        public string CustomerName { get; set; }
        public int ProductId { get; set; }
        public decimal? SumInsured { get; set; } = 0;
        public DateTime? BookingDate { get; set; }
        public TimeOnly? TimeInQue { get; set; } 
        public DateTime? SlaPerformance {  get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public int? CoverPeriod { get; set; }
        public string CreatedBy { get; set; }
        public string State { get; set; } = string.Empty;
        public string LGA { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string SaveState { get; set; }
        public string DocumentationComment { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        
        public ICollection<BookingSubjectAttribute> BookingSubjectAttributes {  get; set; }

        public ICollection<BookingBusinessInformation> BookingBusinessInformation { get; set; }
        public ICollection<BookingDetail> BookingDetails { get; set; }
        public ICollection<EligibilityPeriod> EligibilityPeriods { get; set; } 
        public ICollection<BookingSbu> BookingSbus { get; set; }
        public ICollection<PolicyBookingGenericLocation> PolicyBookingGenericLocation { get; set; }
        public ICollection<BookingOperationalTransactionsMaster> BookingOperationalTransactionsMaster {  get; set; }
        public BookingUploadedDocument BookingUploadedDocument { get; set; }
    }
}
