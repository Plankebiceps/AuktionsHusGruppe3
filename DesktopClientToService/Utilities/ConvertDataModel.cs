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
    public class ConvertDataModel : IModelConvert
    {


         // Convert Auction-object created through service to local Auction-object in desktop app.
        public ModelLayer.Auction ConvertFromServiceAuction(ServiceRefAuction.Auction serviceAuction) {
            ModelLayer.Auction desktopAuction = null;
                if (serviceAuction != null) {
                    desktopAuction = new ModelLayer.Auction {

                        AuctionId = serviceAuction.AuctionId,
                        TimeLeft = serviceAuction.TimeLeft,
                        Payment = serviceAuction.Payment,
                        Result = serviceAuction.Result,
                        ProductName = serviceAuction.ProductName,
                        ProductDescription = serviceAuction.ProductDescription,
                    };
                }
                return desktopAuction;
        }


        // See above. Vice versa.
        public ServiceRefAuction.Auction ConvertToServiceAuction(ModelLayer.Auction desktopAuction) {
            ServiceRefAuction.Auction serviceAuction = null;
                if (desktopAuction != null) {
                    serviceAuction = new ServiceRefAuction.Auction {

                        AuctionId = desktopAuction.AuctionId,
                        TimeLeft = desktopAuction.TimeLeft,
                        Payment = desktopAuction.Payment,
                        Result = desktopAuction.Result,
                        ProductName = desktopAuction.ProductName,
                        ProductDescription = desktopAuction.ProductDescription,
                    };
                }
                return serviceAuction;
        }



    }
}
