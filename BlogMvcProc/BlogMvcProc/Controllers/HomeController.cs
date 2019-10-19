using BlogMvcProc.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcProc.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        BlogController 
        // GET: Home
        public ActionResult Index()
        {
            new 
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}