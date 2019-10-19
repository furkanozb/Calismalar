using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _280719_Con_Giris
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ahmet", "Mehmet", "Hasan", "Ayşe" };

            var isimler2 = isimler.Where(i => i.Length>4);
            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }



            //int[] sayilar = { 1, 5, 6, 4, 9, 8, 3 };
            //var sayilar2 = sayilar.Select(i => i + 1);

            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}
            Console.Read();
        }
    }
}
