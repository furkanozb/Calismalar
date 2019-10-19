using MVC_Intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Intermediate.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult KategoriMenu()
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){KategoriId=1,KategoriAd="Telefon"},
                new Kategori(){KategoriId=2,KategoriAd="Tablet"},
                new Kategori(){KategoriId=3,KategoriAd="Laptop"}
            };

            return PartialView("KategoriMenu", kategoriler);
        }
    }
}