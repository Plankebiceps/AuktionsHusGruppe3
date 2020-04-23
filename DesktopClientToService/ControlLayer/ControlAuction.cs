using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* To be removed! --- Controller's can only know and use ServiceLayer and ModelLayer */
using DesktopClientToService.ServiceLayer;
using DesktopClientToService.ModelLayer;

namespace DesktopClientToService.ControlLayer
{
    public class ControlAuction
    {
        //"as" kan ikke bruges istedet for auctionService

        public bool AddAuction(decimal timeLeft, bool payment, string result, DateTime paymentDate, 
                                string productName, string productDescription)
        {
            Auction auction = new Auction {
                TimeLeft = timeLeft,
                Payment = payment,
                Result = result,
                PaymentDate = paymentDate,
                ProductName = productName,
                ProductDescription = productDescription
            };

            AuctionService auctionService = new AuctionService();
            return auctionService.AddAuction(auction);
        }

        public void DeleteAuction(int auctionId) {
            AuctionService auctionService = new AuctionService();
            auctionService.DeleteAuction(auctionId);
        }

        public Auction GetAuctionById(int findAuctionId)
        {
            AuctionService auctionService = new AuctionService();
            return auctionService.GetAuctionById(findAuctionId);
        }

        public void UpdateAuction(int auctionIdToUpdate, decimal timeLeft, bool payment, string result, DateTime paymentDate,
                                  string productName, string productDescription) {

            Auction auction = new Auction {
                AuctionId = auctionIdToUpdate,
                TimeLeft = timeLeft,
                Payment = payment,
                Result = result,
                PaymentDate = paymentDate,
                ProductName = productName,
                ProductDescription = productDescription
            };

            AuctionService auctionService = new AuctionService();
            auctionService.UpdateAuction(auction);

        }

        public List<Auction> GetAllAuctions() {
            AuctionService auctionService = new AuctionService();
            return auctionService.GetAuctionAll();
        }
    }
}
