﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFilters.Filters;

namespace MvcFilters.Controllers
{
    [AuthFilter]
    public class HomeController : Controller
    {
        [ActionFilter2]
        public ActionResult Index()
        {
            var a = 1; // DB call

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}