using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceWithDatabaseAccess.ModelLayer;

namespace WcfServiceWithDatabaseAccess.ServiceAccessLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBidService" in both code and config file together.
    [ServiceContract]
    public interface IBidService
    {

        //[OperationContract]
        //bool CreateBid(decimal priceBid, Customer bidder);

        [OperationContract]
        bool PlaceBid(Bid bidToPlace);

        [OperationContract]
        List<Bid> GetBidAll(int auctionId);
    }
}
