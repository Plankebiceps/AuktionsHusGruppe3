using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webClientRef = WebClientToService.Models;
using proxyRef = WebClientToService.ServiceRefBid;
using WebClientToService.Models;

namespace WebClientToService.Utilities {

    public class TransformBid {
        // CONVERT SERVICE BID LIST TO DESKTOP LIST
        public List<WebBid> ConvertFromServiceBids(proxyRef.Bid[] sBids) {
            List<WebBid> foundClientBids = new List<WebBid>();
            WebBid tempBid = null;
            foreach (proxyRef.Bid sBid in sBids) {
                tempBid = ConvertFromServiceBid(sBid);
                foundClientBids.Add(tempBid);
            }
            return foundClientBids;
        }




        // TO DO: CONVERT DESKTOP AUCTION TO SERVICE AUCTION





        // CONVERT DESKTOP AUCTION TO SERVICE AUCTION
        public WebBid ConvertFromServiceBid(proxyRef.Bid sBid) {
            WebBid foundClientBid = null;
            if (sBid != null) {
                foundClientBid = new WebBid {
                    AuctionId = sBid.AuctionId,
                    BidAmount = sBid.BidAmount,
                    CustomerId = sBid.CustomerId
                };
            }
            return foundClientBid;
        }
    }
}