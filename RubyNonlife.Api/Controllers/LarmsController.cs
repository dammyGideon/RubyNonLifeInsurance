using Microsoft.AspNetCore.Mvc;
using RubyNonlife.Application.Contract;



namespace RubyNonlife.Api.Controllers
{
   
    public class LarmsController : BaseController
    {
        private readonly ILarmsService _larmsService;
        public LarmsController(ILarmsService larmsService) {
            _larmsService = larmsService;
        }
        // GET: api/<ValuesController>
        [HttpGet("get-details")]
        public async Task<IActionResult> GetCustomer(string customerId)
        {
            var response =await _larmsService.SearchLaramsLeadsAsync(customerId);
            return Ok(response);
        }

   
    }
}
