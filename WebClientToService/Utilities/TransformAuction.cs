using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webClientRef = WebClientToService.Models;
using proxyRef = WebClientToService.ServiceRefAuction;
using WebClientToService.Models;

namespace WebClientToService.Utilities {
    public class TransformAuction {


        // CONVERT SERVICE AUCTION LIST TO DESKTOP LIST
        public List<WebAuction> ConvertFromServiceAuctions(proxyRef.Auction[] sAuctions) {
            List<WebAuction> foundClientAuctions = new List<WebAuction>();
            WebAuction tempAuction = null;
            foreach (proxyRef.Auction sAuction in sAuctions) {
                tempAuction = ConvertFromServiceAuction(sAuction);
                foundClientAuctions.Add(tempAuction);
            }
            return foundClientAuctions;
        }


        // CONVERT DESKTOP AUCTION TO SERVICE AUCTION
        public proxyRef.Auction ConvertToServiceAuction(WebAuction webauction)
        {

            proxyRef.Auction proxyWebAuction = null;
            if (webauction != null) {
                proxyWebAuction = new proxyRef.Auction
                {
                    AuctionId = webauction.AuctionId,
                    TimeLeft = webauction.TimeLeft,
                    Payment = webauction.Payment,
                    Result = webauction.Result,
                    PaymentDate = webauction.PaymentDate,
                    ProductName = webauction.ProductName,
                    ProductDescription = webauction.ProductDescription,
                };

            }

            return proxyWebAuction;
        }

        // CONVERT DESKTOP AUCTION TO SERVICE AUCTION
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