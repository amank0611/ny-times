using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NewYorkTimes.Core.DTOs;
using NewYorkTimes.Core.Interfaces.RestClient;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewYorkTimes.Infrastructure.Implementation.RestClient
{
    public class HttpWebRequestHandler : IHttpWebRequestHandler
    {
        private readonly IConfiguration _configuration;
        private string api_key { get; }
        private const string BaseUrl = "https://api.nytimes.com/svc/community/v3/user-content/url.json";
        public HttpWebRequestHandler(IConfiguration configuration)
        {
            _configuration = configuration;
            api_key = "?api-key=" + _configuration["Configurations:API_KEY"];
        }

        public async Task<ResponseDto> GetClientAsync(string url, string offset, string sort)
        {
            ResponseDto responseResult = new ResponseDto();
            try
            {
                string _offset = !string.IsNullOrEmpty(offset) ? "&offset=" + offset : string.Empty;
                string _url = !string.IsNullOrEmpty(url) ? "&url=" + url : string.Empty;
                string _sort = !string.IsNullOrEmpty(sort) ? "&sort=" + sort : string.Empty;
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(BaseUrl + api_key + _url + _offset + _sort))
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            responseResult = JsonConvert.DeserializeObject<ResponseDto>(apiResponse);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // will be handle later with global exception middleware
            }
            return responseResult;
        }
    }
}
