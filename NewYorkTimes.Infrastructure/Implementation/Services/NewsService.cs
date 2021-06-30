using NewYorkTimes.Core.Helpers;
using NewYorkTimes.Core.Interfaces.RestClient;
using NewYorkTimes.Core.Interfaces.Services;
using NewYorkTimes.Infrastructure.Implementation.RestClient;
using System.Threading.Tasks;

namespace NewYorkTimes.Infrastructure.Implementation.Services
{
    public class NewsService : INewsService
    {
        private readonly IHttpWebRequestHandler _httpWebRequestHandler;
        public NewsService(IHttpWebRequestHandler httpWebRequestHandler)
        {
            _httpWebRequestHandler = httpWebRequestHandler;
        }

        public async Task<ApiResponse> GetNews(string url, string offset, string sort)
        {
            ApiResponse resp = new ApiResponse();

            var response = await _httpWebRequestHandler.GetClientAsync(url, offset, sort);
            if (response.status == "OK")
            {
                resp.success = new Success
                {
                    Code = 200,
                    Data = response,
                    Status = response.status
                };
            }
            else
            {
                return null;
            }
            return resp;
        }
    }
}
