using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsuApp.Models
{
    public class UyeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UniversityNumber { get; set; }
        public string branch { get; set; }
        public bool Günceluyemi { get; set; }
    }
}