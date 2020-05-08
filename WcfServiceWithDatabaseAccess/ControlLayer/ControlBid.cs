using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.DatabaseAccessLayer;

namespace WcfServiceWithDatabaseAccess.ControlLayer {
    public class ControlBid {

        public bool InsertBid(Bid bidToInsert) {
            bool wasInsertedCorrectly;

            BidAccess bidDb = new BidAccess();
            wasInsertedCorrectly = bidDb.SaveBid(bidToInsert);

            return wasInsertedCorrectly;
        }


        public bool UpdateBid(Bid aBidToUpdate)
        {
            bool wasUpdatedCorrectly;

            BidAccess bidDb = new BidAccess();
            wasUpdatedCorrectly = bidDb.UpdateBid(aBidToUpdate);
            return wasUpdatedCorrectly;
        }

        public List<Bid> GetAllBids(int auctionId) {
            List<Bid> foundBids;

            BidAccess bidDb = new BidAccess();
            foundBids = bidDb.GetAllBids(auctionId);

            return foundBids;
        }
    
        public Bid GetBidById(int bidId)
        {
            Bid foundBid;
            
            BidAccess bidDb = new BidAccess();
            foundBid = bidDb.GetBidById(bidId);
            
            return foundBid;
        }
    
    }
}
