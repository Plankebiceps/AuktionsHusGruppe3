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
        [AllowAnonymous]
        public ActionResult Index() {
            return View();
        }

        [AllowAnonymous]
        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult CustomerLogin()
        {
            //Opsætning af et login system for brugere

            return View();
        }

        [Authorize]
        public ActionResult CustomerCreateAccount()
        {
            return View();
        }
    }
}