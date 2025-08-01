using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Quotation
{
    public record GetSingleProductResponse
    {
        public int Id { get; init; }
        public string ProductName { get; init; }
        public string ProductDescription { get; init; }
        public int ProductClassId { get; init; }
        public int? VariantId { get; init; }
        public string Code { get; init; }
        public string Alias { get; init; }
        public string ApprovalStatus { get; init; }
        public bool RequiresUnderwriter { get; init; }
        public List<PaymentFrequencyResponse> PaymentFrequencies { get; init; }
        public List<SubjectTypeResponse> SubjectTypes { get; init; }
        public List<ProductBaseSubjectTypeCoverResponse> BaseSubjectTypeCovers { get; init; }
        public List<ProductAdditionalSubjectTypeCoverResponse> AdditionalSubjectTypeCovers { get; init; }
        public List<CostTypeResponse> CostTypes { get; init; }
        public List<CostOfInsuranceResponse> CostOfInsurances { get; init; }
        public List<ProductCategoryDocumentResponse> Documents { get; init; }    
        public List<object> DropdownMappings {  get; init; }


    }

    
}
