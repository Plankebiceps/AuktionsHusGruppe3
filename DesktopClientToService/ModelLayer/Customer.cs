using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClientToService.ModelLayer {
    public class Customer {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }



        public Customer(string email, string hash, string salt) {
            Email = email;
            Hash = hash;
            Salt = salt;

        }
        public Customer() {

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
