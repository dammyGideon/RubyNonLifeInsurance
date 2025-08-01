namespace RubyNonlife.Application.Dtos.Responses.Quotation
{
    public record QuotationDetailedResponse
    {
        public int Id { get; init; }
        public NestedIdNameResponse BusinessType { get; init; }
        public NestedIdNameResponse QuotePreference { get; init; }
        public NestedIdNameResponse QuoteType { get; init; }
        public NestedIdNameResponse PolicyDuration { get; init; }
        public NestedIdNameResponse Product { get; init; }
        public NestedIdNameResponse ProductClass { get; set; }
        public string RiskLocation { get; init; }
        public string StateOfOperation { get; init; }
        public string Channel { get; init; }
        public double SLA { get; init; }
        public decimal SLAUsage { get; init; }
        public bool IsLocked { get; init; }
        public DateTime CreateAt { get; init; }
        public string? CreateBy { get; init; }
        public decimal? SumInsured { get; init; }
        public decimal? Premium { get; init; }
        public string? Customer { get; init; }
        public decimal? LostRatio { get; init; }
        public string? CustomerAddress { get; init; }
        public string? CustomerNumber { get; init; }
        public string RequireUnderWriting { get; init; }
        public decimal? RateApplied { get; init; }
        public int? PreviousQuoteId { get; init; }
        public int VersionNumber { get; init; }
        public string? FleetNumber { get; init; }
        public decimal? Discount { get; init; }
        public bool RequireUnderWritingApproval { get; init; }
        public Dictionary<string, string> DynamicAttributes { get; init; }
        public List<AttributeResponse> AttributeResponse { get; init; }
        public NegotiationResponse NegotiationResponse { get; init; }
        public List<VersionResponse> PreviousVersions { get; init; }
        public List<QuotePriceResponse> QuotePriceResponse { get; init; }
    }


    public class NestedIdNameResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class VersionResponse
    {
        public int OriginalQuoteId {  get; set; } 
        public int VersionNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int QuoteId { get; set; }
        public decimal? Premium { get; set; }
        public decimal? Discount { get; set; }
    }


    public record AttributeResponse
    {
        public Guid EntityId { get; set; }
        public List<AttributeResponseDetails> AttributeResponseDetails { get; init; }
        public List<QuotationBaseCoverResponse> QuotationBaseCovers { get; init; }
        public List<QuotationAdditionalCoverResponse> QuotationAdditionalCovers { get; init; }
    }

    public record AttributeResponseDetails
    {
        public int Id { get; init; }
        public int AttributeId { get; set; }
        public string AttributeName { get; init; }
        public string AttributeValue { get; init; } 
        public Guid EntityId {  get; init; }
      
    }




    public record ViewQuoteDetailedResponse
    {

        public int Id { get; init; }

        public NestedIdNameResponse BusinessType { get; init; }
        public NestedIdNameResponse QuotePreference { get; init; }
        public NestedIdNameResponse QuoteType { get; init; }
        public NestedIdNameResponse PolicyDuration { get; init; }
        public NestedIdNameResponse Product { get; init; }
        public NestedIdNameResponse ProductClass { get; init; }
       
        public bool IsFleet { get; init; }
        public string RiskLocation { get; init; }
        public string StateOfOperation { get; init; }
        public string Channel { get; init; }

        public double SLA { get; init; }
        public decimal SLAUsage { get; init; }
        public bool IsLocked { get; init; }

        public DateTime CreateAt { get; init; }
        public string? CreateBy { get; init; }

        public decimal? SumInsured { get; init; }
        public decimal? Premium { get; init; }
        public string? Customer { get; init; }
        public decimal? LostRatio { get; init; }
        public string? CustomerAddress { get; init; }
        public string RequireUnderWriting { get; init; }
        public decimal? RateApplied { get; init; }
        public decimal? Discount { get; init; }
        public List<PenaltyDetailedResponse> PenaltyDetailedResponse {  get; init; }
        public Dictionary<string, string> DynamicAttributes { get; init; } // Dynamic attributes
        
        public List<AttributeDetailedResponse> AttributeResponse { get; init; }
        public NegotiationResponse NegotiationResponse { get; init; }
        public List<VersionResponse> PreviousVersions { get; init; }
        public List<QuotePriceResponse> QuotePriceResponse { get; init; }
    }

    public record NegotiationResponse
    {
        public string Comments {  get; init; }
        public string CreateBy { get; init; }
    }

    public class CoverDetail
    {
        public int CoverId { get; set; }
        public string CoverName { get; set; }
    }


    public record QuotePriceResponse
    {
        public string AttributeName { get; init; }
        public int AttributeId {  get; init; }
        public string AttributeValue {  get; init; }
        public bool AffectPricing { get; init; }
        public string EffectType { get; init; }
        public decimal AffectRate { get; init; }
        public string Affects {  get; init; }
        public List<CoverDetail> CoverDetails { get; set; }

    }


    public record AttributeDetailedResponse
    {
        public Guid EntityId { get; init; }
        public List<AttributeDetailedResponseList> AttributeDetailedResponseList { get; init; }
        public List<QuotationBaseCoverResponse> QuotationBaseCovers { get; init; }
        public List<QuotationAdditionalCoverResponse> QuotationAdditionalCovers { get; init; }
    }
    public record AttributeDetailedResponseList
    {
        public int Id { get; init; }
        public string Category { get; init; }
        public int AttributeId { get; init; }
        public string AttributeName { get; init; }
        public string AttributeValue { get; init; }
        public Guid EntityId { get; init; }
       

        
    }

    public record PenaltyDetailedResponse
    {
        public int Penalty { get; init; }
    }
}
