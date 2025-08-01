using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ruby.Api.Middlewares
{
    public class JwtHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _tokenSecret;
        private readonly string _issuer;
        private readonly string _audience;


        public JwtHandlerMiddleware(RequestDelegate next, IConfiguration _config )
        {
            _next = next;
            _tokenSecret = _config["Jwt:SecretKey"];
            _issuer = _config["Jwt:Issuer"];
            _audience = _config["Jwt:Audience"];
        }

        //public async Task Invoke(HttpContext context)
        //{
        //    try
        //    {
        //        var token = await ExtractToken(context);
        //        if (token != null)
        //        {
        //            await ValidateToken(token);
        //            AttachUserToContext(context, token); // Attach user information to context
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        context.Response.StatusCode = 401; // Unauthorized
        //        await context.Response.WriteAsync(ex.Message);
        //        return;
        //    }

        //    await _next(context); 
        //}

        //private async Task<string> ExtractToken(HttpContext context)
        //{
        //    if (context.Request.Headers.ContainsKey("Authorization"))
        //    {
        //        var authorizationHeader = context.Request.Headers["Authorization"];
        //        var token = authorizationHeader.ToString().Split(' ')[1]; // Assuming Bearer token format
        //        return token;
        //    }
        //    return null;
        //}

        //private async Task ValidateToken(string token)
        //{
        //    var tokenValidationParameters = new TokenValidationParameters
        //    {
        //        ValidateIssuerSigningKey = true,
        //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_tokenSecret)),
        //        ValidateIssuer = true,
        //        ValidIssuer = _issuer,
        //        ValidateAudience = true,
        //        ValidAudience = _audience,
        //        ValidateLifetime = true,
        //        ClockSkew = TimeSpan.Zero // Set clock skew to zero for strict time validation (optional)
        //    };

        //    await _securityTokenHandler.ValidateTokenAsync(token, tokenValidationParameters); 
        //}

        //private void AttachUserToContext(HttpContext context, string token)
        //{
        //    var validatedToken = _securityTokenHandler.ReadJwtToken(token);
        //    var actions = validatedToken.Claims.FirstOrDefault(c => c.Type == "Actions")?.Value.Split(',').Select(x => x.Trim()).ToList();
        //    var roles = validatedToken.Claims.FirstOrDefault(c => c.Type == "Role")?.Value.Split(',').Select(x => x.Trim()).ToList();

        //    var userPermissions = new UserPermissions
        //    {
        //        Actions = actions,
        //        Roles = roles
        //    };

        //    context.Items["UserPermissions"] = userPermissions;
        //}

        //private readonly JwtSecurityTokenHandler _securityTokenHandler = new JwtSecurityTokenHandler();
    }



   
    //public class UserPermissions
    //{
    //    public List<string> Actions { get; set; }
    //    public List<string> Roles { get; set; }
    //}

    //public static class JwtMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseJwtMiddleware(this IApplicationBuilder builder, IConfiguration configuration)
    //    {
    //        return builder.UseMiddleware<JwtHandlerMiddleware>(configuration);
    //    }
    //}
}
