using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Infrastructure.Contract
{
    public interface IProductDocumentService
    {
        Task<BaseResponse<ProductCategoryDocumentResponse>> CreateCategoryAsync(ProductCategoryDocumentResponseRequest request);
        Task<BaseResponse<ProductCategoryDocumentResponse>> UpdateCategoryAsync(int categoryId, ProductCategoryDocumentResponse request);
        Task<BaseResponse<List<ProductCategoryDocumentResponse>>> GetCategoryAsync(int productId);
        Task<BaseResponse<GenericNameResponse>> DeleteCategoryAsync(int categoryId);
        Task<BaseResponse<GenericNameResponse>> DeleteDocumentAsync(int documentId);
        Task<BaseResponse<List<GenericNameResponse>>> EndorsementType();
        Task<BaseResponse<List<GenericNameResponse>>> GetPolicyDocumentSetup();
        Task<BaseResponse<List<GenericNameResponse>>> DocumentFormat();
        Task<BaseResponse<List<GenericNameResponse>>> DocumentSize();

    }
}
