using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientToService.Models;
using WebClientToService.ServiceLayer;
using WebClientToService.ServiceRefAuction;

namespace WebClientToService.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(WebAuction auc) {
            WebAuctionService was = new WebAuctionService();

            auc.Result = "Open";
            DateTime dt = new DateTime(2012, 12, 31, 16, 45, 0);
            auc.PaymentDate = dt;
            auc.Payment = false;

            was.CreateAuction(auc);

            return RedirectToAction("List");
        }

        public ActionResult List() {
            WebAuctionService was = new WebAuctionService();
            List<WebAuction> auctionsToDisplay = was.GetAllAuctions();

            

            
            DateTime currentTime = DateTime.Now;

            foreach(WebAuction auctionOnWeb in auctionsToDisplay)
                
            {
                auctionOnWeb.TimeLeft = auctionOnWeb.TimeLeft - currentTime;

            }

            return View(auctionsToDisplay);
        }
    }
}