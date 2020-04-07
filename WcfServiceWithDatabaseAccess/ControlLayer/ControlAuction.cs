using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.DatabaseAccessLayer;

namespace WcfServiceWithDatabaseAccess.ControlLayer
{
    public class ControlAuction
    {
        public Auction CreateAuction(Auction auctionToCreate)
        {
            Auction createdAuction = null;

            AuctionAccess auctionDb = new AuctionAccess();
            createdAuction = auctionDb.CreateToDb(auctionToCreate);

            return createdAuction;
        }
    }
}
