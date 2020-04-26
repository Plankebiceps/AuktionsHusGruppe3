using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientToService.Models;
using WebClientToService.ServiceLayer;

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

        public ActionResult Auctions() {
            WebAuctionService was = new WebAuctionService();
            List<WebAuction> auctionsToDisplay = was.GetAllAuctions();

            return View(auctionsToDisplay);
        }

        public ActionResult CustomerLogin()
        {
            //Opsætning af et login system for brugere

            return View();
        }
    }
}