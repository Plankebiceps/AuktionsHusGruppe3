using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    class Person
    {
        public interface IPerson
        {
            string FirstName { get; set; }
            string LastName { get; set; }
        }
    }
}
