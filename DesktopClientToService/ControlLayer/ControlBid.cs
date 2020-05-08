using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* To be removed! --- Controller's can only know and use ServiceLayer and ModelLayer */
using DesktopClientToService.ServiceLayer;
using DesktopClientToService.ModelLayer;

namespace DesktopClientToService.ControlLayer {
    public class ControlBid {

        public bool PlaceBid(decimal amountToBid, int auctionId, int customerId) {

            Bid bid = new Bid {
                BidAmount = amountToBid,
                AuctionId = auctionId,
                CustomerId = customerId
            };

            BidService bidService = new BidService();
            return bidService.PlaceBid(bid);
        }

        public bool UpdateBid(decimal amountToBid, int auctionId, int customerId)
        {

            Bid bid = new Bid
            {
                BidAmount = amountToBid,
                AuctionId = auctionId,
                CustomerId = customerId
            };

            BidService bidService = new BidService();
            return bidService.UpdateBid(bid);
        }

        public List<Bid> GetAllBids(int auctionId) {
            BidService bidService = new BidService();
            return bidService.GetBidAll(auctionId);
        }
    }
}
