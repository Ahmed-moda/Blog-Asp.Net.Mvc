using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using First_Blog.Models;
using System.ComponentModel.DataAnnotations;

namespace First_Blog.tmp
{
    public class tmpPost
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Title Of Post")]
        public string title { get; set; }
        [Display(Name = "Content Of The Post")]
        public string content { get; set; }
        public category category { get; set; }
        [Display(Name = "Categories")]
        public int categoryid { get; set; }
    }
}