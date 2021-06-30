using NewYorkTimes.Core.Helpers;
using System.Threading.Tasks;

namespace NewYorkTimes.Core.Interfaces.Services
{
    public interface INewsService
    {
        Task<ApiResponse> GetNews(string url, string offset, string sort);
    }
}
