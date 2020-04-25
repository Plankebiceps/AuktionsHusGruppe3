using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.ControlLayer;

namespace WcfServiceWithDatabaseAccess.ServiceAccessLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in both code and config file together.
    public class CustomerService : ICustomerService
    {

        public bool AddCustomer(Customer customerToSave)
        {
            ControlCustomer ctrlCustomer = new ControlCustomer();
            return ctrlCustomer.InsertCustomer(customerToSave);
        }

        public bool LoginCustomer(string emailToLookUp, string passwordToVerify) {
            ControlCustomer ctrlCustomer = new ControlCustomer();
            return ctrlCustomer.LoginCustomer(emailToLookUp, passwordToVerify);
        }

        public Customer GetCustomerByEmail(string emailToFind) {
            ControlCustomer ctrlCustomer = new ControlCustomer();
            return ctrlCustomer.GetCustomerByEmail(emailToFind);
        }
    }
}
