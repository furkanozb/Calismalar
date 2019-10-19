using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Intermediate.Models
{
    public static class Veritabani
    {
        private static List<Urun> _liste;

        static Veritabani()
        {
            _liste = new List<Urun> {
                 new Urun(){UrunId=1,UrunAdi="Samsung s6",Aciklama="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",Fiyat=1000,Satistami=true},
                 new Urun(){UrunId=2,UrunAdi="Samsung s7",Aciklama="idare eder",Fiyat=1000,Resim="~/img/client-1.png",Satistami=false},
                 new Urun(){UrunId=3,UrunAdi="Samsung s8",Aciklama="idare eder",Fiyat=2000,Resim="~/img/client-2.png",Satistami=true},
                 new Urun(){UrunId=4,UrunAdi="Samsung s9",Aciklama="idare eder",Fiyat=3000,Resim="~/img/client-3.png",Satistami=true},
                 new Urun(){UrunId=5,UrunAdi="Iphone 6",Aciklama="idare eder",Fiyat=3000,Resim="~/img/client-4.png",Satistami=true},
                 new Urun(){UrunId=6,UrunAdi="Iphone 7s",Aciklama="idare eder",Fiyat=3000,Resim="~/img/client-5.png",Satistami=false},
                 new Urun(){UrunId=7,UrunAdi="Iphone 8s",Aciklama="idare eder",Fiyat=3000,Resim="~/img/client-6.png",Satistami=true},
                 new Urun(){UrunId=8,UrunAdi="Iphone 9s",Aciklama="idare eder",Fiyat=3000,Resim="~/img/monster.png",Satistami=true},
                 new Urun(){UrunId=9,UrunAdi="Xiaomi Note8",Aciklama="idare eder",Fiyat=3000,Resim="~/img/post1.png",Satistami=true},
                 };
            }
        public static List<Urun> Liste
        {
            get { return _liste; }
        }

        public static void ElemanEkle(Urun entity)
        {
            _liste.Add(entity);
        }
        public static Urun UrunDetay(int UrunId)
        {
            Urun entity = null;
            foreach (var urun in _liste)
            {
                if (urun.UrunId== UrunId)
                {
                    entity = urun;
                }
            }
            return entity;
        }
    }
}