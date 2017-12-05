using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace MvcState.Controllers
{
    public class HomeController : Controller
    {
        public bool sLoged = false;

        public ActionResult Index()
        {
            var example = Request.Cookies["example"].Value;
            var label = Session["session-test"].ToString();
            var cookie = (HttpCookie)Session["COOKIE"];

            // application level
            HttpContext.Application.Add("page-count", 1);

            // request level
            HttpContext.Items.Add("page-count", 1);

            return View();
        }

        //[HttpGet]
        //public ActionResult Logout()
        //{
        //    Session.Clear();

        //    Session.remo
        //    return View();
        //}

        [HttpGet]
        public ActionResult RequestView()
        {
            var cookie = new HttpCookie("example", "ARG")
            {
                Expires = DateTime.Now.AddYears(1)
            };


            Response.Cookies.Add(cookie);

            Session["COOKIE"] = cookie;
            Session["session-test"] = "Net Lab";

            return View(this.Request);
        }
    }
}