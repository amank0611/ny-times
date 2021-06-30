using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewYorkTimes.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewYorkTimes.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;
        private readonly ILogger<NewsController> _logger;

        public NewsController(ILogger<NewsController> logger, INewsService newsService)
        {
            _logger = logger;
            _newsService = newsService;
        }
        [HttpGet]
        [Route("GetNews/{url}/{offset}/{sort}")]
        public async Task<IActionResult> GetNews(string url, string offset, string sort)
        {
           return Ok(await _newsService.GetNews(url,offset,sort));
        }
    }
}
