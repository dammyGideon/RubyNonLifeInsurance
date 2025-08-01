using RubyNonlife.Domain.Enums;
using System.Net;


namespace RubyNonlife.Application.Dtos.Responses
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public string ResponseMessage { get; set; }
        public T Data { get; set; }
     
        public HttpStatusCode StatusCode { get; set; }


        public BaseResponse()
        {
            Success = true;
            ResponseMessage = string.Empty;
            StatusCode = HttpStatusCode.OK;
        }

        public BaseResponse(bool success, string responseMessage, T data, HttpStatusCode httpStatusCode)
        {
            Success = success;
            ResponseMessage = responseMessage;
            Data = data;
            StatusCode = httpStatusCode;
        }


        public RequestExecutionStatus Status { get; set; }
    }


}
