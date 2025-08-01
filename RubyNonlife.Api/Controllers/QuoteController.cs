using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RubyNonlife.Application.Dtos.Requests.Quotation;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.Quotation;
using RubyNonlife.Infrastructure.Contract;
using RubyNonlife.Infrastructure.Implementations;
using System.Net;
using System.Text;

namespace RubyNonlife.Api.Controllers
{
  
    public class QuoteController (IQuotationService _quoteService) : BaseController
    {


        [HttpGet("quote-Types")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> QuoteTypes()
        {
            var response = await _quoteService.GetQuoteType();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("business-types")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> BusinessTypes()
        {
            var response = await _quoteService.GetBusinessType();
            return StatusCode((int)response.StatusCode,response);
        }


        [HttpGet("get-durations")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPolicy()
        {
            var response = await _quoteService.GetPolicyDuration();
            return StatusCode((int)response.StatusCode,response);
        }

        [HttpGet("quote-preference")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetQuotePreference()
        {
            var response = await _quoteService.GetQuotePreference();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("quote-channel")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetChannels()
        {
            var response = await _quoteService.GetQuoteChannel();
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-states")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetState()
        {
            var response = await _quoteService.GetStates();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("products")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetProducts()
        {
            var response = await _quoteService.GetProduct();
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("product/{productId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetSingleProduct(int productId)
        {
            var response = await _quoteService.GetSingleProductAsync(productId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("create-quote")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult>GenerateQuotation(QuotationCreateRequest request)
        {
            var response = await _quoteService.CreateQuotation(request);
            return StatusCode((int)response.StatusCode, response);
        }
       

        [HttpPost("create-quotation-iteration")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateQuotationIteration(int quotationId, QuotationUpdateRequest request)
        {
            var response = await _quoteService.CreateQuotationIteration(quotationId,request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-quote/{quoteId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<QuotationDetailedResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetQuoteById(int quoteId)
        {
            var response = await _quoteService.GetSingleQuotation(quoteId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-quotes")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<PaginatedQuotationResponses>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllQuotation([FromQuery]QuotationFilterDto filterDto)
        {
            var response = await _quoteService.GetAllQuotation(filterDto);
            return StatusCode((int)response.StatusCode, response);
        }



        [HttpPost("download-subject-template/{productId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> DownloadSubjectTemplate(int productId, string quotationPreference)
        {
            var response = await _quoteService.DownloadFile(productId,quotationPreference);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("print-quote/{quoteId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> PrintQuote(int quoteId)
        {
            var response = await _quoteService.PrintQuote(quoteId);
            return StatusCode((int)response.StatusCode, response);
        }


        
        [HttpGet("quotation-search")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> QuotationSearch()
        {
            var response = await _quoteService.QuotationSearch();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPut("update-quotation")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<QuotationCodeResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
      
        public async Task<IActionResult> UpdateQuotation(int quotationId, QuotationUpdateRequest request)
        {
            var response = await _quoteService.UpdateQuotation(quotationId,request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("process")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> ProcessQuotationFile(IFormFile file,int productId)
        {
            var response = await _quoteService.ExtractExcelDataFromStream(file,productId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("create-Buck-quote")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<QuotationCodeResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GenerateBulkQuotation(BulkQuotationCreateRequest request)
        {
            var response = await _quoteService.CreateBulkQuotation(request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("validate-customer/{customer}")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<QuotationCodeResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CustomerValidation(string customer)
        {
            var response = await _quoteService.ValidateCustomer(customer);
            return StatusCode((int)response.StatusCode, response);
        }
       

        [HttpPost("quote-negotiation")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> QuoteNegotiation(QuoteNegotiationRequest request)
        {
            var response = await _quoteService.InitiateRMQuoteNegotiation(request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("Underwriter-reply")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> UnderwriterReply(UnderwriterReplyRequest request)
        {
            var response = await _quoteService.RespondToQuoteNegotiation(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("pending-negotiations")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPendingQuoteNegotiation()
        {
            var response = await _quoteService.GetPendingNegotiations();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-underwriting-quotations")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<PaginatedQuotationResponses>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetMyUnderWritingQuotations([FromQuery]QuotationFilterDto request)
        {
            var response = await _quoteService.GetMyUnderWritingQuotations(request);
            return StatusCode((int)response.StatusCode, response);
        }

      
        [HttpPost("submit-quote-for-review")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> SubmitQuoteForReview(int quoteId, string remarks)
        { 
            var response = await _quoteService.SubmitQuoteForReview(quoteId,remarks);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("underwriter-workbench")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<PaginatedQuotationResponses>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetSingleQuoteNegotiation([FromQuery] QuotationFilterDto filterDto)
        {
            var response = await _quoteService.GetAllUnderWritingQuotation(filterDto);
            return StatusCode((int)response.StatusCode, response);
        }


     

        [HttpGet("quotation-preview")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<ViewQuoteDetailedResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetQuotePreview(int quoteId)
        {
            var response = await _quoteService.GetQuotePreviewForPicking(quoteId);
            return StatusCode((int)response.StatusCode, response);
        }

      
        [HttpPost("assign-quote-from-workbench")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> AssignQuoteToPersonalWorkbench(int quoteId)
        {
            var response = await _quoteService.AssignQuoteToPersonalWorkbench(quoteId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("picked-quotes")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<PaginatedQuotationResponses>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPickedQuotesByUnderwriter([FromQuery]QuotationFilterDto request)
        {
            var response = await _quoteService.GetPickedQuotesByUnderwriter(request);
            return StatusCode((int)response.StatusCode, response);
        }

        
        [HttpPost("review-quotes")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> ReviewQuote(int originalQuoteId, QuotationReviewRequest request)
        {
            var response = await _quoteService.ReviewQuote(originalQuoteId,request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("accept-quote")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> AcceptQuote(int originalQuoteId)
        {
            var response = await _quoteService.AcceptQuote(originalQuoteId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("reject-quote")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> RejectQuote(int originalQuoteId, QuotationReviewRequest request)
        {
            var response = await _quoteService.RejectQuote(originalQuoteId, request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("validate-price-configure-update")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> ValidatePriceConfigureUpdate(int attributeId, decimal effectRate)
        {
            var response = await _quoteService.ValidatePriceConfigureUpdate(attributeId, effectRate);
            return StatusCode((int)response.StatusCode, response);
        }





    }
}



