using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthdayApp.Controllers
{
    public class DavetiyeController : ApiController
    {
        [HttpGet]
        public IEnumerable<Davetiye> Katilanlar()
        {
            return VeriTabani.Liste.Where(i => i.KatilmaDurumu == true);
        }

        [HttpGet]
        public IEnumerable<Davetiye> Katilmayanlar()
        {
            return VeriTabani.Liste.Where(i => i.KatilmaDurumu == false);
        }

        [HttpPost]
        public void Ekle(Davetiye model)
        {
            if (ModelState.IsValid)
            {
                VeriTabani.Add(model);
            }
        }
    }
}
