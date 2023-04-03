using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Beauty365.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AgendarCita()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Citas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Horarios()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Usuarios()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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

        public ActionResult admin()
        {
            return View();
        }

        public ActionResult ventas()
        {
            return View();
        }

        public ActionResult operaciones()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult login()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }


}