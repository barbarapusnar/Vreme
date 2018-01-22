using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vreme.Models;

namespace Vreme.Controllers
{
    public class HomeController : Controller
    {
        private VremeContext db1 = new VremeContext();
        public ActionResult Index()
        {
            var data = from element in db1.Podatkis
                      group element by element.IdPostaje
                  into groups
                      select groups.OrderByDescending(p => p.Cas).FirstOrDefault();
            return View(data);
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