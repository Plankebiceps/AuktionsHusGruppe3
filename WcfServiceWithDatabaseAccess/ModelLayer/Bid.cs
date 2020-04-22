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
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public int BidId { get; set; }



        public Bid()
        {

        }
    }

}
