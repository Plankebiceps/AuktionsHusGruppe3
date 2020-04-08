using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceRefAuction;

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
    }
}
