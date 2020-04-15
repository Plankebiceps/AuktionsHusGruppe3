using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    class Customer
    {
        [DataMember]
        public string Adress { get; set; }
        [DataMember]
        public string CustomerEmail { get; set; }

        public Customer(string adress, string customerEmail)
        {
            Adress = adress;
            CustomerEmail = customerEmail;
        }
    }
}
