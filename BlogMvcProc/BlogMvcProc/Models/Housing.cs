using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMvcProc.Models
{
    public class Housing
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public decimal Fiyat { get; set; }
        public string Aciklama { get; set; }
        public int Boyut { get; set; }
        public int OdaSayisi { get; set; }
        public bool Garajli { get; set; }
        public virtual Partners EmlakciId { get; set; }
        public string Links { get; set; }
    }
}