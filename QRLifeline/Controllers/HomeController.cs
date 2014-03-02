using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QRLifeline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Page";

            return View();
        }

        public ActionResult Purchase()
        {
            ViewBag.Message = "Purchase Page";

            return View();
        }

        public ActionResult Testimonials()
        {
            ViewBag.Message = "Testimonial Page";

            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Message = "Team Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
