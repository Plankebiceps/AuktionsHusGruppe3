using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    class UserAdmin : Person
    {
        [DataMember]
        public string UserAdminEmail { get; set; }

        public UserAdmin(string userAdminEmail)
        {
            UserAdminEmail = userAdminEmail;
        }
    }   
}
