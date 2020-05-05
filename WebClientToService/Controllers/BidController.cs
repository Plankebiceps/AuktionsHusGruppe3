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

        public ActionResult Create(WebBid bid)
        {
            WebBidService wbs = new WebBidService();

            wbs.CreateBid(bid);

            return RedirectToAction("List");
        }

        // auctionId ?????
        public ActionResult List(int id)
        {

            WebBidService wbs = new WebBidService();
            List<WebBid> bidsToDisplay = wbs.GetAllBids(id);


            return View(bidsToDisplay);
        }

        //public ActionResult BidList(int? auctionId)
        //{
        //if (auctionId != null && auctionId > -1)
        //{
        //    WebBidService wbs = new WebBidService();
        //    List<WebBid> bidsToDisplay = wbs.GetAllBids((int)auctionId);
        //    return View(bidsToDisplay);
        //}
        //else
        //{
        //    return RedirectToAction("ABid");
        //}
        //}

        //public ActionResult ABid()
        //{
        //    return View();
        //}

        public ActionResult ABid()
        {

            WebBid WebBid;
            WebBidService WebBS = new WebBidService();
            WebBid = WebBS.GetBidById(1);


            return View(WebBid);
        }

        //}
    }
}
        
 