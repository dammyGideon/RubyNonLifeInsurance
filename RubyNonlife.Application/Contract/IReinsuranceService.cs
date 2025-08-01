using RubyNonlife.Application.Dtos.Requests.Reinsurance;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.Booking;
using RubyNonlife.Application.Dtos.Responses.ReinsuranceResponse;
using RubyNonlife.Application.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Infrastructure.Contract
{
    public interface IReinsuranceService
    {
        Task<BaseResponse<List<GenericNameResponse>>> GetTransactionType();
        Task<BaseResponse<GenericNameResponse>> CreateAgreementSetup(ReinsuranceAgreementRequestDto request);
        Task<BaseResponse<List<ReinsuranceAgreementResponseDto>>> GetAllAgreements();
        Task<BaseResponse<ReinsuranceAgreementResponseDto>> GetAgreementById(int id);
        Task<BaseResponse<GenericNameResponse>> UpdateAgreement(int id, ReinsuranceAgreementRequestDto request);
        Task<BaseResponse<GenericNameResponse>> DeleteAgreement(int id);
        Task<BaseResponse<TreatyCapacityCalculationResponseDto>> CalculateTreaty(decimal retentionAmount, int numberOfLines);
        Task<BaseResponse<List<GenericNameResponse>>> GetProductClass();
        Task<BaseResponse<GenericNameResponse>> CreateProtectionLayer(ProtectionLayerRequestDto request);
        Task<BaseResponse<List<ProtectionLayerResponseDto>>> GetAllProtectionLayers();
        Task<BaseResponse<ProtectionLayerResponseDto>> GetProtectionLayerById(int id);
        Task<BaseResponse<GenericNameResponse>> UpdateProtectionLayer(int id, ProtectionLayerRequestDto request);
        Task<BaseResponse<GenericNameResponse>> DeleteProtectionLayer(int id);


        Task<List<SimulationResult>> Simulate(string productName, decimal premium, decimal totalSumAssured);
    }
}
