using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RubyNonlife.Application.Helper.UtitlityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public class RubyNonLifeClient
    {
        private readonly ILogger<RubyNonLifeClient> _logger;
        private readonly IMemoryCache _cache;
        private readonly IOptions<ConfigModels> _options;
        public RubyNonLifeClient(ILogger<RubyNonLifeClient> logger, IMemoryCache cache, IOptions<ConfigModels> options)
        {
            _logger = logger;
            _cache = cache;
            _options = options;
        }
        // Auto Refresh Token Implemented
        public async Task<HttpResponseMessage> PostAsync<T>(T model, ApiUrlEnum name, string referenceUrl, List<KeyValuePair<string, string>> headers = null)
        {
            var retryCount = 0;
            while (retryCount < 2)
            {
                var apiInfo = _options.Value.ApiUrls.FirstOrDefault(x => x.Name.Equals(name));
                if (apiInfo == null) return null;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                ServicePointManager.ServerCertificateValidationCallback +=
         (sender, cert, chain, sslPolicyErrors) => { return true; };
                using var client = new HttpClient();
                StringContent content;
                client.BaseAddress = new Uri(apiInfo.BaseUrl);
                if (headers != null)
                {
                    headers.ForEach(h => { client.DefaultRequestHeaders.Add(h.Key, h.Value); });
                }

                var jsonObject = string.Empty;
                if (model != null)
                {
                    jsonObject = JsonConvert.SerializeObject(model);
                }
                content = new StringContent(jsonObject, Encoding.UTF8, "application/json");

                var request = await client.PostAsync(referenceUrl, content);
                if (request != null)
                {
                    if (request.StatusCode == HttpStatusCode.Unauthorized && !string.IsNullOrEmpty(apiInfo.TokenCacheName))
                    {
                        //await RefreshToken(name);
                        headers.RemoveAll(x => x.Key.Equals("Authorization"));
                        headers.Add(new KeyValuePair<string, string>("Authorization", $"Bearer {_cache.Get<string>(apiInfo.TokenCacheName)}"));
                        retryCount = retryCount++;
                        continue;
                    }

                    var jsonData = model != null ? JsonConvert.SerializeObject(model) : string.Empty;
                    var response = await request.Content.ReadAsStringAsync();
                    _logger.LogInformation($"Http Post Request Url : {apiInfo.BaseUrl}{referenceUrl}, RequestData : {jsonData}, Response Data : {response} ");
                }
                return request;

            }
            return null;
        }


        //private async Task RefreshToken(ApiUrlEnum name)
        //{
        //    switch (name)
        //    {
        //        case ApiUrlEnum.Admin:
        //            await GetAdminToken();
        //            break;
        //        default:
        //            break;
        //    }

        //}

        //protected async Task<string> GetAdminToken()
        //{
        //    var apiInfo = _options.Value.ApiUrls.FirstOrDefault(x => x.Name == ApiUrlEnum.Admin);
        //    if (_cache.TryGetValue(apiInfo.TokenCacheName, out var cachedToken))
        //    {
        //        _logger.LogInformation($"Cached token value: {cachedToken.ToString()}");
        //        return cachedToken.ToString();
        //    }
        //    var url = "/api/connect/token";
        //    using var client = new HttpClient();
        //    client.BaseAddress = new Uri(_options.Value.RubyAdminUrl);
        //    var data = new List<KeyValuePair<string, string>>();
        //    data.Add(new KeyValuePair<string, string>("username", apiInfo.Username));
        //    data.Add(new KeyValuePair<string, string>("password", apiInfo.Password));
        //    data.Add(new KeyValuePair<string, string>("grant_type", "password"));
        //    var content = new FormUrlEncodedContent(data);
        //    var response = await client.PostAsync(url, content);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var loginResponse = await response.Content.ReadAsStringAsync();
        //        var token = JsonConvert.DeserializeObject<AdminLoginResponse>(loginResponse);
        //        _cache.Set(apiInfo.TokenCacheName, token.AccessToken, DateTimeOffset.UtcNow.AddMinutes(token.ExpiresIn - 100));
        //        return token.AccessToken;
        //    }
        //    return null;
        //}

    }
}
