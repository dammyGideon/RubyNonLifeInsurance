using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using RubyNonlife.Infrastructure.Contract;
using System.Net;

namespace RubyNonlife.Api.Controllers
{
    
    public class ProductDocumentController : BaseController
    {
        private readonly IProductDocumentService _productDocumentService;
        public ProductDocumentController(IProductDocumentService service) {
            _productDocumentService = service;
        }

        [HttpPost("create-document-category")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CreateCategory([FromBody] ProductCategoryDocumentResponseRequest request)
        {
            var response = await _productDocumentService.CreateCategoryAsync(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPut("update-document--category/{categoryId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateCategory(int categoryId, [FromBody] ProductCategoryDocumentResponse request)
        {
            var response = await _productDocumentService.UpdateCategoryAsync(categoryId, request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-all-document-category")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<ProductCategoryDocumentResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetCategoryAsync(int productId)
        {
            var response = await _productDocumentService.GetCategoryAsync(productId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-endorsement-type")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<ProductCategoryDocumentResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> EndorsementType()
        {
            var response = await _productDocumentService.EndorsementType();
            return StatusCode((int)response.StatusCode, response);
        }



        [HttpDelete("delete-category/{categoryId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            var response = await _productDocumentService.DeleteCategoryAsync(categoryId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpDelete("delete-document/{documentId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteDocument(int documentId)
        {
            var response = await _productDocumentService.DeleteDocumentAsync(documentId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-documents")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPolicyDocument()
        {
            var response = await _productDocumentService.GetPolicyDocumentSetup();
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-document-type")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPolicyDocumentType()
        {
            var response = await _productDocumentService.DocumentFormat();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-documents-size")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<GenericNameResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetPolicyDocumentSize()
        {
            var response = await _productDocumentService.DocumentSize();
            return StatusCode((int)response.StatusCode, response);
        }


    }
}
