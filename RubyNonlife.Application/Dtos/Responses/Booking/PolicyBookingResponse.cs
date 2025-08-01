using RubyNonlife.Application.Dtos.Requests.Booking;
using RubyNonlife.Application.Dtos.Responses.Quotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Booking
{


    public record PaginatedBookingResponse
    {
        public int PageNumber { get; init; }
        public int PageSize { get; init; }
        public int TotalCount { get; init; }
        public int TotalPages { get; init; }
        public bool HasPreviousPage { get; init; }
        public bool HasNextPage { get; init; }

        public List<PolicyBookingResponse> PolicyBookingResponse { get; init; }

    }
    public record PolicyBookingResponse
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public int Id { get; set; }
        public string BookingCode { get; set; }
        public string PolicyKey { get; set; }
        public string BookedBy { get; set; }
        public DateTime? BookingDate { get; set; }
        public int QuoteId { get; set; }
        public string QuotationId { get; set; } 

        public TimeOnly? TimeInQue { get; set; }
        public DateTime? SlA { get; set;}
        public DateTime DateCreated { get; set; }

        public string Status {  get; set; }
        public string QuoteType { get; set; }

    }

    public record SinglePolicyBookingResponse
    {
        public int BookingId { get; set; }
        public int QuotationId { get; set; } 
        public int ProductId { get; set; }
        public string Subject { get; set; }
        public CustomerBookingResponse CustomerBooking { get; set; }
        public string PolicyId { get; set; }
        public decimal? SumInsured { get; set; }
        public decimal IsActive { get; set; }

        public string CreatedBy { get; set; }
        public string SaveState { get; set; }
        public decimal? Premium {  get; set; }
        public List<BookingAttributeResponse> BookingAttributeResponse { get; set; }
        public BookingQuoteDetail BookingQuoteDetail { get; set; }
        public BookingBusinessInformationResponse BookingBusinessInformationResponse { get; set; }
        public BookingDetailResponse BookingDetailResponse { get; set; }
        public SbuDetailResponse SbuDetailResponse { get; set; }
        public string DocumentationComment { get; set; }
        public List<GenericLocationAttributeResponse> GenericLocationAttributeResponse { get; set; }
    }

    public record BookingQuoteDetail
    {
        public string QuoteId { get; init; }
        public string QuoteType { get; set; }
        public string Customer { get; set; }
       
        public string Product { get; set; }
        public string FinalQuoteReviewedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public TimeOnly? Time {  get; set; }
    }

    public class PolicyGenericLocationResponse
    {
        public string FieldName { get; init; }
        public string FieldValue { get; init; }
        public int GenericLocationId { get; init; }
        public Guid? EntityId {  get; init; }
    }


}
