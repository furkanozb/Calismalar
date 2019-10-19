using Excel_Raporlama.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Excel_Raporlama.DataContext
{
    public class DataContext:DbContext
    {
        public DbSet<Hastane> Hastane{ get; set; }
    }
}