using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RubyNonlife.Application.Dtos.Requests.Booking;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.Booking;
using RubyNonlife.Infrastructure.Contract;
using System.Collections.Generic;
using System.Net;

namespace RubyNonlife.Api.Controllers
{

    public class PolicyBookingController(IPolicyBookingService _bookingService) : BaseController
    {
        

        [HttpGet("beneficiary")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetBeneficiary()
        {
            var response = await _bookingService.GetBeneficiary();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("brokers")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetBrokers()
        {
            var response = await _bookingService.GetBrokers();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("policy-businessType")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPolicyBusinessType()
        {
            var response = await _bookingService.GetPolicyBusinessType();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("policy-businessSource")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPolicyBusinessSource()
        {
            var response = await _bookingService.GetPolicyBusinessSource();
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("payment-type")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPayment()
        {
            var response = await _bookingService.GetPolicyPaymentType();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("policy-additional-information")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPolicyAdditionalInformation()
        {
            var response = await _bookingService.PolicyAdditionalInformation();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("policy-booking-insurers")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPolicyBookingInsurers()
        {
            var response = await _bookingService.PolicyBookingInsurers();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-quote")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<BookingQuoteResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetQuotationForBook(int QuoteId)
        {
            var response = await _bookingService.GetQuotationForBook(QuoteId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-local-government-area")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllLocalGovernment(int StateId)
        {
            var response = await _bookingService.GetAllLocalGovernment(StateId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-customer-details")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<CustomerBookingResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetCustomerDetails(string customer, int pageNumber = 1, int pageSize = 10)
        {
            var response = await _bookingService.GetCustomerDetails(customer,pageNumber,pageSize);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("booking-customer-information")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<CustomerBookingResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> BookingCustomerInformation(CustomerInformationRequest request)
        {
            var response = await _bookingService.BookingCustomerInformation(request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-booking")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<PaginatedBookingResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllBooking([FromQuery]FilterBookingRequestDto request)
        {
            var response = await _bookingService.GetAllBooking(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-booking-by-Id")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<PaginatedBookingResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
       // [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetSingleBooking([FromQuery] int? bookingId, [FromQuery] int? quoteId)
        {
            var response = await _bookingService.GetSingleBooking(bookingId, quoteId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("create-business-information")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<PolicyCodeBookingResponses>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> BookingBusinessInformation(BookingBusinessInformationRequest request)
        {
            var response = await _bookingService.BookingBusinessInformation(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-payment-cycles")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<PaginatedBookingResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPaymentCycles(int productId)
        {
            var response = await _bookingService.GetPaymentCycles(productId);
            return StatusCode((int)response.StatusCode, response);
        }


      

        [HttpPost("booking-details")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<PolicyCodeBookingResponses>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> BookingDetails([FromForm] BookingDetailsFormData formData)
        {
            var response = await _bookingService.BookingDetails(formData);
            return StatusCode((int)response.StatusCode, response);
        }



        [HttpGet("policy-document-lookups")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> PolicyDocumentLookups(int policyId)
        {
            var response = await _bookingService.PolicyDocumentLookups(policyId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-customer-vouchers")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetCustomerVoucher(string customerNumber)
        {
            var response = await _bookingService.GetCustomerVoucher(customerNumber);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("get-policy-Eligibility")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CalculateEligibility(EligibilityRequests request)
        {
            var response = await _bookingService.CalculateEligibility(request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-all-sbu")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllSbu()
        {
            var response = await _bookingService.GetAllSbu();
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-sbu")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetSbuAgent([FromQuery] int sbuId)
        {
            var response = await _bookingService.GetSbuAgent(sbuId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-agent-of-sbu-agent")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAgentOfSbuAgent([FromQuery] Guid agentId)
        {
            var response = await _bookingService.GetAgentOfSbuAgent(agentId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("complete-sbu-details")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CompleteSBUDetails(SbuSharingRequest request)
        {
            var response = await _bookingService.CompleteSBUDetails(request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("customer-document")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<CustomerDocs>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CustomerDocumentLookUps(int customerId)
        {
            var response = await _bookingService.CustomerDocumentLookUps(customerId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("download-customer-document")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<CustomerDocs>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> DownloadCustomerDocument(int customerDocumentId, int customerId)
        {
            var response = await _bookingService.DownloadCustomerDocument(customerDocumentId, customerId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("setup-documentation")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<CustomerDocs>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Documentation([FromForm] DocumentationRequest request)
        {
            var response = await _bookingService.Documentation(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("upload-policy-document")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<CustomerDocs>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> UploadDocument([FromForm] DocumentUploadsRequest request)
        {
            var response = await _bookingService.UploadDocument(request);
            return StatusCode((int)response.StatusCode, response);
        }
        

        [HttpGet("get-booking-attribute")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetBookingAttribute(int productId)
        {
            var response = await _bookingService.GetBookingAttribute(productId);
            return StatusCode((int)response.StatusCode, response);
        }


        [AllowAnonymous]
        [HttpGet("policy-posting/{policyId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> PolicyPosting(int policyId)
        {
            var response = await _bookingService.PolicyPosting(policyId);
            return StatusCode((int)response.StatusCode, response);
        }



        [HttpGet("download-schedule/{quoteId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> DownloadSchedule(int quoteId)
        {
            var response = await _bookingService.DownloadSchedule(quoteId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("upload-schedule/{quoteId}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> ProcessQuotationFile(IFormFile file, int quoteId)
        {
            var response = await _bookingService.ExtractExcelDataFromStream(file,quoteId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("financial-simulation-lookups/{policyId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> FinancialSimulationLookups(int policyId)
        {
            var response = await _bookingService.GetFinancialSimulationByPolicy(policyId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("create-financial-simulation")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateFinancialSimulation(int policyId)
        {
            var response = await _bookingService.CreateFinancialSimulation(policyId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("generate-certificate-async/{policyId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GenerateCertificateAsync(int policyId)
        {
         

            return Ok(await _bookingService.GenerateCertificateAsync(policyId));
        }

        [HttpGet("get-office-location")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetOfficeLocation()
        {

            var response =await _bookingService.GetOfficeLocation();
            return Ok(response);
        }


        [HttpGet("get-new-customer")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetNewCustomer(string customer)
        {

            var response = await _bookingService.GetNewCustomer(customer);
            return Ok(response);
        }

        [HttpGet("get-new")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> TeaCustomer(int p)
        {

            var response = await _bookingService.GenerateCertificatePdfBase64Async(p);
            return Ok(response);
        }


        [HttpPost("Send-finance-systemAsync")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> SendToFinanceSystemAsync(int policyId)
        {

            var response = await _bookingService.SendToFinanceSystemAsync(policyId);
            return Ok(response);
        }


        [HttpGet("generate-certificate-base64")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GenerateFilledCertificatePdfBase64Async(int policyId)
        {
            var base64 = await _bookingService.GenerateFilledCertificateDocxAsync(policyId);
            return Ok(base64);
        }



        // Endpoint to generate certificates for fleet
        [HttpGet("generate-certificates/{policyId}")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GenerateCertificatesForFleetAsync(int policyId)
        {
            try
            {
                string base64 = await _bookingService.GenerateCertificatesForFleetAsync(policyId);

                // Return the base64 string as a downloadable ZIP or PDF
                var bytes = Convert.FromBase64String(base64);
                var fileName = $"Certificates_{Guid.NewGuid()}.zip"; // Change the name if needed

                // Return as a file download
                return File(bytes, "application/zip", fileName);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }




        [HttpGet("get-Financial")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> FinancialSimulationLoad(int policyId)
        {

            var response = await _bookingService.FinancialSimulationLoad(policyId);
            return Ok(response);
        }


    }
}

