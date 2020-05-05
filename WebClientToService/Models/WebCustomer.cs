using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClientToService.Models
{
    public class WebCustomer
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Address { get; set; }
        [Required, StringLength(30)]
        public string FirstName { get; set; }
        [Required, StringLength(30)]
        public string LastName { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string Hash { get; set; }

        public string Salt { get; set; }

        public WebCustomer(string email, string hash, string salt)
        {
            Email = email;
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
            Email = email;
            Hash = hash;
            Salt = salt;
        }
    }
}