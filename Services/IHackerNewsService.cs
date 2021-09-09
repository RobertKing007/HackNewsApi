using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews_API.Models;

namespace HackerNews_API.Services
{
    public interface IHackerNewsService
    {
        Task<IEnumerable<Story>> GetTopStories();
        Task<IEnumerable<Story>> GetStoryById(int id);

    }
}