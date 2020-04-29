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

        //public ActionResult Details(int? id) {
        //    //If input seems reasonable create detailed student output - otherwise create list
        //    if (id != null && id > -1) {
        //        WebBidService wbs = new WebBidService();
        //        Bid detailBid = wbs.((int)id);
        //        return View(detailPerson);
        //    } else {
        //        return RedirectToAction("List");
        //    }
        //}
    }
}