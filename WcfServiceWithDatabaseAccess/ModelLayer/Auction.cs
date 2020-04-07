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
        // Eventuel mangel på instanciering på produkt
        [DataMember]
        public Product product;
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

        public Auction(int auctionId, decimal timeLeft, bool payment, string result, DateTime paymentDate, Product product)
        {
            AuctionId = auctionId;
            TimeLeft = timeLeft;
            Payment = payment;
            Result = result;
            PaymentDate = paymentDate;
            this.product = product;
        }
    }
}
