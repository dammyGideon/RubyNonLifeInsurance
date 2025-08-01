using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RubyNonlife.Application.Dtos.Requests.Booking;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.Booking;


namespace RubyNonlife.Infrastructure.Contract
{
    public interface IPolicyBookingService
    {
        Task<BaseResponse<List<GenericNameResponse>>> GetPolicyBusinessSource();
        Task<BaseResponse<List<GenericNameResponse>>> GetPolicyBusinessType();
        Task<BaseResponse<List<GenericNameResponse>>> GetBrokers();
        Task<BaseResponse<List<GenericNameResponse>>> GetOfficeLocation();
        Task<BaseResponse<List<GenericNameResponse>>> GetBeneficiary();
        Task<BaseResponse<List<GenericNameResponse>>> GetPolicyPaymentType();

        Task<BaseResponse<List<GenericNameResponse>>> PolicyBookingInsurers();
        Task<BaseResponse<List<GenericNameResponse>>> PolicyAdditionalInformation();
        Task<BaseResponse<BookingQuoteResponse>> GetQuotationForBook(int QuoteId);
        Task<BaseResponse<List<GenericNameResponse>>> GetAllLocalGovernment(int stateId);
        Task<BaseResponse<PaginatedCustomerResponse>> GetCustomerDetails(string customer, int pageNumber = 1, int pageSize = 10);
        Task<BaseResponse<PolicyCodeBookingResponses>> BookingCustomerInformation(CustomerInformationRequest request);
        Task<BaseResponse<PaginatedBookingResponse>> GetAllBooking(FilterBookingRequestDto request);
        Task<BaseResponse<SinglePolicyBookingResponse>> GetSingleBooking(int? bookingId, int? quoteId);
        Task<BaseResponse<PolicyCodeBookingResponses>> BookingBusinessInformation(BookingBusinessInformationRequest request);
        Task<BaseResponse<List<PaymentCycleResponse>>> GetPaymentCycles(int productId);
        Task<BaseResponse<PolicyCodeBookingResponses>> BookingDetails(BookingDetailsFormData formData);
        Task<BaseResponse<List<PolicyBookingDocumentResponse>>> PolicyDocumentLookups(int policyId);
        Task<BaseResponse<List<VoucherDataResponse>>> GetCustomerVoucher(string customerNumber);
        Task<BaseResponse<List<EligibilityResponse>>> CalculateEligibility(EligibilityRequests request);
        Task<BaseResponse<List<GenericNameResponse>>> GetAllSbu();
        Task<BaseResponse<List<SubAgentResponses>>> GetSbuAgent(int structuralBusinessUnitId);
        Task<BaseResponse<List<AgentResponse>>> GetAgentOfSbuAgent(Guid subAgentId);
        
        Task<BaseResponse<CustomerIdResponse>> CompleteSBUDetails(SbuSharingRequest request);
        Task<BaseResponse<List<CustomerDocs>>> CustomerDocumentLookUps(int customerId);
        Task<BaseResponse<CustomerDocsDownload>> DownloadCustomerDocument(int customerDocumentId, int customerId);
        Task<BaseResponse<GenericNameResponse>> Documentation(DocumentationRequest request);
        Task<BaseResponse<GenericNameResponse>> UploadDocument(DocumentUploadsRequest request);
        Task<BaseResponse<List<GetBookingAttributeResponse>>> GetBookingAttribute(int productId);
        Task<BaseResponse<PolicyPostingResponse>> PolicyPosting(int policyId);
        Task<BaseResponse<string>> DownloadSchedule(int productId);

        Task<BaseResponse<Dictionary<string, List<Dictionary<string, object>>>>> ExtractExcelDataFromStream(IFormFile file, int quoteId);
        Task<BaseResponse<FinancialSimulationResponse>> GetFinancialSimulationByPolicy(int policyId);

        Task<BaseResponse<bool>> CreateFinancialSimulation(int policyId);
        // Task<byte[]> GenerateCertificateAsync(int policyId);
        Task<byte[]> GenerateCertificateAsync(int policyId);
        Task<BookingCostOfInsuranceFeeResponse> CalculateCostOfInsuranceFee(decimal premium, int productId, int policyId);
        Task<BaseResponse<GenericNameResponse>> ApprovePolicy(int policyId);
        Task<IncomeRecognitionResponse> IncomeRecognition(int policyId, decimal premium);

        Task<BaseResponse<GenericNameResponse>> GetNewCustomer(string customer);
        Task<string> GenerateCertificatePdfBase64Async(int policyId);
        Task<BaseResponse<object>> SendToFinanceSystemAsync(int policyId);

        Task<string> GenerateFilledCertificateDocxAsync(int policyId);
        Task<string> GenerateCertificatesForFleetAsync(int policyId);
        Task<BaseResponse<object>> FinancialSimulationLoad(int policyId);

    }
}

