using Microsoft.AspNetCore.Http;
using RubyNonlife.Application.Dtos.Requests.Quotation;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.Quotation;
using RubyNonlife.Domain.Models.QuoteEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Infrastructure.Contract;

public interface IQuotationService
{
    Task<BaseResponse<List<GenericNameResponse>>> GetQuoteType();
    Task<BaseResponse<List<GenericNameResponse>>> GetBusinessType();
    Task<BaseResponse<List<GenericNameResponse>>> GetQuotePreference();
    Task<BaseResponse<List<GenericNameResponse>>> GetPolicyDuration();
    Task<BaseResponse<List<GenericNameResponse>>> GetQuoteChannel();
    Task<BaseResponse<List<GenericNameResponse>>> GetProduct();
    Task<BaseResponse<List<GenericNameResponse>>> GetStates();
    Task<BaseResponse<GetSingleProductResponse>> GetSingleProductAsync(int productId);
    Task<BaseResponse<QuotationCodeResponse>> CreateQuotation(QuotationCreateRequest request);
    Task<BaseResponse<QuotationCodeResponse>> UpdateQuotation(int quotationId, QuotationUpdateRequest request);
    Task<BaseResponse<QuotationDetailedResponse>> GetSingleQuotation(int QuoteId);
    Task<BaseResponse<PaginatedQuotationResponses>> GetAllQuotation(QuotationFilterDto request);
    Task<BaseResponse<PaginatedQuotationResponses>> GetAllUnderWritingQuotation(QuotationFilterDto request);
    Task<BaseResponse<GenericNameResponse>> AssignQuoteToPersonalWorkbench(int quoteId);
    Task<BaseResponse<PaginatedQuotationResponses>> GetPickedQuotesByUnderwriter(QuotationFilterDto request);
    Task<BaseResponse<string>> DownloadFile(int productId, string quotationPreference);
    Task<BaseResponse<GenericNameResponse>> PrintQuote(int quoteId);
    Task<BaseResponse<Dictionary<string, List<Dictionary<string, object>>>>> ExtractExcelDataFromStream(IFormFile file, int ProductId);
    Task<BaseResponse<List<GenericNameResponse>>> QuotationSearch();
    Task<BaseResponse<QuotationCodeResponse>> CreateBulkQuotation(BulkQuotationCreateRequest request);
    Task<BaseResponse<QuotationCodeResponse>> CreateQuotationIteration(int quotationId, QuotationUpdateRequest request);
    Task<BaseResponse<ValidateCustomerResponse>> ValidateCustomer(string Customer);
    Task<BaseResponse<string>> InitiateRMQuoteNegotiation(QuoteNegotiationRequest request);
    Task<BaseResponse<string>> RespondToQuoteNegotiation(UnderwriterReplyRequest request);
    Task<BaseResponse<List<PendingNegotiationDto>>> GetPendingNegotiations();

    Task<BaseResponse<ViewQuoteDetailedResponse>> GetQuotePreviewForPicking(int QuoteId);
    Task<BaseResponse<QuoteNegotiation>> GetSingleNegotiation(int QuoteId);

    Task<BaseResponse<GenericNameResponse>> ReviewQuote(int originalQuoteId, QuotationReviewRequest request);
    Task<BaseResponse<GenericNameResponse>> AcceptQuote(int quoteId);
    Task<BaseResponse<GenericNameResponse>> RejectQuote(int originalQuoteId, QuotationReviewRequest request);
    Task<BaseResponse<PaginatedQuotationResponses>> GetMyUnderWritingQuotations(QuotationFilterDto request);
   
    Task<BaseResponse<GenericNameResponse>> SubmitQuoteForReview(int quoteId, string remarks);
    Task<BaseResponse<GenericNameResponse>> ValidatePriceConfigureUpdate(int attributeId, decimal effectRate);



}
