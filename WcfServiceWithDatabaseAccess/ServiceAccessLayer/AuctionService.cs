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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuctionService" in both code and config file together.
    public class AuctionService : IAuctionService
    {
        public Auction CreateAuction(Auction auctionToCreate)
        {
            ControlAuction ctrlAuction = new ControlAuction();
            return ctrlAuction.CreateAuction(auctionToCreate);
        }

        public Auction DeleteAuction(int auctionId)
        {
            throw new NotImplementedException();
        }

        public Auction GetAuctionById(int auctionId)
        {
            throw new NotImplementedException();
        }

        public Auction ModifyAuction(decimal timeLeft, bool payment, string result, DateTime paymentDate)
        {
            throw new NotImplementedException();
        }
    }
}
