using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcProc.Models
{
    public class Partners
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public virtual List<Housing> konutlar { get; set; }

    }
}