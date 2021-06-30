using Microsoft.Extensions.DependencyInjection;
using NewYorkTimes.Core.Interfaces.Repositories;
using NewYorkTimes.Core.Interfaces.RestClient;
using NewYorkTimes.Core.Interfaces.Services;
using NewYorkTimes.Infrastructure.Implementation.Repositories;
using NewYorkTimes.Infrastructure.Implementation.RestClient;
using NewYorkTimes.Infrastructure.Implementation.Services;

namespace NewYorkTimes.WebApi.Helpers
{
    public class ServiceInjectionHelper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<INewsRepository, NewsRepository>();
        }
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<INewsService, NewsService>();
        }
        public static void RegisterRestClients(IServiceCollection services)
        {
            services.AddTransient<IHttpWebRequestHandler, HttpWebRequestHandler>();
        }
    }
}
