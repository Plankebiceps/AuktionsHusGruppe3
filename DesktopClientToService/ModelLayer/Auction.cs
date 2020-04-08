using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClientToService.ModelLayer
{
    public class Auction
    {
        // Eventuel mangel på instanciering på produkt
        public Product product;
        public int AuctionId { get; set; }
        public decimal TimeLeft { get; set; }
        public bool Payment { get; set; }
        public string Result { get; set; }
        public DateTime PaymentDate { get; set; }

        public Auction(decimal timeLeft, bool payment, string result, DateTime paymentDate, Product product)
        {
            TimeLeft = timeLeft;
            Payment = payment;
            Result = result;
            PaymentDate = paymentDate;
            this.product = product;
        }
    }
}
