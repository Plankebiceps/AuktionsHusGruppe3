using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DesktopClientToService.ServiceRefAuction;
using DesktopClientToService.ModelLayer;

namespace DesktopClientToService.Utilities
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
            public Auction ConvertFromServiceAuction(Auction aAuction)
            {
                Auction foundAuction = null;
                if (aAuction != null)
                {
                foundAuction = new Auction
                {
                        AuctionId = aAuction.AuctionId,
                        TimeLeft = aAuction.TimeLeft,
                        Payment = aAuction.Payment,
                        Result = aAuction.Result,
                        PaymentDate = aAuction.PaymentDate,
                        ProductName = aAuction.ProductName,
                        ProductDescription = aAuction.ProductDescription,

                    };
                }
                return foundAuction;
            }
        
    }
}
