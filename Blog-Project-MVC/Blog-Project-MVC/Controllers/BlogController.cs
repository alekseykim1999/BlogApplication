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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UploadBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadBlog(Blog bg)
        {


            newdbEntities nd = new newdbEntities();
            nd.Blogs.Add(bg);
            nd.SaveChanges();
            ViewBag.message = "Blog Details Are Saves Successfully...";
            return View();
        }
    }
}