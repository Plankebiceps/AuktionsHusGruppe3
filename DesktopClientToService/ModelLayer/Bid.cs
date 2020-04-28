using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClientToService.ModelLayer {
    public class Bid {
        public int Id { get; set; }
        public decimal BidAmount { get; set; }
        public int CustomerId { get; set; }
        public int AuctionId { get; set; }


        public Bid() {

        }

        public Bid(decimal bidAmount, int customerId, int auctionId) {
            BidAmount = bidAmount;
            CustomerId = customerId;
            AuctionId = auctionId;
        }

        public override string ToString() {
            return $"Dkr. {BidAmount},- | Customer: {CustomerId}";
        }
    }
}
