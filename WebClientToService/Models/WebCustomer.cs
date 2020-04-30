using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClientToService.Models
{
    public class WebCustomer
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string Password { get; set; }

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

        public WebCustomer(int id, string firstName, string lastName, string address, string email, string hash, string salt)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            CustomerEmail = email;
            Hash = hash;
            Salt = salt;
        }
    }
}