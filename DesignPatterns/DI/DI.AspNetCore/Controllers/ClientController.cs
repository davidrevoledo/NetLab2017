using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DI.AspNetCore.Logic;
using Microsoft.AspNetCore.Mvc;
using DI.AspNetCore.Models;

namespace DI.AspNetCore.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientLogic _clientLogic;

        public ClientController(IClientLogic clientLogic)
        {
            _clientLogic = clientLogic;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
