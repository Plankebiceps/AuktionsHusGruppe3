using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClientToService.Models
{
    public class WebCustomer
    {
        public string Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CustomerEmail { get; set; }

        public string Hash { get; set; }

        public string Salt { get; set; }

        public WebCustomer(string email, string hash, string salt)
        {
            CustomerEmail = email;
            Hash = hash;
            Salt = salt;
        }

        public WebCustomer()
        {

        }
    }
}