using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using NLog;
using Ruby.Infrastructure.Interfaces;
using Ruby.Models.Enums;
using Ruby.Models.UtilityModels;
using Ruby.Utilities.Constants;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace RubyNonlife.Api.Middlewares
{
    public class ExceptionHandler
    {
        /// <summary>
        /// The next
        /// </summary>
        private readonly RequestDelegate _next;
        /// <summary>
        /// The env
        /// </summary>
        private readonly IWebHostEnvironment _env;
        private readonly Serilog.ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionHandler"/> class.
        /// </summary>
        /// <param name="requestDelegate">The request delegate.</param>
        /// <param name="env">The env.</param>
        public ExceptionHandler(RequestDelegate requestDelegate, IWebHostEnvironment env,ILoggerService logger)
        {
            _next = requestDelegate;
            _env = env;
            _logger = logger.LogConfiguration(LogModulesEnum.GlobalException);
        }
        /// <summary>
        /// Invokes the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            var logId = Guid.NewGuid();
            var logger = LogManager.GetCurrentClassLogger();
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                //Todo : Uncomment
                //    if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
                //    {
                BaseResponse<object> result = new()
                {
                    ResponseCode = "90",
                    ResponseMessage = ex.ToString(),
                    Status = RequestExecutionStatus.Failed
                };
                _logger.Error(LogTemplate.Exception,ex.Message, ex.ToString());
                //logger.Error($"RequestId = {logId} Response=> {ex.ToString()}");
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
                return;
                //}
                //ExceptionFormatter<object> exception = new();
                //context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                //await context.Response.WriteAsync(JsonConvert.SerializeObject(exception.ExceptionResponse()));
                //return;
            }
           
        }

    }
}
