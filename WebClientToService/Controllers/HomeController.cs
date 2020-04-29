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

        public ActionResult List() {
            WebAuctionService was = new WebAuctionService();
            List<WebAuction> auctionsToDisplay = was.GetAllAuctions();

            return View(auctionsToDisplay);
        }

        public ActionResult CustomerLogin()
        {
            //Opsætning af et login system for brugere

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(WebAuction auc)
        {
            WebAuctionService was = new WebAuctionService();

            auc.Result = "Open";
            DateTime dt = new DateTime(2012, 12, 31, 16, 45, 0);
            auc.PaymentDate = dt;
            auc.Payment = false;

            was.CreateAuction(auc);

            return RedirectToAction("List");
        }

    }
}