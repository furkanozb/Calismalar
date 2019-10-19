using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntituFrameworkSamples
{
    class Program
    {   
        static void Main(string[] args)
        {
            Kategori k1 = new Kategori();
            k1.KategoriAdi = "telefon";

            UrunContext db = new UrunContext();
            db.Kategoriler.Add(k1);
            db.SaveChanges();

            Console.WriteLine("Database oluşturuldu");
            Console.ReadLine();
            
        }
    }
}
