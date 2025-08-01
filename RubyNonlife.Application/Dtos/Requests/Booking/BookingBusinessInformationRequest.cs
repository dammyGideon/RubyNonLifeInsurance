using Microsoft.AspNetCore.Http;


namespace RubyNonlife.Application.Dtos.Requests.Booking
{
    public record BookingBusinessInformationRequest
    {
        public int BookingId { get; set; }
        public string BusinessType { get; set; }
        public List<BusinessTypeRequest?> BusinessTypeRequest { get; set; }
        public string BusinessSource { get; set; }
        public int BrokeredId {get; set; }
        public int Insurer { get; set; }
        public string AdditionalInformation { get; set; }
    }

    public record BusinessTypeRequest
    {
        public int InsurerId { get; set; }
        public decimal Portion { get; set; }
        public bool IsLead { get; set; }
    }


    public record BookingDetailsRequest
    {
        public int PolicyId { get; set; }
        public int PaymentType { get; set; }
        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
        public string Duration { get; set; }
        public string PaymentCycle { get; set; }
        public List<EligibilityRequest> Eligibility { get; set; }
    }

    public class BookingDetailsFormData
    {
        public string RequestJson { get; set; }
        public IFormFile? UploadCreditNote { get; set; }
    }

    public record EligibilityRequest
    {
    public string ReceiptReference { get; set; }
    public DateTime PolicyStartDate { get; set; }
    public DateTime PolicyEndDate { get; set; }
    public int Duration { get; set; }
    public decimal Amount { get; set; } = decimal.Zero;


}


    // BookingDetailsRequest Model



    //public record BookingDetailsRequest
    //{
    //    public int PolicyId { get; set; }
    //    public int PaymentType { get; set; }
    //    public DateTime PolicyStartDate { get; set; }
    //    public DateTime PolicyEndDate { get; set; }
    //    public string Duration { get; set; }
    //    public string PaymentCycle { get; set; }
    //    public string? UploadedCreditNoteFileName { get; set; } // Only for Credit Note
    //    public List<EligibilityRequest> Eligibility { get; set; }
    //}

    //// EligibilityRequest Model
    //public record EligibilityRequest
    //{
    //    public string ReceiptReference { get; set; }
    //    public DateTime PolicyStartDate { get; set; }
    //    public DateTime PolicyEndDate { get; set; }
    //    public int Duration { get; set; }
    //    public decimal Amount { get; set; } = decimal.Zero;
    //}

}




