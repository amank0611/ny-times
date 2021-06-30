using NewYorkTimes.Core.DTOs;
using System.Threading.Tasks;

namespace NewYorkTimes.Core.Interfaces.RestClient
{
    public interface IHttpWebRequestHandler
    {
        Task<ResponseDto> GetClientAsync(string url, string offset, string sort);
    }
}
