using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    class Receipt
    {
        [DataMember]
        public string ReceiptDescription { get; set; }

        public Receipt(string receiptDescription)
        {
            ReceiptDescription = receiptDescription;
        }
    }
}
