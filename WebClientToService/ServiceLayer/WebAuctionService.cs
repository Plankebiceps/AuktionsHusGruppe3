using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;
using System.Web.Configuration;
using WebClientToService.Models;
using WebClientToService.ServiceRefAuction;
using WebClientToService.Utilities;
using webClientRef = WebClientToService.Models;
using proxyRef = WebClientToService.ServiceRefAuction;

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
        
        public bool CreateAuction(WebAuction auctionToAdd)
        {
            bool allOk = false;
            proxyRef.Auction auctionServiceFormat = new Transform().ConvertToServiceAuction(auctionToAdd);
            using (AuctionServiceClient auctionProxy = new AuctionServiceClient())
            {
                allOk = auctionProxy.AddAuction(auctionServiceFormat);
            }
                return allOk;
        }
    
    }
}