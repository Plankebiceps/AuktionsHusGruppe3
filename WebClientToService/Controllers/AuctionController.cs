using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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



            //foreach (WebAuction auctionOnWeb in auctionsToDisplay) {

            //    //DateTime currentTime = DateTime.Now;
            //    //TimeSpan span = auctionOnWeb.TimeLeft - currentTime;
            //    //DateTime timeRemaining = new DateTime();
            //    //timeRemaining.Add(span);
            //}
                
                //timeRemaining = auctionOnWeb.TimeLeft;
              // NOTE: Overvej hvad der skal vises. View kan umiddelbart kun tilgå og vise DateTime (TimeLeft-variabel), altså dato+tidsformat og ikke kun eks. 24 timer eller 47 minutter. 
              // DateTime AuctionEndDate (not NULL) + int TimeLeft (NULL allowed)  -  AuctionToEnd kan da subtraheres med DateTime.Now og efterfølgende kan dette TimeSpan konverteres til en int, 
              // gemmes i int TimeLeft og vises i View. 
              // Muligvis kan timeRemaining modificeres til kun at vise timer/minutter ??

            return View(auctionsToDisplay);
        }
    }
}