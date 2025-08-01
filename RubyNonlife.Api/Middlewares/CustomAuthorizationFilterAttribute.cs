using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Security.Claims;
using System;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.IdentityModel.Tokens;

using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Cryptography;

using System.Collections.Generic;

namespace RubyNonlife.Api.Middlewares
{
    public class CustomAuthorizationFilterAttribute : Attribute, IAuthorizationFilter
    {
        public string _policy;
        public CustomAuthorizationFilterAttribute(string policy = null)
        {
            _policy = policy;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //try
            //{
            //    var token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            //    if (string.IsNullOrEmpty(token))
            //    {
            //        context.Result = new UnauthorizedObjectResult("Unauthorized");
            //        return;
            //    }
            //    var jwt = token.Split(" ")[1];
            //    var claimsPrincial = ValidateToken(jwt);
            //    if (claimsPrincial != null)
            //    {
            //        if (string.IsNullOrEmpty(_policy))
            //        {
            //            return;
            //        }
            //        var actionsClaims = claimsPrincial.FindFirstValue("Actions");

            //        if (string.IsNullOrEmpty(actionsClaims))
            //        {
            //            context.Result = new ForbidResult();
            //            return;
            //        }
            //        var actions = JsonConvert.DeserializeObject<List<string>>(actionsClaims);
            //        if (actions.Any(x => x == _policy))
            //        {
            //            return;
            //        }
            //        context.Result = new ForbidResult();
            //        return;
            //    }
            //    context.Result = new UnauthorizedObjectResult("Unauthorized");
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    context.Result = new UnauthorizedObjectResult("Unauthorized");
            //    return;
            //}
        }
        //public ClaimsPrincipal ValidateToken(string jwtToken)
        //{
        //    SecurityToken validatedToken;
        //    TokenValidationParameters validationParameters = new TokenValidationParameters();

        //    validationParameters.ValidateLifetime = true;
        //    validationParameters.ValidateIssuer = true;
        //    validationParameters.ValidateIssuerSigningKey = true;

        //    validationParameters.ValidAudience = "https://www.axamansard.com/";
        //    validationParameters.ValidIssuer = "https://www.axamansard.com/";
        //    validationParameters.IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes("MAQT98sjiCulOJPsBT3ad2fXvgCsV2Vi"));

        //    ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);


        //    return principal;
        //}

    }
}
