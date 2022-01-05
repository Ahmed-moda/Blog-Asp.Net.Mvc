using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_Blog.tmp;
using First_Blog.Models;
using AutoMapper;
using System.Data.Entity;

namespace First_Blog.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext db;

        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var pos = db.Posts.Include(p=>p.category).ToList();
            List<tmpPost> tmp;
            tmp = Mapper.Map<List<Post>, List<tmpPost>>(pos);

            if (User.IsInRole("Admin"))
            {
                return View("Index", tmp);
            }
            else
                return View("Read",tmp);

        }

        public ActionResult About()
        {

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}