using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ModelLayer;
namespace DesktopClientToService.ServiceLayer
{
    interface CIAuctionService
    {
        Auction GetAuctionById(int auctionId);
    }
}
