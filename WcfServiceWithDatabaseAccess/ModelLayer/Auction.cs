using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    public class Auction
    {
        [DataMember]
        public int AuctionId { get; set; }
        [DataMember]
        public decimal TimeLeft { get; set; }
        [DataMember]
        public bool Payment { get; set; }
        [DataMember]
        public string Result { get; set; }
        [DataMember]
        public DateTime PaymentDate { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string ProductDescription { get; set; }


        public Auction(int auctionId, decimal timeLeft, bool payment, string result, DateTime paymentDate, string productName, string productDescription) {
            AuctionId = auctionId;
            TimeLeft = timeLeft;
            Payment = payment;
            Result = result;
            PaymentDate = paymentDate;
            ProductName = productName;
            ProductDescription = productDescription;
        }

        public Auction(decimal timeLeft, bool payment, string result, DateTime paymentDate, string productName, string productDescription) {
            TimeLeft = timeLeft;
            Payment = payment;
            Result = result;
            PaymentDate = paymentDate;
            ProductName = productName;
            ProductDescription = productDescription;
        }

        public Auction() {

        }

        public override string ToString() {
            return $"{AuctionId} | {ProductName} | Auction is {Result}";
        }
    }
}
