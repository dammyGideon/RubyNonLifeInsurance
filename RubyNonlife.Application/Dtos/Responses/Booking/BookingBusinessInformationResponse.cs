
namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public class BookingBusinessInformationResponse
    {
        //public int Id { get; set; }
        public int BookingId { get; set; }
        public string AdditionalInformation { get; set; }
        public string BusinessSource { get; set; }
        public string BusinessType { get; set; }
        public BrokeredDetailResponse BrokeredDetails { get; set; }
        public List<CoInsuranceDetailResponse> CoInsuranceDetails { get; set; }
        public int? FacultativeInsurers { get; set; }
    }

    public class BrokeredDetailResponse
    {
        public int BrokerId { get; set; }
    }

    public class CoInsuranceDetailResponse
    {
        public int InsurerId { get; set; }
        public decimal Portion { get; set; }
        public bool IsLead { get; set; }
    }

    public class FacultativeInsurerResponse
    {
        public int? InsurerId { get; set; }
    }


    public class BookingDetailResponse
    {
        public int? Id { get; set; }
        public string PaymentType { get; set; }
        public DateTime? PolicyActiveStateDate { get; set; }
        public DateTime? PolicyActiveEndDate { get; set; }
        public string Duration { get; set; }
        public string PaymentCycle { get; set; }
        public PaymentVoucherResponse PaymentVoucherResponse {  get; set; }
        public CreditNoteResponse CreditNoteResponse { get; set; }
        public List<EligibilityResponse> EligibilityResponses {  get; set; }
    }

   
    public class PaymentVoucherResponse 
    {
        public string VoucherType { get; set; }
    }

    public class CreditNoteResponse
    {
        public string Document { get; set; }
    }

}
