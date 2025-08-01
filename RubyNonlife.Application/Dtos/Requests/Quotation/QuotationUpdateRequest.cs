using RubyNonlife.Application.Dtos.Responses.Quotation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.Quotation
{
    public record QuotationUpdateRequest
    {
        public string ProductClass { get; set; }
        public int BusinessTypeId { get; set; }
        public int QuoteTypeId { get; set; }
        public int PolicyDurationId { get; set; }
        public int ProductId { get; set; }
        public string RiskLocation { get; set; }
        public string StateOfOperation { get; set; }
        public string Channel { get; set; }
        public int QuotePreferencesId { get; set; }
        public string? Customer { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerAddress { get; set; }
        public decimal LostRatio { get; set; }
        public decimal Rate { get; set; }
        public string remarks {  get; set; } = string.Empty;
        public decimal SumInsured {  get; set; }
        public decimal Premium { get; set; }
        public List<UpdateBaseCoverRequest> BaseCoverRequest { get; set; }
        public List<UpdateAdditionalCoverRequest> AdditionalCoverRequest { get; set; }
        public List<QuoteDetailsDto> QuoteDetails { get; set; } // { get; set; }
    }

    public class UpdateBaseCoverRequest
    {
        public int Id { get; set; }
        public int ProductBaseSubjectTypeCoverId { get; set; }
        public string CoverStatus { get; set; }
        public decimal Price {  get; set; }
        public string CoverName {  get; set; }
        public Guid EntityId {  get; set; }
    }

    public class UpdateAdditionalCoverRequest
    {
        public int Id { get; set; }
        public int ProductBaseSubjectTypeCoverId { get; set; }
        public string CoverStatus { get; set; }
        public string CoverName { get; set; }
        public decimal Price { get; set; }
        public Guid EntityId { get; set; }
    }


    public record QuotationReviewRequest
    {
        public string ProductClass { get; set; }
        public int BusinessTypeId { get; set; }
        public int QuoteTypeId { get; set; }
        public int PolicyDurationId { get; set; }
        public int ProductId { get; set; }
        public string RiskLocation { get; set; }
        public string StateOfOperation { get; set; }
        public string Channel { get; set; }
        public int QuotePreferencesId { get; set; }
        public string? Customer { get; set; }
        public string? CustomerAddress { get; set; }
        public decimal LostRatio { get; set; }
        public decimal Rate { get; set; }
        public decimal Premium {  get; set; }
        public decimal SumInsured { get; set; }
        public decimal? Discount {  get; set; }
        public string Reason { get; set; }
        public List<QuoteBaseCoverRequest> BaseCoverRequest { get; set; }
        public List<QuoteAdditionalCoverRequest> AdditionalCoverRequest { get; set; }
        public List<AttributeResponseRequest> AttributeResponse { get; set; }
        public List<PriceConfigureUpdate> PriceConfigureUpdates { get; set; }
    }

     public record PriceConfigureUpdate {
        public int AttributeId {  get; set; }
        public string EffectType {  get; set; }
        public decimal EffectRate {  get; set; }
        public string Affects {  get; set; }
        public List<int> CoverId  {  get; set; }
        public decimal NewPrice {  get; set; }
     }
    public record AttributeResponseRequest
    {
        public List<AttributeResponseDetails> AttributeDetailedResponseList { get; init; }
    }

}
