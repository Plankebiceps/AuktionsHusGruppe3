using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* To be removed notice "using" of References. One for Client ModelLayer
 * and one for the Service Reference --- No more using statements allowed in this class */
using proxyRef = DesktopClientToService.ServiceRefBid;
using clientRef = DesktopClientToService.ModelLayer;
using DesktopClientToService.Utilities;

namespace DesktopClientToService.ServiceLayer {
    public class BidService {

        public bool PlaceBid(clientRef.Bid bidToPlace) {

            bool allOk = false;
            proxyRef.Bid bidInServiceFormat = new ConvertDataBid().ConvertToServiceBid(bidToPlace);
            using (proxyRef.BidServiceClient bidProxy = new proxyRef.BidServiceClient()) {
                allOk = bidProxy.PlaceBid(bidInServiceFormat);
            }
            return allOk;
        }

        public bool UpdateBid(clientRef.Bid aBidToUpdate)
        {
            bool allOk = false;
            proxyRef.Bid bidInServiceFormat = new ConvertDataBid().ConvertToServiceBid(aBidToUpdate);
            using (proxyRef.BidServiceClient bidProxy = new proxyRef.BidServiceClient())
            {
                allOk = bidProxy.UpdateBid(bidInServiceFormat);
            }
            return allOk;

        }

        public List<clientRef.Bid> GetBidAll(int auctionId) {

            proxyRef.BidServiceClient bsc = new proxyRef.BidServiceClient();
            var bids = bsc.GetBidAll(auctionId);

            List<clientRef.Bid> foundBidsList = GetClientSideBids(bids);

            return foundBidsList;
        }

        public List<clientRef.Bid> GetClientSideBids(IEnumerable<proxyRef.Bid> bids) {

            List<clientRef.Bid> foundBidsList = new List<clientRef.Bid>();
            clientRef.Bid tempBid;

            foreach (var bid in bids) {
                tempBid = new clientRef.Bid(bid.BidAmount, bid.CustomerId, bid.AuctionId);
                foundBidsList.Add(tempBid);
            }
            return foundBidsList;
        }
    }
}