using AsuApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AsuApp.Controllers
{
    public class HomeController : Controller
    {
        DataContext.DataContext db = new DataContext.DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Team()
        {
            List<UyeModel> uye = db.uyeModel.ToList();
            return View(uye);
        }
        public ActionResult register()
        {
            return View();
        }
        public ActionResult VerileriGoster()
        {
            return View();
        }

        /*public ActionResult VerileriGoster()
        {
            string dosyadi = "uyeler.xls";
            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1'>");
            sb.Append("<tr><th style='text-align: center;padding 18px; font-size:25px; font-weight:bold;' colspan='6'>Hastalar Tablosu</th></tr>");
            sb.Append("<tr>");
            sb.Append("<th style='background-color:red;color:green'>ID</th>");
            sb.Append("<th style='background-color:red;color:green'>Adı</th>");
            sb.Append("<th style='background-color:red;color:green'>Soyadı</th>");
            sb.Append("<th style='background-color:red;color:green'>Okul Numarası</th>");
            sb.Append("<th style='background-color:red;color:green'>Bölümü</th>");
            sb.Append("</tr>");

            List<UyeModel> uyeler = db.uyeModel.ToList();
            foreach (UyeModel item in uyeler)
            {
                sb.Append("<tr>");
                sb.Append("<td>" + item.Id + "</td>");
                sb.Append("<td>" + item.Name + "</td>");
                sb.Append("<td>" + item.LastName + "</td>");
                sb.Append("<td>" + item.UniversityNumber + "</td>");
                sb.Append("<td>" + item.branch + "</td>");
                
            }
            sb.Append("</tr>");
            sb.Append("</table>");
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=" + dosyadi);
            Response.ContentEncoding = Encoding.GetEncoding("ISO-8859-9");
            Response.Charset = "ISO-8859-9";
            Response.ContentType = "application/vnd.ms-excel";
            Response.Output.Write(sb.ToString());
            Response.Flush();
            Response.End();
            return View();
        }*/

        [HttpPost]
        public ActionResult register(UyeModel model)
        {
            db.uyeModel.Add(model);
            db.SaveChanges();
            return RedirectToAction("Team");
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult VeriSil(int id)
        {
            StringBuilder sb = new StringBuilder();
            UyeModel veri = db.uyeModel.Where(x => x.Id == id).FirstOrDefault();
            db.uyeModel.Remove(veri);
            db.SaveChanges();
            return RedirectToAction("Team");
        }
    }
}