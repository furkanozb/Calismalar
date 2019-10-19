using MVC_Intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            /*veritabanına bağlanır ve bilgileri getirir.
             * getirilen bilgiler bir model içerisine yani bi class
             * içerisine aktarılır ve bu model view'e gönderilir.
             */

            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = Veritabani.Liste.Where(i => i.Satistami == true).Count();
            model.Urunler = Veritabani.Liste.Where(i=>i.Satistami==true).ToList();

            //ViewBag.UrunSayisi = urunler.Count();
            //ViewBag.Kategoriler = kategoriler;

            return View(model);
        }
        public ActionResult Details(int Id)
        {

            var urun= Veritabani.Liste.Where(i => i.UrunId == Id).FirstOrDefault();
            return View(urun);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun entity)
        {

            Veritabani.ElemanEkle(entity);

            return View("UrunListe", Veritabani.Liste);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}