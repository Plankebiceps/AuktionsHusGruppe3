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
            Auction createdAuction;

            AuctionAccess auctionDb = new AuctionAccess();
            createdAuction = auctionDb.CreateToDb(auctionToCreate);

            return createdAuction;
        }

        public void DeleteAuction(int auctionId) { 
            AuctionAccess auctionDb = new AuctionAccess();
            auctionDb.DeleteFromDb(auctionId);
        }



        public Auction GetAuctionById(int findAuctionId)
        {
            Auction foundAuction;

            AuctionAccess auctionDb = new AuctionAccess();
            foundAuction = auctionDb.GetAuctionById(findAuctionId);

            return foundAuction;
        }
    }
}
