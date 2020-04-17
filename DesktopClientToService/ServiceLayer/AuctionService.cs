using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceRefAuction;
using DesktopClientToService.Utilities;


namespace DesktopClientToService.ServiceLayer
{
    public class AuctionService
    {
        public Auction CreateAuction(Auction auctionToCreate)
        {
            AuctionServiceClient auctionProxy = new AuctionServiceClient();
            Auction aProxyAuction = auctionProxy.CreateAuction(auctionToCreate);

            return aProxyAuction;
        }
        public ModelLayer.Auction GetAuctionById(int findAuctionId)
        {
            ModelLayer.Auction anAuction = null;
            ServiceRefAuction.Auction aProxyAuction = null;
            using (AuctionServiceClient auctionProxy = new AuctionServiceClient())
            {
                aProxyAuction = auctionProxy.GetAuctionById(findAuctionId);
            }
            if (aProxyAuction != null)
            {
                anAuction = new ConvertDataAuction().ConvertFromServiceAuction(aProxyAuction);
            }

            return anAuction;
        }

    }
}
