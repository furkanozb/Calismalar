using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeçaloışmaConsole
{
   public abstract class Gezegen
    {
        public abstract string Ad { get; set; }
        public abstract int Sıcaklık { get; set; }
        public abstract String KCDönüs { get; set; }
        public abstract String GCDönüs { get; set; }

    }
}
