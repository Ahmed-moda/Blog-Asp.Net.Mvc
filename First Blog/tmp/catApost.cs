using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using First_Blog.Models;

namespace First_Blog.tmp
{
    public class catApost
    {
        public List<category> categories { get; set; }
        public tmpPost post { get; set; }
    }
}