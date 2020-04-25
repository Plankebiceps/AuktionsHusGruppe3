using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* To be removed notice "using" of References. One for Client ModelLayer
 * and one for the Service Reference --- No more using statements allowed in this class */
using proxyRef = DesktopClientToService.ServiceRefBid;
using clientRef = DesktopClientToService.ModelLayer;
using DesktopClientToService.Utilities;

namespace DesktopClientToService.ServiceLayer {
    public class BidService {

        public bool PlaceBid(clientRef.Bid bidToPlace) {

            bool allOk = false;
            proxyRef.Bid bidInServiceFormat = new ConvertDataBid().ConvertToServiceBid(bidToPlace);
            using (proxyRef.BidServiceClient bidProxy = new proxyRef.BidServiceClient()) {
                allOk = bidProxy.PlaceBid(bidInServiceFormat);
            }
            return allOk;
        }
    }
}