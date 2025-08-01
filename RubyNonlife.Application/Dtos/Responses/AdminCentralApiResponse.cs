using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses
{
    public class AdminCentralApiResponse<T>
    {
        public List<T> Payload { get; set; }
        public int TotalCount { get; set; }
        public int? ResponseCode { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public List<string> Errors { get; set; }
        public bool HasErrors { get; set; }
    }


    public class AdminBaseResponse<T>
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public List<string> Errors { get; set; }
        public bool HasErrors { get; set; }
        public T Payload { get; set; }
        public int TotalCount { get; set; }
        public string ResponseCode { get; set; }
    }


    public class AdminNameMappingResponse
    {
        public int Id { get; set; }
        public string Caption { get; set; }
       
    }

    public class AdminProductClassResponse
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Url { get; set; }
    }

    public class AdminRiderResponse
    {
        public int Id { get; set; }
        public string Caption { get; set; }
    }


}
