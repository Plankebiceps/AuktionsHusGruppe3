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
    }
}
