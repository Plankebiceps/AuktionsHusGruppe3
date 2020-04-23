using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClientToService.Models {
    public class WebAuction {
        public int AuctionId { get; set; }
        public decimal TimeLeft { get; set; }
        public bool Payment { get; set; }
        public string Result { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public WebAuction(int auctionId, decimal timeLeft, bool payment, string result, DateTime paymentDate, string productName, string productDescription) {
            AuctionId = auctionId;
            TimeLeft = timeLeft;
            Payment = payment;
            Result = result;
            PaymentDate = paymentDate;
            ProductName = productName;
            ProductDescription = productDescription;
        }

        public WebAuction(decimal timeLeft, bool payment, string result, DateTime paymentDate, string productName, string productDescription) {
            TimeLeft = timeLeft;
            Payment = payment;
            Result = result;
            PaymentDate = paymentDate;
            ProductName = productName;
            ProductDescription = productDescription;
        }

        public WebAuction() {

        }

        //public override string ToString() {
        //    return $"{AuctionId} | {ProductName} (Open) (Current bid: 49,- Dkr)";
        //}

        public override string ToString() {
            string thisObjString = $"{AuctionId}";
            return thisObjString;
        }
    }
}