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
            List<WebAuction> auctions = null;
            proxyRef.Auction[] proxyAuctions = null;
            using (proxyRef.AuctionServiceClient auctionProxy = new proxyRef.AuctionServiceClient()) {
                proxyAuctions = auctionProxy.GetAuctionAll();
            }
            if (proxyAuctions != null && proxyAuctions.Length > 0) {
                auctions = new TransformAuction().ConvertFromServiceAuctions(proxyAuctions);
            }
            return auctions;
        }

        

        public bool CreateAuction(WebAuction auctionToAdd)
        {
            bool allOk = false;
            proxyRef.Auction auctionServiceFormat = new TransformAuction().ConvertToServiceAuction(auctionToAdd);
            using (AuctionServiceClient auctionProxy = new AuctionServiceClient())
            {
                allOk = auctionProxy.AddAuction(auctionServiceFormat);
            }
                return allOk;
        }
    
    }
}