using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFilters.Filters;

namespace MvcFilters.Controllers
{
    [Cookie]
    [AuthFilter]
    public class HomeController : Controller
    {
        private int contador = 1;

        [Cookie]
        [ActionFilter2]
        public ActionResult Index()
        {
            HttpContext.Application["name"] = 1;

            var b = int.Parse(HttpContext.Application["name"].ToString());

            var a = 1; // DB call

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}