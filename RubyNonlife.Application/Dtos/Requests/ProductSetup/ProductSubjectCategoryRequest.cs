using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record ProductSubjectCategoryRequest
    {
        public string CategoryName { get; init; }
        public List<ProductSubjectRequest> ProductSubjectAttributes { get; init; }
    }


   

    public record ProductSubjectCategoryRequestDto
    {
        public string CategoryName { get; set; }
        public List<int> GenericCategoryId { get; set; } // List of category IDs (generic or non-generic)
        public List<int> SubjectTypeId { get; set; } // List of SubjectTypeIds
        public List<ProductSubjectAttributeRequest> ProductSubjectAttributes { get; set; } // List of attributes for the product
    }

    public record ProductSubjectRequestDto
    {
        public int SubjectTypeId { get; init; }
    }


    public class ProductCategorySubjectSetupDto
    {
        public List<ProductSubjectCategoryRequest> SubjectCategories { get; set; }
        public int ProductId { get; set; }
        public List<int> GenericRequest { get; set; }
    }


}
