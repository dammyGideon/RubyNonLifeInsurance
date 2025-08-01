using Microsoft.AspNetCore.Http;
using RubyNonlife.Application.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public static class ResponseFactory
    {
        public static BaseResponse<T> CreateSuccess<T>(T data, string Message)
        {
            return new BaseResponse<T>
            {
                Success = true,
                ResponseMessage = Message,
                Data = data,
                StatusCode = HttpStatusCode.OK,

            };
        }

        public static BaseResponse<T> GetSuccessResponse<T>(T data, string Message)
        {
            return new BaseResponse<T> { Success = true, ResponseMessage = Message, Data = data, StatusCode = HttpStatusCode.OK };
        }
        public static BaseResponse<T> CreateSuccessWithOutData<T>(string Message, HttpStatusCode statusCode)
        {
            return new BaseResponse<T>
            {
                Success = true,
                ResponseMessage = Message,
                StatusCode = statusCode,
            };
        }


        public static BaseResponse<T> CreateError<T>(string Message, HttpStatusCode statusCode)
        {
            return new BaseResponse<T>
            {
                Success = false,
                ResponseMessage = Message,
                StatusCode = statusCode,
            };
        }

        public static BaseResponse<T> CreateFailure<T>(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            return new BaseResponse<T>
            {
                Success = false,
                ResponseMessage = message,
                StatusCode = statusCode
            };
        }


    }
}
