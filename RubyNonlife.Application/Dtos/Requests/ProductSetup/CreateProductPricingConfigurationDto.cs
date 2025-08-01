using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public class CreateProductPricingConfigurationDto
    {
        public int CategoryId { get; set; }
        public List<ProductPricingAttributeDto> Attributes { get; set; }
    }


    public class ProductPricingAttributeDto
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public bool AffectPricing { get; set; }
        public string EffectType { get; set; }
        public decimal AffectRate { get; set; }
        public string CollectionSource { get; set; }
        public List<int> CoverIds { get; set; } = new();
    }


    public class BulkUpdateProductPricingConfigurationDto
    {
        public int CategoryId { get; set; }
        public List<UpdateProductPricingConfigurationDto> Attributes { get; set; }
    }

    public class UpdateProductPricingConfigurationDto
    {
        public int CategoryId { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public bool AffectPricing { get; set; }
        public string EffectType { get; set; }
        public decimal AffectRate { get; set; }
        public string CollectionSource { get; set; }
        public List<int> CoverIds  { get; set;}
    }

    public record ThresholdRequestdto
    {
        public int ProductId { get; set; }
        public decimal Value { get; set; }
     
    }

    public record ProductDeductibleDto
    {
        public int ProductId { get; set; }
       
        public List<ProductDeductibleRequest> ProductDeductibleRequests { get; set; }
    }

    public record ProductDeductibleRequest
    {
        public string InsuredSubject { get; set; }
        public decimal FixedAmount { get; set; }
        public decimal DeductibleRate { get; set; }
        public string ApplicationType { get; set; }
    }


    public class ProductDeductibleRequestDto
    {
        public int ProductId { get; set; }
        public string InsuredSubject { get; set; }
        public decimal DeductibleRate { get; set; }
        public string ApplicationType { get; set; }
        public decimal FixedAmount { get; set; }
    }


    public record ProductDurationRatedto
    {
        public int ProductId { get; set; }
        public List<ProductDurationRatedRequest> ProductDurationRatedRequest { get; set; }

    }

    public record ProductDurationRatedRequest
    {
        public int DurationInDays { get; set; }
        public decimal Rate { get; set; }
        public string AppliedFor { get; set; }
    }

    public record ProductDurationRatedUpdateRequest
    {
        public int ProductId { get; set; }
        public int DurationInDays { get; set; }
        public decimal Rate { get; set; }
        public string AppliedFor { get; set; }
    }



    public class PriceConfigurationApprovingOfficeInfo
    {
        public int PriceConfigurationId { get; set; }
        public int OfficeId {  get; set; }
        public decimal MinPricePercentage { get; set; }
        public decimal MaxPricePercentage { get; set; }
    }

    public class UpdatePriceConfigurationApprovingOfficeInfo
    {
        public int Id { get; set; }
        public int OfficeId { get; set; }
        public decimal MinPricePercentage { get; set; }
        public decimal MaxPricePercentage { get; set; }
    }
}
