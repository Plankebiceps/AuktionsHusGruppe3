using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* To be removed! --- Controller's can only know and use ServiceLayer and ModelLayer */
using DesktopClientToService.ServiceLayer;
using DesktopClientToService.ModelLayer;

namespace DesktopClientToService.ControlLayer {
    public class ControlCustomer {
        public bool AddCustomer(string firstName, string lastName, string address, string email, 
                                string password) {
            Customer customer = new Customer {
            FirstName = firstName,
            LastName = lastName,
            Address = address,
            Email = email,
            Password = password,
        };

            CustomerService customerService = new CustomerService();
            return customerService.AddCustomer(customer);
        }

        public bool LoginCustomer(string emailToLookUp, string passwordToVerify) {
            CustomerService customerService = new CustomerService();
            return customerService.LoginCustomer(emailToLookUp, passwordToVerify);
        }
    }
}
