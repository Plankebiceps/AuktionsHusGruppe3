using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientToService.Models;
using WebClientToService.ServiceLayer;
using WebClientToService.ServiceRefAuction;

namespace WebClientToService.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CustomerLogin()
        {
            //Opsætning af et login system for brugere

            return View();
        }

        public ActionResult CBid()
        {
            return View();
        }

    }
}