using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using RubyNonlife.Application.Dtos.Responses;

namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public record ProductStagingResponse
    {
        public string ProductName { get; set; }
        public ProductSetupDraftRequest Data { get; set; }
        public DateTime DateCreated { get; set; }
    }

}


