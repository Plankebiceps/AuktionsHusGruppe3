using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    public class Customer : Person
    {
        [DataMember]
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DataMember]
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DataMember]
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [DataMember]
        public string Address { get; set; }
        
        public Customer(string address)
        {
            Address = address;
        }
    }
}
