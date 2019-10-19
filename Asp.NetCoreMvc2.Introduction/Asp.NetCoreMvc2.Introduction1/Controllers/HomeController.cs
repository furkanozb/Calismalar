using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCoreMvc2.Introduction1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMvc2.Introduction1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello From First Application";
        }

        public ViewResult Index2()
        {
            return View();
        }

        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirtName="Furkan",LastName="Özbay",CityId=37},
                new Employee{Id=2,FirtName="Göksel",LastName="Kalyon",CityId=2},
                new Employee{Id=3,FirtName="Engin",LastName="Demiroğ",CityId=6},
            };

            List<string> cities = new List<string> { "İstanbul","Ankara","İzmir","Kastamonu" };

            var model = new employeeListViewModel
            {
                Employees=employees,
                Cities=cities,
            };
            return View(model);
        }

        public IActionResult Index4()
        {
            return StatusCode(200);

        }
        public IActionResult Index5()
        {
            return StatusCode(400);

        }
        //redirect verince url istiyor **Redirect:bir aksiyon sonucu başka aksiyon tetiklemeye yarar.
        public RedirectResult Index6()
        {
            return Redirect("/Home/Index3");
        }

        //RedirectToAction:hangi aksiyona gidiyeceğini verebirliroyurz.
        public ActionResult Index7()
        {
            return RedirectToAction("Index2");
        }

        //RedirectToRoute:startupda routenin nameine göre yönlendirmeye yarar.
        public ActionResult Index8()
        {
            return RedirectToRoute("default");
        }

        public JsonResult Index9()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirtName="Furkan",LastName="Özbay",CityId=37},
                new Employee{Id=2,FirtName="Göksel",LastName="Kalyon",CityId=2},
                new Employee{Id=3,FirtName="Engin",LastName="Demiroğ",CityId=6},
            };
            return Json(employees);
        }
        public IActionResult RazorDemo()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirtName="Furkan",LastName="Özbay",CityId=37},
                new Employee{Id=2,FirtName="Göksel",LastName="Kalyon",CityId=2},
                new Employee{Id=3,FirtName="Engin",LastName="Demiroğ",CityId=6},
            };

            List<string> cities = new List<string> { "İstanbul", "Ankara", "İzmir", "Kastamonu" };

            var model = new employeeListViewModel
            {
                Employees = employees,
                Cities = cities,
            };
            return View(model);
        }

        public JsonResult Index10(string key)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirtName="Furkan",LastName="Özbay",CityId=37},
                new Employee{Id=2,FirtName="Göksel",LastName="Kalyon",CityId=2},
                new Employee{Id=3,FirtName="Engin",LastName="Demiroğ",CityId=6},
            };
            if (string.IsNullOrEmpty(key))
            {
                return Json(employees);
            }

            var result = employees.Where(e => e.FirtName.ToLower().Contains(key));
            return Json(result);
        }
        public ViewResult EmployeeForm()
        {
            return View();
        }
        public string RouteData(int Id)
        {
            return Id.ToString();
        }
    }
}