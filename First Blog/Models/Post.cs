using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First_Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public category category { get; set; }
        public int categoryid { get; set; }
    }
}