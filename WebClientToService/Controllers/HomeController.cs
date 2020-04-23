using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientToService.Models;
using WebClientToService.ServiceLayer;

namespace WebClientToService.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Auction() {
            WebAuctionService was = new WebAuctionService();
            List<WebAuction> auctionsToDisplay = was.GetAllAuctions();

            return View(auctionsToDisplay);
        }
    }
}