using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    public class Admin
    {


        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Hash { get; set; }
        [DataMember]
        public string Salt { get; set; }
        [DataMember]
        public string Password { get; set; }

        public Admin() {

        }

        public Admin(string email, string hash, string salt) {
            Email = email;
            Hash = hash;
            Salt = salt;
        }
    }   
}
