using RubyNonlife.Application.Dtos.Responses.Quotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public class ProductPricingConfigurationResponse
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ProductPricingConfigurationAttributeResponse> Attributes { get; set; }
    }

    public class ProductPricingConfigurationAttributeResponse
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public bool AffectPricing { get; set; }
        public string EffectType { get; set; }
        public decimal AffectRate { get; set; }
        public decimal MaximumRate { get; set; }
        public decimal MinimumRate { get; set; }
        public string CollectionSource { get; set; }
        public List<int> CoverIds { get; set; } = new();
        public List<string> CoverNames { get; set; } = new(); // New property


    }


    public class ApprovingOfficePricingConfigurationResponse
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ProductApprovingOfficeAttributeResponse> Attributes { get; set; }
    }

    public class OfficePricingConfigurationResponse
    {
        public int Id { get; set; }
        public decimal MaximumRate { get; set; }
        public decimal MinimumRate { get; set; }
        public int OfficeId { get; set; }
        public string OfficeName { get; set; }
    }

    public class ProductApprovingOfficeAttributeResponse
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public bool AffectPricing { get; set; }
        public string EffectType { get; set; }
        public decimal AffectRate { get; set; }
        public decimal MaximumRate { get; set; }
        public decimal MinimumRate { get; set; }
        public string CollectionSource { get; set; }
        public List<int> CoverIds { get; set; } = new();
        public List<string> CoverNames { get; set; } = new(); 
        public int OfficeId { get; set; }
        public string OfficeName { get; set; }


    }






}
