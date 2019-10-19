using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public class Davetiye
    {
        [Required]
        public string Ad_Soyad { get; set; }
    public string Eposta { get; set; }
    public bool KatilmaDurumu { get; set; }
}
}