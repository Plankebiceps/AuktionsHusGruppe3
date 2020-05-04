using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClientToService.ModelLayer
{
    public class Auction
    {
        public int AuctionId { get; set; }
        public DateTime TimeLeft { get; set; }
        public bool Payment { get; set; }
        public string Result { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public Auction (int auctionId, DateTime timeLeft, bool payment, string result, DateTime paymentDate, string productName, string productDescription)
        {
            AuctionId = auctionId;
            TimeLeft = timeLeft;
            Payment = payment;
            Result = result;
            PaymentDate = paymentDate;
            ProductName = productName;
            ProductDescription = productDescription;
        }

        public Auction(DateTime timeLeft, bool payment, string result, DateTime paymentDate, string productName, string productDescription) {
            TimeLeft = timeLeft;
            Payment = payment;
            Result = result;
            PaymentDate = paymentDate;
            ProductName = productName;
            ProductDescription = productDescription;
        }

        public Auction() {

        }

        public override string ToString() {
            return $"{AuctionId} | {ProductName} | Auction is {Result}";
        }
    }
}
