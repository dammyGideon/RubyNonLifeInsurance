using MailKit.Search;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.Larms;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Application.Helper.UtitlityModel;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Implementations
{
    public class LarmsService : ILarmsService
    {
        //MockLarms 
        private readonly ConfigModels _configModels;
        public LarmsService(IOptions<ConfigModels> configOptions)
        {
            _configModels = configOptions.Value;
        }

        //public async Task<BaseResponse<LarmsResponse>> GetLeadByLeadId(Guid leadId)
        //{
        //    var baseUrl = _configModels.MockLarms;
        //    var url = $"{baseUrl}/{leadId}";

        //    using var client = new HttpClient();

        //    try
        //    {
        //        var response = await client.GetAsync(url);
        //        if (!response.IsSuccessStatusCode)
        //        {
        //            return ResponseFactory.CreateError<LarmsResponse>("Failed to retrieve lead by ID", HttpStatusCode.BadRequest);
        //        }

        //        var jsonString = await response.Content.ReadAsStringAsync();
        //        var result = JsonSerializer.Deserialize<LarmsResponse>(jsonString, new JsonSerializerOptions
        //        {
        //            PropertyNameCaseInsensitive = true
        //        });

        //        if (result == null)
        //        {
        //            return ResponseFactory.CreateError<LarmsResponse>("No data returned for the given Lead ID", HttpStatusCode.NoContent);
        //        }

        //        return ResponseFactory.CreateSuccess<LarmsResponse>(result, "Larms retrieved Successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        return ResponseFactory.CreateError<LarmsResponse>($"Internal error: {ex.Message}", HttpStatusCode.InternalServerError);
        //    }
        //}


        public async Task<LaramsResponse<List<LeadDto>>> SearchLaramsLeadsAsync(string query)
        {
            using var client = new HttpClient();
            var url = $"http://172.20.5.27/Larms/api/Larms/search?searchQuery={Uri.EscapeDataString(query)}";

            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error calling Larams API: {response.StatusCode}");

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<LaramsResponse<List<LeadDto>>>(json);
        }




    }
}
