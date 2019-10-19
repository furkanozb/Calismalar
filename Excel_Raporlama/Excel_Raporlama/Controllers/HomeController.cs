using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Excel_Raporlama.DataContext;
using Excel_Raporlama.Models;

namespace Excel_Raporlama.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DataContext.DataContext db = new DataContext.DataContext();
            //db.Hastane.Where(x => x.Ad.Contains("Emre")).ToList();
            //db.Hastane.Add(new Models.Hastane {Ad="Emre",SoyAd="Kirman",TC="12345678901",Tutar=25.0,CikisTarihi=DateTime.Now,GirisTarihi=new DateTime(2019,04,23)});
            //db.SaveChanges();
            //Hastane h1 = db.Hastane.FirstOrDefault();
            List<Hastane> hastalar = db.Hastane.ToList();
            return View(hastalar);
        }

        public ActionResult VerileriGoster()
        {
            string dosyaAdi = "hastalar Listesi.xls";
            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1'>");
            sb.Append("<tr><th style='text-align: center;padding 18px; font-size:25px; font-weight:bold;' colspan='6'>Hastalar Tablosu</th></tr>");
            sb.Append("<tr>");
            sb.Append("<th style='background-color:red;color:green'>ID</th>");
            sb.Append("<th style='background-color:red;color:green'>Adı</th>");
            sb.Append("<th style='background-color:red;color:green'>Soyadı</th>");
            sb.Append("<th style='background-color:red;color:green'>TC</th>");
            sb.Append("<th style='background-color:red;color:green'>Kaldığı Gün Sayısı</th>");
            sb.Append("<th style='background-color:red;color:green'>Tutar</th>");
            
            sb.Append("</tr>");
            DataContext.DataContext db = new DataContext.DataContext();
            List<Hastane> Hastalar = db.Hastane.ToList();
            double top = 0;
            foreach (Hastane item in Hastalar)
            {
                sb.Append("<tr>");
                sb.Append("<td>" + item.ID + "</td>");
                sb.Append("<td>" + item.Ad + "</td>");
                sb.Append("<td>" + item.SoyAd + "</td>");
                sb.Append("<td>" + item.TC + "</td>");
                sb.Append("<td>" + (item.CikisTarihi - item.GirisTarihi).ToString("dd") + "</td>");
                sb.Append("<td>" + item.Tutar + "</td>");
             
                top = top + item.Tutar;
                sb.Append("</tr>");
            }
            sb.Append("<tr>");
            sb.Append("<td> Toplam Tutar:"+top+"</td>");
            sb.Append("</tr>");
            sb.Append("</table>");
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=" + dosyaAdi);
            Response.ContentEncoding = Encoding.GetEncoding("ISO-8859-9");
            Response.Charset = "ISO-8859-9";
            Response.ContentType = "application/vnd.ms-excel";
            Response.Output.Write(sb.ToString());
            Response.Flush();
            Response.End();
            return View();
        }

        public ActionResult HastaEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HastaEkle(Hastane model )
        {
            DataContext.DataContext db = new DataContext.DataContext();
            model.Tutar = int.Parse((model.CikisTarihi - model.GirisTarihi).ToString("dd")) * 150;
            db.Hastane.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult VeriSil(int siraNo)
        {
            DataContext.DataContext db = new DataContext.DataContext();
            Hastane veri = db.Hastane.Where(x => x.ID == siraNo).FirstOrDefault();
            db.Hastane.Remove(veri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}