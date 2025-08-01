using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static RubyNonlife.Infrastructure.Exceptions.CustomExceptions;

namespace RubyNonlife.Infrastructure.Exceptions
{
    public class GlobalExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionHandlerMiddleware> _logger;

        public GlobalExceptionHandlerMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (NotFoundException ex)
            {
                _logger.LogWarning(ex, "Not Found");
                await HandleExceptionAsync(context, HttpStatusCode.NotFound, ex.Message);
            }
            catch (ValidationException ex)
            {
                _logger.LogWarning(ex, "Validation Error");
                await HandleExceptionAsync(context, HttpStatusCode.BadRequest, ex.Message);
            }
            catch (UnauthorizedException ex)
            {
                _logger.LogWarning(ex, "Unauthorized");
                await HandleExceptionAsync(context, HttpStatusCode.Unauthorized, ex.Message);
            }
            catch (ForbiddenException ex)
            {
                _logger.LogWarning(ex, "Forbidden");
                await HandleExceptionAsync(context, HttpStatusCode.Forbidden, ex.Message);
            }
            catch (ConflictException ex)
            {
                _logger.LogWarning(ex, "Conflict");
                await HandleExceptionAsync(context, HttpStatusCode.Conflict, ex.Message);
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "HTTP Request Failed");
                await HandleExceptionAsync(context, HttpStatusCode.BadGateway, "External API Error");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled Exception");
                await HandleExceptionAsync(context, HttpStatusCode.InternalServerError, "An unexpected error occurred.");
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, HttpStatusCode statusCode, string message)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            var response = new
            {
                Success = false,
                Message = message,
                StatusCode = statusCode
            };

            return context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }


}
