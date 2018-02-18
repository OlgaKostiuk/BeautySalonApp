using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeautySalon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult HaircutAndStyling()
        {
            return View();
        }

        public ActionResult HairColoring()
        {
            return View();
        }

        public ActionResult HairProcedures()
        {
            return View();
        }

        public ActionResult MakeUp()
        {
            return View();
        }

        public ActionResult Nails()
        {
            return View();
        }

        public ActionResult Cosmetology()
        {
            return View();
        }

        public ActionResult Massage()
        {
            return View();
        }
        public ActionResult ManSalon()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
    }
}