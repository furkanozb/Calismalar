using Asp.NetCoreMvc2.Introduction1.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetCoreMvc2.Introduction1.TagHelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper:TagHelper
    {
        private List<Employee> _employees;
        public EmployeeListTagHelper()
        {
            _employees = new List<Employee>
            {
                new Employee{Id=1,FirtName="Furkan",LastName="Özbay",CityId=37},
                new Employee{Id=2,FirtName="Göksel",LastName="Kalyon",CityId=2},
                new Employee{Id=3,FirtName="Engin",LastName="Demiroğ",CityId=6}, 
            };
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var query = _employees;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var employee in query)
            {
                stringBuilder.AppendFormat(" <h2><a href='/employee/detail/{0}'>{1}</a></h2>",employee.Id,employee.FirtName);
            }
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output); 
        }
    }
}
