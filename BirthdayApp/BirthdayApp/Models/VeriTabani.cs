using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class VeriTabani
    {
        private static Dictionary<string, Davetiye> _liste;

        static VeriTabani()
        {
            _liste = new Dictionary<string, Davetiye>();

            _liste.Add("Enver",new Davetiye
                {
                Ad_Soyad="Enver Paşa",Eposta="enverpasa1@gmail.com",
                KatilmaDurumu=true
            });
            _liste.Add("Fuat", new Davetiye
            {
                Ad_Soyad = "Fuat Atıf Tufa",
                Eposta = "fuu@gmail.com",
                KatilmaDurumu = false
            });
            _liste.Add("ibrahim", new Davetiye
            {
                Ad_Soyad = "İbrahim Kurban",
                Eposta = "ibrahkurban1@gmail.com",
                KatilmaDurumu = true
            });
        }
        public static void Add(Davetiye model)
        {
            string key = model.Ad_Soyad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }

        public static IEnumerable<Davetiye> Liste
        {
            get { return _liste.Values; }
        }

    }
}