using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RubyNonlife.Application.Dtos.Requests.Reinsurance;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.ReinsuranceResponse;
using RubyNonlife.Infrastructure.Contract;
using System.Net;

namespace RubyNonlife.Api.Controllers
{
    
    public class ReinsuranceAgreementController : BaseController
    {
        private readonly IReinsuranceService _reinsuranceService;
        public ReinsuranceAgreementController(IReinsuranceService reinsuranceService) {
            _reinsuranceService = reinsuranceService;
        }


        [HttpGet("get-transaction-type")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetTransactionType()
        {
            var response = await _reinsuranceService.GetTransactionType();
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("create-reinsurance-Agreement")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Create([FromBody] ReinsuranceAgreementRequestDto request)
        {
            var response = await _reinsuranceService.CreateAgreementSetup(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-all-reinsurance-Agreement")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<ReinsuranceAgreementResponseDto>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAll()
        {
            var response = await _reinsuranceService.GetAllAgreements();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-reinsurance-Agreement-by-id")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<ReinsuranceAgreementResponseDto>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetSingleReinsurance(int reinsuranceId)
        {
            var response = await _reinsuranceService.GetAgreementById(reinsuranceId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-product-class")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> ProductClass()
        {
            var response = await _reinsuranceService.GetProductClass();
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("calculate-treaty")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<TreatyCapacityCalculationResponseDto>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CalculateTreaty(decimal retentionAmount, int numberOfLines)
        {
            var response = await _reinsuranceService.CalculateTreaty(retentionAmount, numberOfLines);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("create-protection-layer")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateProductionLayer(ProtectionLayerRequestDto request)
        {
            var response = await _reinsuranceService.CreateProtectionLayer(request);
            return StatusCode((int)response.StatusCode, response);
        }



        [HttpGet("get-all-protection-layer")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllProductionLayer()
        {
            var response = await _reinsuranceService.GetAllProtectionLayers();
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-single-protection-layer")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetSingleProductionLayer(int protectionId)
        {
            var response = await _reinsuranceService.GetProtectionLayerById(protectionId);
            return StatusCode((int)response.StatusCode, response);
        }



        [HttpPut("update-protection-layer")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> UpdateProductionLayer(int agreementId, ProtectionLayerRequestDto request)
        {
            var response = await _reinsuranceService.UpdateProtectionLayer(agreementId,request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpDelete("delete-protection-layer")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> DeleteProductionLayer(int protectionId)
        {
            var response = await _reinsuranceService.DeleteProtectionLayer(protectionId);
            return StatusCode((int)response.StatusCode, response);
        }









    }
}




