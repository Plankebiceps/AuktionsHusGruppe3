using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientToService.Models;
using WebClientToService.ServiceLayer;

namespace WebClientToService.Controllers {
    public class BidController : Controller {
        public ActionResult Index() {
            return View();
        }

        //public ActionResult ListBids(int auctionId) {

        //    //???

        //    WebBidService wbs = new WebBidService();
        //    List<WebBid> foundBids = wbs.GetAllBids(auctionId);

        //    return View(foundBids);
        //}
    }
}