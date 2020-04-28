using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceRefBid;
using DesktopClientToService.ModelLayer;

namespace DesktopClientToService.Utilities {
    public class ConvertDataBid {
        public ModelLayer.Bid ConvertFromServiceBid(ServiceRefBid.Bid serviceBid) {
            ModelLayer.Bid desktopBid = null;
            if (serviceBid != null) {

                desktopBid = new ModelLayer.Bid { 
                    AuctionId = serviceBid.AuctionId,
                    CustomerId = serviceBid.CustomerId,
                    BidAmount = serviceBid.BidAmount
                };
            }
            return desktopBid;
        }

        public ServiceRefBid.Bid ConvertToServiceBid(ModelLayer.Bid desktopBid) {
            ServiceRefBid.Bid serviceBid = null;
            if (desktopBid != null) {
                serviceBid = new ServiceRefBid.Bid {
                    AuctionId = desktopBid.AuctionId,
                    CustomerId = desktopBid.CustomerId,
                    BidAmount = desktopBid.BidAmount
                };
            }
            return serviceBid;
        }

        public List<ModelLayer.Bid> ConvertFromServiceBids(List<ServiceRefBid.Bid> serviceBids) {
            List<ModelLayer.Bid> desktopBids = null;
            if (serviceBids != null) {
                desktopBids = new List<ModelLayer.Bid>();
            }
            return desktopBids;
        }
    }
}
