﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HackerNews_API.Models
{
    public class Story
    {
        public string by { get; set; }
        public int descendants { get; set; }
        public int id { get; set; }
        public Array kids { get; set; }
        public int score { get; set; }
        public int time { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }








    }
}
