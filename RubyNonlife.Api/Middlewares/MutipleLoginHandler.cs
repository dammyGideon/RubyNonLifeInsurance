using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Novacode;
using Ruby.Data.Models;
using Ruby.Infrastructure.Interfaces;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Ruby.Api.Middlewares
{


    /// <summary>
    /// 
    /// </summary>
    public class MutipleLoginHandler
    {
        /// <summary>
        /// The next
        /// </summary>
        private readonly RequestDelegate _next;
        /// <summary>
        /// The env
        /// </summary>
        private readonly IWebHostEnvironment _env;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionHandler"/> class.
        /// </summary>
        /// <param name="requestDelegate">The request delegate.</param>
        /// <param name="env">The env.</param>
        public MutipleLoginHandler(RequestDelegate requestDelegate, IWebHostEnvironment env)
        {
            _next = requestDelegate;
            _env = env;
        }
        /// <summary>
        /// Invokes the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {

            var token = context.Request.Headers["Authorization"].FirstOrDefault();
            if (token != null && !context.Request.Path.Value.Contains("authentication/login"))
            {
                var bearerToken = token.Split(" ");
                var userId = context.User.Claims.SingleOrDefault(x => x.Type == "UserId")?.Value;
                var loginKey = context.User.Claims.SingleOrDefault(x => x.Type == "LoginKey")?.Value;

                if (context.Request.Path.ToString() != "/api/v1/authentication/log-out")
                {
                    if (loginKey == null || userId == null)
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        return;
                    }
                    var services = context.RequestServices.GetRequiredService<RubyContext>();
                    var checkLoginKey = services.LoginHistories.Any(x => x.LoginKey.ToLower() == loginKey.ToLower() && x.IsLoginActive);

                    if (!checkLoginKey)
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        return;
                    }
                }
            }
            await _next.Invoke(context);

        }
    }
}
