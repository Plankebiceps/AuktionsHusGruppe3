using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Hash { get; set; }
        [DataMember]
        public string Salt { get; set; }



        public Customer(string email, string hash, string salt)
        {
            Email = email;
            Hash = hash;
            Salt = salt;

        }
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string address, string email, string hash, string salt) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            Hash = hash;
            Salt = salt;
        }
    }
}
