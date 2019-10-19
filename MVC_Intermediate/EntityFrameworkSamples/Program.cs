using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region veri ekleme-1
            //Urun urun = new Urun();
            //urun.UrunAdi = "Samsung s4";
            //urun.Fiyat = 2000;
            //urun.StokAdeti = 100;
            //urun.Satistami = true;

            //UrunContext context = new UrunContext();
            //context.Urunler.Add(urun);

            //urun = new Urun();
            //urun.UrunAdi = "Samsung s7";
            //urun.Fiyat = 3000;
            //urun.StokAdeti = 200;
            //urun.Satistami = false;

            //context.Urunler.Add(urun);

            //context.SaveChanges();

            //Console.WriteLine("Ürünler eklendi");
            #endregion
            #region veri ekleme-2
            //UrunContext context = new UrunContext();
            //Urun urun = new Urun();
            //List<Urun> urunler = new List<Urun>()
            //{
            //    new Urun(){UrunAdi="soNY XPERİA Z5",Fiyat=1450,StokAdeti=150,Satistami=true },
            //    new Urun(){UrunAdi="Xiaomi mi not5",Fiyat=1450,StokAdeti=150,Satistami=true },
            //    new Urun(){UrunAdi="Xiaomi mi not6",Fiyat=1450,StokAdeti=150,Satistami=true },
            //    new Urun(){UrunAdi="Xiaomi mi not7",Fiyat=1450,StokAdeti=150,Satistami=true },
            //    new Urun(){UrunAdi="Xiaomi mi not8",Fiyat=1450,StokAdeti=150,Satistami=true },
            //};

            //foreach (var item in urunler)
            //{
            //    context.Urunler.Add(item);
            //}
            //context.SaveChanges();
            //Console.WriteLine("İşlem başarılı");
            #endregion
            #region listeleme
            //UrunContext context = new UrunContext();

            //List<Kategori> kategoriler = context.Kategoriler.ToList();
            ////alternatif: var kategoris = context.Kategoriler.ToList();

            //foreach (var item in kategoriler)
            //{
            //    Console.WriteLine("Kategori Id:{0} -- Kategori Adı:{1}",item.Id,item.KategoriAdi);
            //}
            //Console.WriteLine("---------------------");

            //var urunler = context.Urunler.ToList();

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine("Urun Adı:{0} - Urun Fiyatı:{1} - Urun Stok Adet:{2}",item.UrunAdi,item.Fiyat,item.StokAdeti);
            //}

            //var urun = context.Urunler.Find(2);

            //Console.WriteLine("Urun Id:{3} Urun Adı:{0} - Urun Fiyatı:{1} - Urun Stok Adet:{2}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti,urun.Id);
            #endregion
            #region Ürünü bulup güncelleme
            //UrunContext context = new UrunContext();

            //var urun = context.Urunler.Find(1);
            //Console.WriteLine("Urun Id:{0}-Urun Adi:{1} - Urun Fiyat:{2}",urun.Id,urun.UrunAdi,urun.Fiyat);

            //urun.Fiyat = urun.Fiyat +250 ;
            //urun.UrunAdi="Samsung s3";
            //urun.StokAdeti += 100;
            //context.SaveChanges();

            //urun = context.Urunler.Find(1);
            //Console.WriteLine("Urun Id:{0}-Urun Adi:{1} - Urun Fiyat:{2}", urun.Id, urun.UrunAdi, urun.Fiyat);
            #endregion
            #region Ürünlerin fiyatlarını güncelleme
            //UrunContext context = new UrunContext();
            //var urunler = context.Urunler.ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("Fiyat:{0}", urun.Fiyat);
            //}

            //foreach (var urun in urunler)
            //{
            //    urun.Fiyat *= 0.75;
            //}
            //context.SaveChanges();
            //Console.WriteLine("_________________");

            //urunler = context.Urunler.ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("Fiyat:{0}",urun.Fiyat);
            //}
            #endregion  

            UrunContext db = new UrunContext();
            var urun = db.Urunler.Find(2 );

            foreach (var item in db.Urunler)
            {
                Console.WriteLine("urun id:{0} - Urun Adi:{1}", item.Id, item.UrunAdi);
            }

            if (urun!=null)
            {
                db.Urunler.Remove(urun);
            }
            db.SaveChanges();

            foreach (var item in db.Urunler)
            {
                Console.WriteLine("urun id:{0} - Urun Adi:{1}",item.Id,item.UrunAdi );
            }

            Console.ReadLine();
        }
    }
}
