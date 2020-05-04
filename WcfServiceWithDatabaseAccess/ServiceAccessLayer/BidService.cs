using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.ControlLayer;

namespace WcfServiceWithDatabaseAccess.ServiceAccessLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BidService" in both code and config file together.
    public class BidService : IBidService {

        public bool PlaceBid(Bid bidToPlace) {
            ControlBid ctrlBid = new ControlBid();
            return ctrlBid.InsertBid(bidToPlace);
        }
        public List<Bid> GetBidAll(int auctionId) {
            ControlBid ctrlBid = new ControlBid();
            return ctrlBid.GetAllBids(auctionId);
        }
        
        public Bid GetBidById(int bidId)
        {
            ControlBid ctrlBid = new ControlBid();
            return ctrlBid.GetBidById(bidId);
        }
    
    }
}
