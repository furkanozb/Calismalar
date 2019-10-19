using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Excel_Raporlama.Models
{
    [Table("Hastane")]
    public class Hastane
    {
        
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ID { get; set; }
            [Required,DisplayName("Hasta Adı")]
            public String Ad { get; set; }
            [Required,DisplayName("Hasta Soyadı")]
            public String SoyAd { get; set; }
            [Required,DisplayName("Tc Kimlik No")]
            public String TC { get; set; }
            [Required,DisplayName("Giriş Tarihi")]
            public DateTime GirisTarihi { get; set; }
            [Required,DisplayName("Çıkış Tarihi")]
            public DateTime CikisTarihi { get; set; }
            public double Tutar { get; set; }
    }
}