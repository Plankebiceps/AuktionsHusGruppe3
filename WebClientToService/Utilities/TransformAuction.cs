using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webClientRef = WebClientToService.Models;
using proxyRef = WebClientToService.ServiceRefAuction;
using WebClientToService.Models;

namespace WebClientToService.Utilities {
    public class TransformAuction {


        // CONVERT SERVICE AUCTION LIST TO WEB LIST
        public List<WebAuction> ConvertFromServiceAuctions(proxyRef.Auction[] sAuctions) {
            List<WebAuction> foundClientAuctions = new List<WebAuction>();
            WebAuction tempAuction = null;
            foreach (proxyRef.Auction sAuction in sAuctions) {
                tempAuction = ConvertFromServiceAuction(sAuction);
                foundClientAuctions.Add(tempAuction);
            }
            return foundClientAuctions;
        }


        // CONVERT WEB MODEL AUCTION TO SERVICE AUCTION
        public proxyRef.Auction ConvertToServiceAuction(WebAuction webAuction)
        {

            proxyRef.Auction proxyWebAuction = null;
            if (webAuction != null) {
                proxyWebAuction = new proxyRef.Auction
                {
                    AuctionId = webAuction.AuctionId,
                    TimeLeft = webAuction.TimeLeft,
                    Payment = webAuction.Payment,
                    Result = webAuction.Result,
                    PaymentDate = webAuction.PaymentDate,
                    ProductName = webAuction.ProductName,
                    ProductDescription = webAuction.ProductDescription,
                };

            }

            return proxyWebAuction;
        }

        // CONVERT WEB AUCTION TO SERVICE AUCTION
        public WebAuction ConvertFromServiceAuction(proxyRef.Auction sAuction) {
            WebAuction foundClientAuction = null;
            if (sAuction != null) {
                foundClientAuction = new WebAuction {
                    AuctionId = sAuction.AuctionId,
                    TimeLeft = sAuction.TimeLeft,
                    Payment = sAuction.Payment,
                    Result = sAuction.Result,
                    PaymentDate = sAuction.PaymentDate,
                    ProductName = sAuction.ProductName,
                    ProductDescription = sAuction.ProductDescription,
                };
            }
            return foundClientAuction;
        }
        

    }
}