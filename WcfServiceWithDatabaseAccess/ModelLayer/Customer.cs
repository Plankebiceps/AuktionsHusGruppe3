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
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Address { get; set; }

        public Customer(string firstName, string lastName, string email, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;

        }
        public Customer()
        {

        }
    
    }
}
