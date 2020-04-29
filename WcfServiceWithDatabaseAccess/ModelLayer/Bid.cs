using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    public class Bid
    {
        //[DataMember]
        //public decimal Price { get; set; }
        //[DataMember]
        //public int BidId { get; set; }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public decimal BidAmount { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public int AuctionId { get; set; }

        public Bid() {

        }

        public Bid(decimal bidAmount, int customerId, int auctionId) {
            BidAmount = bidAmount;
            CustomerId = customerId;
            AuctionId = auctionId;
        }

        public override string ToString() {
            return $"Dkr. {BidAmount},- | Customer: {CustomerId}";
        }
    }

}
