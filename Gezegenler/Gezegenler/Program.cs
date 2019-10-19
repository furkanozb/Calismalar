using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gezegenler
{
    class Program
    {
        static void Main(string[] args)
        {
            MARS mrs = new MARS();
            Console.WriteLine("Adı="+mrs.Adi);
            Console.WriteLine("Sıcaklığı=" + mrs.sicaklik);
            Console.WriteLine("Güneş Etrafında dönme süresi=" + mrs.GEDS);
            Console.WriteLine("Kendi Etrafında dönme süresi=" + mrs.KEDS);
            Console.WriteLine("--------------------------------------");
            Satürn strn = new Satürn();
            Console.WriteLine("Adi= " + strn.Adi);
            Console.WriteLine("Sıcaklığı= " + strn.sicaklik);
            Console.WriteLine("Güneş Etrafında dönme süresi=" + strn.GEDS);
            Console.WriteLine("Kendi Etrafında dönme süresi" + strn.KEDS);

            Console.Read();

        }
    }
}
