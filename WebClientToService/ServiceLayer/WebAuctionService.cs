using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebClientToService.Models;
using WebClientToService.ServiceRefAuction;
using WebClientToService.Utilities;

namespace WebClientToService.ServiceLayer {
    public class WebAuctionService {
        public List<WebAuction> GetAllAuctions() {
            List<WebAuction> foundAuctions = null;
            using (AuctionServiceClient auctionProxy = new AuctionServiceClient()) {
                Auction[] foundServiceAuctions = auctionProxy.GetAuctionAll();
                foundAuctions = Transform.ConvertToWebClient(foundServiceAuctions);
            }
            return foundAuctions;
        }
    
        public bool CreateAuction(Auction auctionToAdd)
        {
            bool allOk = false;
            using (AuctionServiceClient auctionProxy = new AuctionServiceClient())
            {
                allOk = auctionProxy.AddAuction(auctionToAdd);
            }
                return allOk;
        }
    
    }
}