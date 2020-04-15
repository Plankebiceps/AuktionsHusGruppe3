using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceLayer;
using DesktopClientToService.ServiceRefAuction;

namespace DesktopClientToService.ControlLayer
{
    public class ControlAuction
    {
        //"as" kan ikke bruges istedet for auctionService
        public Auction CreateAuction(decimal timeLeft, bool payment, string result, DateTime paymentDate, string productName, string productDescription)
        {
            Auction auction = new Auction
            {
                TimeLeft = timeLeft,
                Payment = payment,
                Result = result,
                PaymentDate = paymentDate,
                ProductName = productName,
                ProductDescription = productDescription
                

            };


            AuctionService auctionService = new AuctionService();
            return auctionService.CreateAuction(auction);
        }
    }
}
