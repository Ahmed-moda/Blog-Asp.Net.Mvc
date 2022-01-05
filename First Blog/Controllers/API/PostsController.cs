using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using First_Blog.Models;
using First_Blog.tmp;
using AutoMapper;

namespace First_Blog.Controllers.API
{
    public class PostsController : ApiController
    {

        private ApplicationDbContext db;

        public PostsController()
        {
            db = new ApplicationDbContext();
        }



        [HttpPost]
        public IHttpActionResult Create(tmpPost t)
        {

            var pos = Mapper.Map<tmpPost, Post>(t);
            db.Posts.Add(pos);
            db.SaveChanges();

            return Ok();

        }

        [HttpGet]
        public IHttpActionResult get_posts(string text){

            List<category> tes = db.category.Where(c => c.Name == text).ToList();
            int id = tes[0].Id;

            List<Post> lis;
            lis = db.Posts.Where(c => c.categoryid== id).ToList();
            List<tmpPost> tmplist;
            tmplist=Mapper.Map<List<Post>, List<tmpPost>>(lis);
                return Ok(tmplist);

        }

        [HttpGet]
        public IHttpActionResult get_cat()
        {

            List<category> cat = db.category.ToList();

            return Ok(cat);

        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var post = db.Posts.SingleOrDefault(p => p.Id == id);

            if (post == null)
                return NotFound();
            db.Posts.Remove(post);
            db.SaveChanges();

            return Ok();

        }

    }
}
