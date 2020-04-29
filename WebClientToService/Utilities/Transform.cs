using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webClientRef = WebClientToService.Models;
using proxyRef = WebClientToService.ServiceRefAuction;

namespace WebClientToService.Utilities {
    public class Transform {
        public static List<webClientRef.WebAuction> ConvertToWebClient(proxyRef.Auction[] serviceAuctions) {
            List<webClientRef.WebAuction> foundWebClientAuctions = null;
            if (serviceAuctions != null && serviceAuctions.Length > 0) {
                foundWebClientAuctions = new List<webClientRef.WebAuction>();
                webClientRef.WebAuction tempWebClientAuction;
                foreach (proxyRef.Auction serviceAuction in serviceAuctions) {
                    tempWebClientAuction = new webClientRef.WebAuction(serviceAuction.AuctionId, serviceAuction.TimeLeft, serviceAuction.Payment,
                                                          serviceAuction.Result, serviceAuction.PaymentDate, serviceAuction.ProductName,
                                                          serviceAuction.ProductDescription);
                    foundWebClientAuctions.Add(tempWebClientAuction);
                }
            }
            return foundWebClientAuctions;
        }

        
    }
}