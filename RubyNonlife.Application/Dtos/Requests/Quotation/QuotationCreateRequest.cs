using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.Quotation
{
    public class QuotationCreateRequest
    {
        [Required] public string ProductClass { get; set; }
        [Required] public int BusinessTypeId { get; set; }
        [Required] public int QuoteTypeId { get; set; }
        [Required] public int PolicyDurationId { get; set; }
        [Required] public int ProductId { get; set; }
        [Required] public string RiskLocation { get; set; }
        [Required] public string StateOfOperation { get; set; }
        [Required] public string Channel { get; set; }
        public int QuotePreferencesId { get; set; }
        public string? Customer { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerAddress {  get; set; }
        public decimal LostRatio { get; set; }
        public List<QuotationAttributeValueRequest> QuoteAttributes { get; set; }
        public List<QuoteBaseCoverRequest> BaseCoverRequest { get; set; }
        public List<QuoteAdditionalCoverRequest> AdditionalCoverRequest { get; set; }
        
    }
    public class BulkQuotationCreateRequest
    {
        public string Customer { get; set; } // Customer's name
        public string CustomerNumber { get; set; }
        public int BusinessTypeId { get; set; } // ID for the business type
        public int ProductId { get; set; } // ID for the product
        public string ProductClass { get; set; } // Class of the product
        public int QuotePreferencesId { get; set; } // Preferences for the quote
        public int QuoteTypeId { get; set; } // Type of quote
        public int PolicyDurationId { get; set; } // Duration of the policy
        public string RiskLocation { get; set; } // Location of the risk
        public string StateOfOperation { get; set; } // State of operation
        public string Channel { get; set; } // Sales channel
        public decimal LostRatio { get; set; } // Lost ratio for the quotation
        public string CustomerAddress { get; set; } // Address of the customer
        public List<BulkBaseCoverRequest> BaseCoverRequest { get; set; } // List of base covers
        public List<BulkAdditionalCoverRequest> AdditionalCoverRequest { get; set; } // List of additional covers
        public List<QuoteDetailsDto> QuoteDetails { get; set; } //
    }
    public class QuoteAttributeRequest
    {
        public int AttributeId { get; set; } // ID for the attribute
        public string AttributeName { get; set; } // Name of the attribute
        public object AttributeValue { get; set; } // Value of the attribute
    }
    public class BulkBaseCoverRequest
    {
        public int ProductBaseSubjectTypeCoverId { get; set; } // ID for the base cover
        public string CoverStatus { get; set; } // Status of the cover
        public string CoverName { get; set; }
        public decimal Price { get; set; } // Price for the base cover

    }
    public class BulkAdditionalCoverRequest
    {
        public int ProductBaseSubjectTypeCoverId { get; set; } // ID for the additional cover
        public string CoverStatus { get; set; } // Status of the cover
        public string CoverName { get; set; }
        public decimal Price { get; set; } // Price for the additional cover
    }
    public record QuoteBaseCoverRequest
    {
      
        public Guid EntityId {  get; set; }
        public int ProductBaseSubjectTypeCoverId { get; init; }
        public string CoverStatus { get; init; }
        public string CoverName { get; set; }
        public decimal Price {  get; init; } 
    }
    public record QuoteAdditionalCoverRequest
    {
        public Guid EntityId { get; set; }
        public int ProductBaseSubjectTypeCoverId { get; init; }
        public string CoverStatus { get; init; }
        public string CoverName { get; set; }
        public decimal Price { get; init; }
    }
    public class QuotationAttributeValueRequest
    {
            public string AttributeName { get; set; }
            public dynamic AttributeValue { get; set; } 
            public int AttributeId { get; set; }
            
            public Guid EntityId { get; set; }
        

    }

    public class QuoteDetailsDto
    {
        public List<QuotationAttributeValueRequest> QuoteAttributes { get; set; }
    }

    public class CustomerValidationRequest
    {
        public string? CustomerNumber { get; set; }
        public string? CustomerEmail {  get; set; }
        public string? CustomerName { get; set; }
    }
}
