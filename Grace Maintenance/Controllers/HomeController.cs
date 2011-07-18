using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grace.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to Grace Baptist Church Administrative Site!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
