﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntituFrameworkSamples
{
    public class UrunContext:DbContext
    {
        public UrunContext():base("urunConnection")
        {

        }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
