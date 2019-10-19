using BlogMvcProc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcProc.Context
{
    public class DataContext:DbContext
    {
        public DbSet<Housing> evler { get; set; }
        public DbSet<Partners> emlakcilar { get; set; }
    }
}