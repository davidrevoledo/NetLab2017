using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica1.Filters;

namespace Practica1.Controllers
{
    /*
     *  - Crear un sitio que cuente la cantidad de veces
     *    que se entro a la aplicacion en general.
          Mostrar en el footer
     */
    [Contador]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

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