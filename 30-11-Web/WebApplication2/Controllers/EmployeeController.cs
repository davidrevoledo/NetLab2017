using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "David"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Cesar"
                }
            };

            ViewBag.Title = "Sistemas";
            ViewData["SubTitle"] = "Net Devs";

            return View(employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            // 
            return View();
        }
    }
}