using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeçaloışmaConsole
{
    public class Mars : Gezegen
    {
        public override string Ad { get => return "Mars"; }
        public override int Sıcaklık { get => throw new NotImplementedException(); }
        public override string KCDönüs { get => throw new NotImplementedException();  }
        public override string GCDönüs { get => throw new NotImplementedException(); }
        
    }
}
