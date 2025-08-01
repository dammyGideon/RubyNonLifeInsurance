using Microsoft.AspNetCore.Mvc;
using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Dtos.Requests.LineOfBusines;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.LineOfBuisnessGenericResponse;
using System.Net;

namespace RubyNonlife.Api.Controllers
{
  
    public class BusinessAttributeSetupController(ILineOfBusinessGenericService _lineOfBusinessGeneric) : BaseController
    {


        [HttpPost("create-generic-category")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateCategoryAsync(CreateLineOfBusinessAttributeCategoryDto request)
        {
            var response = await _lineOfBusinessGeneric.CreateGenericCategory(request);
            return StatusCode((int)response.StatusCode, response);
        }



        [HttpGet("get-all-generic-category/{lineOfBusinessId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllGenericCategory(int lineOfBusinessId, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var response = await _lineOfBusinessGeneric.GetAllGenericCategory(lineOfBusinessId, pageNumber, pageSize);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-single-generic-category/{categoryId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetSingleGenericCategory(int categoryId) { 
            var response = await _lineOfBusinessGeneric.GetSingleGenericCategory(categoryId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpDelete("delete-generic-category/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteGenericCategory(int id)
        {
            var response = await _lineOfBusinessGeneric.DeleteGenericCategoryAsync(id);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPut("update-generic-category")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> UpdateGenericCategory(int categoryId, UpdateLineOfBusinessAttributeCategoryDto request)
        {
            var response = await _lineOfBusinessGeneric.UpdateGenericCategory(categoryId,request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("create-generic-attribute")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateAttributeForGenericCategory(List<CreateLineOfBusinessAttributeItemDto> request)
        {
            var response = await _lineOfBusinessGeneric.CreateAttributeForGenericCategory(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-all-generic-attributes/{categoryId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAttributesForGenericCategory(int categoryId, string? attributeName = null, int pageNumber = 1, int pageSize = 10)
        {
            var response = await _lineOfBusinessGeneric.GetAttributesForGenericCategory(categoryId,attributeName, pageNumber,pageSize);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpDelete("delete-generic-attributes/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteAttributeForGenericCategory(int id)
        {
            var response = await _lineOfBusinessGeneric.DeleteAttributeForGenericCategoryAsync(id);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPut("update-generic-attribute")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> UpdateAttributeForGenericCategory(UpdateLineOfBusinessAttributeItemDto request)
        {
            var response = await _lineOfBusinessGeneric.UpdateAttributeForGenericCategory(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("create-line-of-business-attribute-mapping")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateLineOfBusinessAttributeMapping(List<CreateLineOfBusinessAttributeMappingDto> dropdownMappingRequests)

        {
            var response = await _lineOfBusinessGeneric.CreateLineOfBusinessAttributeMapping(dropdownMappingRequests);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-single-attribute/{attributeId}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetSingleAttribute(int attributeId)

        {
            var response = await _lineOfBusinessGeneric.GetSingleAttribute(attributeId);
            return StatusCode((int)response.StatusCode, response);
        }

       

        [HttpGet("get-line-of-business-attribute-mappings/{categoryId}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetLineOfBusinessAttributeMappings(int categoryId)
        {
            var response = await _lineOfBusinessGeneric.GetLineOfBusinessAttributeMappings(categoryId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-by-category/{categoryId}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetByCategoryId(int categoryId)
        {
            var response = await _lineOfBusinessGeneric.GetByCategoryId(categoryId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-all-category-attributes-mapping/{lineOfBusinessId}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        //  [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllCategoryAttributesMapping(int lineOfBusinessId)
        {
            var response = await _lineOfBusinessGeneric.GetAllCategoryAttributesMapping(lineOfBusinessId);
            return StatusCode((int)response.StatusCode, response);
        }

    }
}



