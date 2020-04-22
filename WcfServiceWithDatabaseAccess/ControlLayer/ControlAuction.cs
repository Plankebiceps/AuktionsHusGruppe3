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
        public bool InsertAuction(Auction auctionToInsert)
        {
            bool wasInsertedCorrectly;

            AuctionAccess auctionDb = new AuctionAccess();
            wasInsertedCorrectly = auctionDb.SaveAuction(auctionToInsert);

            return wasInsertedCorrectly;
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

        public void ModifyAuction(Auction auctionToModify) {
            AuctionAccess auctionDb = new AuctionAccess();
            auctionDb.ModifySavedAuction(auctionToModify);
        }

        public List<Auction> GetAllAuctions() {
            List<Auction> foundAuctions;

            AuctionAccess auctionDb = new AuctionAccess();
            foundAuctions = auctionDb.GetAllAuctions();

            return foundAuctions;
        }
    }
}
