﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace First_Blog.Models
{
    public class category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}