﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceWithDatabaseAccess.ModelLayer
{
    [DataContract]
    class Customer : Person
    {
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string CustomerEmail { get; set; }

        public Customer(string address, string customerEmail)
        {
            Address = address;
            CustomerEmail = customerEmail;
        }
    }
}
