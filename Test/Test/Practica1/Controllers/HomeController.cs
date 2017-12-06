using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.Controllers
{
    /*
     *  - Crear un sitio que cuente la cantidad de veces
     *    que se entro a la aplicacion en general.
          Mostrar en el footer
     */
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var count = 1;

            if (HttpContext.Application["count"] == null)
            {
                HttpContext.Application["count"] = count;
            }
            else
            {
                count = int.Parse(HttpContext.Application["count"].ToString()) + 1;
                HttpContext.Application["count"] = count;
            }

            ViewBag.Count = count;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}