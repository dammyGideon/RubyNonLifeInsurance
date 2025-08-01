using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Infrastructure.Contract;
using System.Net;

namespace RubyNonlife.Api.Controllers
{

    public class ProductSetupLookupController(IProductServiceLookSetup _lookupService) : BaseController
    {


        [HttpGet("classes")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<ProductClassResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task <IActionResult> GetAllClass()
        {
            var response = await _lookupService.GetClasses();
            return StatusCode((int) response.StatusCode,response);
            
        }

        [HttpGet("classes/{classId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<ProductClassResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetNonLifeClassesDetails(int classId)
        {
            var response = await _lookupService.GetSingleClass(classId);
            return StatusCode((int) response.StatusCode,response);
        }

        [HttpGet("variants")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetNonLifeProductVariant()
        {
            var response = await _lookupService.GetProductVariant();
            return StatusCode((int) response.StatusCode,response);
        }

        [HttpGet("cover-status")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetNonLifeProductCoverStatus()
        {
            var response = await _lookupService.GetCoverStatus();
            return StatusCode((int)response.StatusCode,response);
        }


        [HttpGet("collection-sources")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetCollectionSources()
        {
            var response = await _lookupService.GetSourceOfCollection();
            return StatusCode((int)response.StatusCode,response);
        }

        [HttpGet("parameters")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetParametersDetails()
        {
            var response = await _lookupService.GetParameter();
            return StatusCode((int)response.StatusCode,response);
        }

        [HttpGet("operators")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<OperatorResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetOperatorsDetails()
        {
            var response = await _lookupService.GetOperator();
            return StatusCode((int)response.StatusCode,response);
        }

        [HttpGet("cost-Types")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetCostTypes()
        {
            var response = await _lookupService.GetCostType();
            return StatusCode((int)response.StatusCode,response);
        }

        [HttpGet("frequency")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<FrequencyResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetFrequencyDetails()
        {
            var response = await _lookupService.GetFrequency();
            return StatusCode((int)response.StatusCode,response);
        }

        [HttpGet("ratings")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetRatingDetails()
        {
            var response = await _lookupService.GetRating();
            return StatusCode((int)response.StatusCode,response);
        }

        [HttpGet("character-length")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<CharacterResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetCharacterLengthDetail()
        {
            var response = await _lookupService.GetCharacterLength();
            return StatusCode((int)response.StatusCode,response);
        }


        [HttpGet("cost-bearers")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetCostBearers()
        {
            var response = await _lookupService.GetCostBearer();
            return StatusCode((int)response.StatusCode,response);
        }



        [HttpGet("get-subjects")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> SubjectType()
        {
            var response = await _lookupService.GetSubjectType();
            return StatusCode((int)response.StatusCode,response);
        }


      

        [HttpGet("car-make")]
        public async Task<IActionResult> GetCarMake()
        {
            var response = await _lookupService.GetCarMake();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("car-model/{carMake}")]
        public async Task<IActionResult> GetCarModel(int carMake)
        {
            var response = await _lookupService.GetCarModel(carMake);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-fee-type")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetFeeType()
        {
            var response = await _lookupService.GetFeeType();
            return StatusCode((int)response.StatusCode, response);
        }

    }
}



