using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClientToService.Models {
    public class WebBid {
        public int Id { get; set; }
        public decimal BidAmount { get; set; }
        public int CustomerId { get; set; }
        public int AuctionId { get; set; }


        public WebBid() {
        }

        public WebBid(decimal bidAmount, int customerId, int auctionId) {
            BidAmount = bidAmount;
            CustomerId = customerId;
            AuctionId = auctionId;
        }

        public WebBid(int id, decimal bidAmount, int customerId, int auctionId)
        {
            Id = id;
            BidAmount = bidAmount;
            CustomerId = customerId;
            AuctionId = auctionId;
        }

        public override string ToString() {
            return $"Dkr. {BidAmount},- | Customer: {CustomerId}";
        }
    }
}