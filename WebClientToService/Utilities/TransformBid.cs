using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webClientRef = WebClientToService.Models;
using proxyRef = WebClientToService.ServiceRefBid;
using WebClientToService.Models;

namespace WebClientToService.Utilities {

    public class TransformBid {
        // CONVERT SERVICE BID LIST TO WEB LIST
        public List<WebBid> ConvertFromServiceBids(proxyRef.Bid[] sBids) {
            List<WebBid> foundClientBids = new List<WebBid>();
            WebBid tempBid = null;
            foreach (proxyRef.Bid sBid in sBids) {
                tempBid = ConvertFromServiceBid(sBid);
                foundClientBids.Add(tempBid);
            }
            return foundClientBids;
        }


        // CONVERT WEB-MODEL BID TO SERVICE BID
        public proxyRef.Bid ConvertToServiceBid(WebBid webBid) {

            proxyRef.Bid proxyWebBid = null;
            if (webBid != null) {
                proxyWebBid = new proxyRef.Bid {
                    AuctionId = webBid.AuctionId,
                    BidAmount = webBid.BidAmount,
                    CustomerId = webBid.CustomerId
                };
            }
            return proxyWebBid;
        }


        // CONVERT WEB MODEL BID TO SERVICE BID
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