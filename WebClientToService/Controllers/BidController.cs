using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientToService.Models;
using WebClientToService.ServiceLayer;
using WebClientToService.ServiceRefBid;

namespace WebClientToService.Controllers
{
    public class BidController : Controller
    {
        // GET: Bid
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(WebBid bid) {
            WebBidService wbs = new WebBidService();

            wbs.CreateBid(bid);

            return RedirectToAction("List");
        }

        // auctionId ?????
        public ActionResult List(int auctionId) {
            WebBidService wbs = new WebBidService();

            List<WebBid> bidsToDisplay = wbs.GetAllBids(auctionId);

            return View(bidsToDisplay);
        }
    }
}