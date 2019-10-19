using System.Collections.Generic;
using Asp.NetCoreMvc2.Introduction1.Entities;

namespace Asp.NetCoreMvc2.Introduction1
{
    public class employeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}