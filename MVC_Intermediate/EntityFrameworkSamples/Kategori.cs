﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public List<Urun> Urunler { get; set; }

    }
}
