using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RubyNonlife.Api.Controllers
{ 
    [Authorize]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BaseController : ControllerBase
    {
    }


}





//CREATE SEQUENCE NonLifeProductCodeSequence
//    START WITH 100
//    INCREMENT BY 1
//    MINVALUE 100
//    MAXVALUE 9999999999
//    CYCLE
//    CACHE 50;

//CREATE SEQUENCE QuotationCodeSequence
//    START WITH 100
//    INCREMENT BY 1
//    MINVALUE 100
//    MAXVALUE 9999999999
//    CYCLE
//    CACHE 50;


//CREATE SEQUENCE PolicyCodeSequence
//    START WITH 100
//    INCREMENT BY 1
//    MINVALUE 100
//    MAXVALUE 9999999999
//    CYCLE
//    CACHE 50;