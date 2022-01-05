using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_Blog.tmp;
using System.Data.Entity;
using First_Blog.Models;
using AutoMapper;

namespace First_Blog.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        private ApplicationDbContext db;

        public PostsController()
        {
            db = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(String text)
        {
            List<category> tes = db.category.Where(c => c.Name == text).ToList();
            int id = tes[0].Id;

            List<Post> lis;
            lis = db.Posts.Where(c => c.categoryid == id).ToList();
            List<tmpPost> tmplist;
            tmplist = Mapper.Map<List<Post>, List<tmpPost>>(lis);
            return View(tmplist);
        }


        public ActionResult Create_post()
        {

            var crea = new catApost
            {
                post = new tmpPost(),
                categories = db.category.ToList()
            };

            return View(crea);
        }
        public ActionResult Create_cat()
        {
            return View();
        }
        public ActionResult Save_cat(category cat)
        {
            if (!ModelState.IsValid)
            {
                return View("Create_cat", cat);
            }
            else
            {
                db.category.Add(cat);
                db.SaveChanges();
                return RedirectToAction("index", "Home");
                
            }
        }

        public ActionResult Update(int id)
        {
            var tmp = db.Posts.SingleOrDefault(p => p.Id == id);
            if (tmp == null)
                return HttpNotFound();
            var tp = new catApost
            {
                post = Mapper.Map<Post,tmpPost>(tmp),
                categories = db.category.ToList()
            };
            return View(tp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save_U(catApost tmp)
        {
            if (!ModelState.IsValid)
            {
                return View("Update", tmp);
            }
            else
            {
                var cus = db.Posts.Single(p => p.Id == tmp.post.Id);
                cus.content = tmp.post.content;
                cus.title = tmp.post.title;
                cus.categoryid = tmp.post.categoryid;
                
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Details(int id)
        {
            var tmp = db.Posts.Include(p=>p.category).Where(p => p.Id == id).SingleOrDefault();
            tmpPost pos = Mapper.Map<Post, tmpPost>(tmp);
            return View(pos);
        }


    }
}