using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthWebApp.Domain;

namespace NorthWebApp.Controllers
{
    public class RegionController : Controller
    {
        // GET: Region
        public ActionResult Index()
        {
            List<Region> regions;

            using (var context = new Context())
            {
                regions = context.Regions.ToList();
            }

            return View(regions);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Region region)
        {
            using (var context = new Context())
            {
                region.RegionID = context.Regions.Max(c => c.RegionID) + 1;

                context.Regions.Add(region);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}