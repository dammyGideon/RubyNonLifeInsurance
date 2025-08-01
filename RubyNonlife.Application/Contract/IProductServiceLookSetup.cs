
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RubyNonlife.Infrastructure.Contract
{
    public interface IProductServiceLookSetup
    {

       
        Task<BaseResponse<List<ProductClassResponse>>> GetClasses();
        Task<BaseResponse<SingleProductClassResponse>> GetSingleClass(int productClassId);
        Task<BaseResponse<List<GenericNameResponse>>> GetCoverStatus();
        Task<BaseResponse<List<GenericNameResponse>>> GetProductVariant();
        Task<BaseResponse<List<GenericNameResponse>>> GetParameter();
        Task<BaseResponse<List<OperatorResponse>>> GetOperator();
        Task<BaseResponse<List<GenericNameResponse>>> GetCostType();
        Task<BaseResponse<List<FrequencyResponse>>> GetFrequency();
        Task<BaseResponse<List<GenericNameResponse>>> GetRating();
        Task<BaseResponse<List<CharacterResponse>>> GetCharacterLength();
        Task<BaseResponse<List<GenericNameResponse>>> GetCostBearer();
        Task<BaseResponse<List<GenericNameResponse>>> GetSubjectType();
        Task<BaseResponse<List<GenericNameResponse>>> GetPolicyDocumentSetup();
        Task<BaseResponse<List<GenericNameResponse>>> GetSourceOfCollection();
        Task<BaseResponse<List<GenericNameResponse>>> GetDataType();
        Task<BaseResponse<List<GenericNameResponse>>> DocumentFormat();
        Task<BaseResponse<List<GenericNameResponse>>> DocumentSize();
        Task<BaseResponse<List<GenericNameResponse>>> GetCarMake();
        Task<BaseResponse<List<GenericNameResponse>>> GetCarModel(int carMake);
        Task<BaseResponse<List<GenericNameResponse>>> GetFeeType();

       


    }
}
