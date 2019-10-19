using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMvc2.Introduction1.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name ="First Name")]
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
    }
}
