using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Dtos.Requests.jwtRequest;
using RubyNonlife.Application.Dtos.Responses;
using System.Net;

namespace RubyNonlife.Api.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAdAuthenticationService _authentication;
        public AuthenticationController(IAdAuthenticationService authentication)
        {
            _authentication = authentication;
        }

        //[HttpPost("ad-authentication")]
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        //[ProducesResponseType((int)HttpStatusCode.NotFound)]
        //public async Task<IActionResult> AuthenticationAdUser([FromBody] AuthRequestDto request)
        //{
        //    var response = await _authentication.AuthenticationAdUser(request.username,request.password);
        //    return StatusCode((int)response.StatusCode, response);
        //}

        [HttpPost("authentication")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> AuthenticationUser([FromBody] AuthRequestDto request)
        {
            var response = await _authentication.AuthenticatedUser(request.username, request.password);
            return StatusCode((int)response.StatusCode, response);
        }
    }
}
