using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Jwt
{
    public class FunctionDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }


    public class AdminAuthenticationResponse
    {
        public AdminAuthPayload Payload { get; set; }
        public int TotalCount { get; set; }
        public string ResponseCode { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public List<string> Errors { get; set; }
        public bool HasErrors { get; set; }
    }

    public class AdminAuthPayload
    {
        public string Id { get; set; }
        public string AdUsername { get; set; }
        public List<FunctionDto> Functions { get; set; }
        // add other properties as needed
    }

    public class LightweightAdminResponse
    {
        [JsonProperty("payload")]
        public object Payload { get; set; }

        [JsonProperty("hasErrors")]
        public bool HasErrors { get; set; }

        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
    }


    public class AdminAuthResponse
    {
        [JsonProperty("payload")]
        public List<FullnameUserPayload> Payload { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("errors")]
        public List<string> Errors { get; set; }

        [JsonProperty("hasErrors")]
        public bool HasErrors { get; set; }
    }

    public class FullnameUserPayload
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("adUsername")]
        public string AdUsername { get; set; }

        // Add more fields if needed, only included necessary ones here
    }



}
