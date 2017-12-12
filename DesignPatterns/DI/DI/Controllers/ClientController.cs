using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DI.Logic;

namespace DI.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientLogic clientLogic;

        public ClientController(IClientLogic clientLogic)
        {
            this.clientLogic = clientLogic;
        }

        public ActionResult Index()
        {
            return View(this.clientLogic.GetAll());
        }
    }
}