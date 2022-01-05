using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using First_Blog.tmp;
using First_Blog.Models;

namespace First_Blog.App_Start
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            Mapper.CreateMap<tmpPost, Post>();
            Mapper.CreateMap<Post, tmpPost>();

        }
    }
}