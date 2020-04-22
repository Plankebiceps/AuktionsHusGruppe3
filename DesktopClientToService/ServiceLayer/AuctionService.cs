using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* To be removed notice "using" of References. One for Client ModelLayer
 * and one for the Service Reference --- No more using statements allowed in this class */
using proxyRef = DesktopClientToService.ServiceRefAuction;
using clientRef = DesktopClientToService.ModelLayer;
using DesktopClientToService.Utilities;

namespace DesktopClientToService.ServiceLayer
{
    public class AuctionService
    {
        public bool AddAuction(clientRef.Auction auctionToAdd)
        {
            bool allOk = false;
            proxyRef.Auction auctionInServiceFormat = new ConvertDataAuction().ConvertToServiceAuction(auctionToAdd);
            using (proxyRef.AuctionServiceClient auctionProxy = new proxyRef.AuctionServiceClient()) {
                allOk = auctionProxy.AddAuction(auctionInServiceFormat);
            }
            return allOk;
        }

        public void DeleteAuction(int auctionId) {
            proxyRef.AuctionServiceClient auctionProxy = new proxyRef.AuctionServiceClient();
            auctionProxy.DeleteAuction(auctionId);
        }


        public clientRef.Auction GetAuctionById(int findAuctionId)
        {
            clientRef.Auction clientAuction = null;
            proxyRef.Auction aProxyAuction = null;
            using (proxyRef.AuctionServiceClient auctionProxy = new proxyRef.AuctionServiceClient())
            {
                aProxyAuction = auctionProxy.GetAuctionById(findAuctionId);
            }
            if (aProxyAuction != null)
            {
                clientAuction = new ConvertDataAuction().ConvertFromServiceAuction(aProxyAuction);
            }

            return clientAuction;
        }

        public void UpdateAuction(clientRef.Auction auctionToUpdate) {
            proxyRef.Auction auctionInServiceFormat = new ConvertDataAuction().ConvertToServiceAuction(auctionToUpdate);
            using (proxyRef.AuctionServiceClient auctionProxy = new proxyRef.AuctionServiceClient()) {
                auctionProxy.UpdateAuction(auctionInServiceFormat);
            }
        }


    }
}
