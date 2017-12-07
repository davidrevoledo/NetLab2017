using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica1.Filters;

namespace Practica1.Controllers
{
    /* 1)
     *  - Crear un sitio que cuente la cantidad de veces
     *    que se entro a la aplicacion en general.
          Mostrar en el footer
     */


    //2 - Crear una pantalla donde se pida un input
    //con el nombre de la persona y un boton y vaya a otra pantalla y aparezca el mensaje
    //Bienvenido X(Nombre de la persona)

    /* 3) - El nombre que se ingreso mostrarlo en el header a la derecha en todas las pantallas
     *    - Si el usuario no ingreso el nombre, no permitirle el ingreso a ninguna otra pantalla
     *      Si trata de ir a otra pantalla se redirigir a la pantalla de ingreso de nombre.
     */

    /*
     * 4) Mostrar un contador en el footer de cantidad de
     *    visitantes (diferenciados por session)
     *    Agregar el menu logout para permitir volver a ingresar el nombre de usuario
     *    El color del boton del login debe ser del color del menu
     */

    /*
        5) 
        Mostrar una pantalla con un listado de todas las personas
        que ingresaron al sitio. (no repetidas)
        Agregar al menu.
        (Puede ser en memoria)
        */

    [Contador]
    public class HomeController : Controller
    {
        [Auth]
        public ActionResult Index()
        {
            return View();
        }

        [Auth]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        [Auth]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginResult(string nombre)
        {
            HttpContext.Session["user"] = nombre;
            ViewBag.nombre = nombre;
            return View();
        }
    }
}