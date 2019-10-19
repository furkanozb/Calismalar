using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gezegenler
{
    public class MARS : Gezegenler
    {
        public override string Adi
        {
            get
            {
                return "Mars";
            }
        }

        public override string GEDS
        {
            get
            {
                return "687 gün";
            }
        }

        public override string KEDS
        {
            get
            {
                return "24 saat 37 dakika";
            }
        }

        public override string sicaklik
        {
            get
            {
                return "-80° C ile -160° C derece";
            }
        }
    }
}

