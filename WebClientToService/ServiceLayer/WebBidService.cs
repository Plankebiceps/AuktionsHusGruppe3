using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClientToService.Utilities;
using webClientRef = WebClientToService.Models;
using proxyRef = WebClientToService.ServiceRefBid;
using WebClientToService.Models;

namespace WebClientToService.ServiceLayer {
    public class WebBidService {
        public List<WebBid> GetAllBids(int auctionId) {
            List<WebBid> bids = null;
            proxyRef.Bid[] proxyBids = null;
            using (proxyRef.BidServiceClient bidProxy = new proxyRef.BidServiceClient()) {
                proxyBids = bidProxy.GetBidAll(auctionId);
            }
            if (proxyBids != null && proxyBids.Length > 0) {
                bids = new TransformBid().ConvertFromServiceBids(proxyBids);
            }
            return bids;
        }
    }
}
