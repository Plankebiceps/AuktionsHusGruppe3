using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceWithDatabaseAccess.ModelLayer;

namespace WcfServiceWithDatabaseAccess.ServiceAccessLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuctionService" in both code and config file together.
    [ServiceContract]
    public interface IAuctionService
    {
        [OperationContract]
        Auction GetAuctionById(int auctionId);

        [OperationContract]
        bool AddAuction(Auction auctionToAdd);

        [OperationContract]
        void DeleteAuction(int auctionId);

        [OperationContract]
        Auction ModifyAuction(decimal timeLeft, bool payment, string result, DateTime paymentDate, string productName, string productDescription);
    }
}
