using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        /*
         * 
            1 - Crear una clase persona
                con Nombre requerido max 50,
                    Apellido requerido max 50, 
                    Edad (no puede ser menor a 13)

            2 - Crear un formulario de MVC Para crear una persona
                Usar Html (No razor)

            3 - Validar antes de enviar el formulario que el nombre no sea = al apellido
         * 
         */
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Person person)
        {
            if (ModelState.IsValid)
            {
                // create person
            }

            return View();
        }

        public ActionResult Calculadora()
        {
            return View();
        }

        public ActionResult JQuery()
        {
            return View();
        }
    }
}