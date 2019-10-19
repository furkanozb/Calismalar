
using AsuApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AsuApp.DataContext
{
    public class DataContext : DbContext
    {
        public DbSet<UyeModel> uyeModel { get; set; }
    }
}
