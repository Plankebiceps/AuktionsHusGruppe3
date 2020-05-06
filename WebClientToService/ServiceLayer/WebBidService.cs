using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClientToService.Utilities;
using webClientRef = WebClientToService.Models;
using proxyRef = WebClientToService.ServiceRefBid;
using WebClientToService.Models;
using WebClientToService.ServiceRefBid;

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

        public WebBid GetBidById(int bidId)
        {
            WebBid aWebBid = null;
            proxyRef.Bid aProxyBid = null;
            using (proxyRef.BidServiceClient bidProxy = new proxyRef.BidServiceClient())
            {
                aProxyBid = bidProxy.GetBidById(bidId);
            }
            if (aProxyBid != null)
            {
                aWebBid = new TransformBid().ConvertFromServiceBid(aProxyBid);
            }
            else
            {
                aWebBid = new WebBid()
                {
                    
                };
            }

            return aWebBid;
        }

        public bool CreateBid(WebBid bidToPlace) {
            bool allOk = false;
            proxyRef.Bid bidServiceFormat = new TransformBid().ConvertToServiceBid(bidToPlace);
            using (BidServiceClient bidProxy = new BidServiceClient()) {
                allOk = bidProxy.PlaceBid(bidServiceFormat);
            }
            return allOk;
        }

        public bool UpdateBid(WebBid aBidToUpdate)
        {
            bool allOk = false;
            proxyRef.Bid bidServiceFormat = new TransformBid().ConvertToServiceBid(aBidToUpdate);
            using (BidServiceClient bidProxy = new BidServiceClient())
            {
                allOk = bidProxy.UpdateBid(bidServiceFormat);
            }
            return allOk;
        }

    }
}
