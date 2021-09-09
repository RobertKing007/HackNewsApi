using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HackerNews_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace HackerNews_API.Controllers
{
    [Route("api/[controller]")]
    public class HackerNewController : Controller
    {
        private readonly IHackerNewsService _hackerNewsService;
        public HackerNewController(IHackerNewsService hackerNewsService)
        {
            _hackerNewsService = hackerNewsService;
        }

        public static HttpClient ApiClient { get; set; } = new HttpClient();

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("apllication/json"));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStoryById(int id)
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetTopStories()
        {

        }
    }
}
