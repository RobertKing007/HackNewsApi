using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HackerNews_API.Models;
using Newtonsoft.Json;

namespace HackerNews_API.Services
{
    public class HackerNewsService : IHackerNewsService
    {
        private readonly IHackerNewsService _hackerNewsService;
        private string hackerNewsuri = "https://hacker-news.firebaseio.com/v0/";
        private string hackerNewsGetById = "item/";
        private string hackerNewsTopStories  = "topstories";

        public HackerNewsService (IHackerNewsService hackerNewsService)
        {
            _hackerNewsService = hackerNewsService;
        }

        public async Task<Story> GetStoryById(int id)
        {
            //hit hackernew api here
            Story story = new Story();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(hackerNewsuri + hackerNewsGetById + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    story = JsonConvert.DeserializeObject<Story>(apiResponse);
                }
            }

            return story;
        }

        public async Task<IEnumerable<string>> GetTopStories()
        {
            //hit hackernew api here
            List<string> storyList = new List<string>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(hackerNewsuri + hackerNewsTopStories))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    storyList = JsonConvert.DeserializeObject<List<string>>(apiResponse);
                }
            }

            return storyList;

        }
    }
}
