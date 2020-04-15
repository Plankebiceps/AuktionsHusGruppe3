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
        public decimal TimeLeft { get; set; }
        public bool Payment { get; set; }
        public string Result { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public Auction(int auctionId, decimal timeLeft, bool payment, string result, DateTime paymentDate, string productName, string productDescription)
        {
            AuctionId = auctionId;
            TimeLeft = timeLeft;
            Payment = payment;
            Result = result;
            PaymentDate = paymentDate;
            ProductName = productName;
            ProductDescription = productDescription;
        }
    }
}
