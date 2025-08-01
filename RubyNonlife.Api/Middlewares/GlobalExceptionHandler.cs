using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RubyNonlife.Application.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Infrastructure.Middleware
{
    public class GlobalExceptionHandler : IMiddleware
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;
        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger) {
            _logger = logger;

        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex.Message}");



                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                var errorResponse = new ErrorDetailResponse
                {
                    StatusCode = context.Response.StatusCode,
                    Message = "Internal Server Error"
                };

                if (context.RequestServices.GetRequiredService<IWebHostEnvironment>().IsDevelopment())
                {
                    errorResponse.Message = ex.Message;
                }

                await context.Response.WriteAsJsonAsync(errorResponse);
            }
        }
    }
}
