using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_Project_MVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        newdbEntities nd = new newdbEntities();
        public ActionResult Index()
        {
            var blogsdetails = nd.Blogs.ToList().OrderByDescending(x=>x.Bid);

            return View(blogsdetails);
        }

        public ActionResult UploadBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadBlog(Blog bg)
        {
            nd.Blogs.Add(bg);
            nd.SaveChanges();
            ViewBag.message = "Blog Details Are Saves Successfully...";
            return View();
        }


        public ActionResult Food()
        {
            var foodarticle = nd.Blogs.Where(x => x.BCategory == "Food");
            return View(foodarticle);
        }

        public ActionResult Sports()
        {
            var sportsarticle = nd.Blogs.Where(x => x.BCategory == "Sports");
            return View(sportsarticle);
        }


        public ActionResult Movies()
        {
            var moviesarticle = nd.Blogs.Where(x => x.BCategory == "Movies");
            return View(moviesarticle);
        }

        public ActionResult myfirstblog()
        {
            return View();
        }

    }
}