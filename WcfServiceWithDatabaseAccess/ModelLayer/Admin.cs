using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    public class Admin : Person
    {
        [DataMember]
        public string FirstName { get; set; }
        
        [DataMember]
        public string LastName { get; set; }
        
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

        public Admin(string password)
        {
            Password = password;
        }

        public Admin() {

        }
    }   
}
