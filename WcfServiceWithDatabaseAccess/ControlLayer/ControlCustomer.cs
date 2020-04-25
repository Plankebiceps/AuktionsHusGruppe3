using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.DatabaseAccessLayer;
using WcfServiceWithDatabaseAccess.Utilities.Security;

namespace WcfServiceWithDatabaseAccess.ControlLayer
{
    public class ControlCustomer
    {
        public bool InsertCustomer(Customer customerToSave)
        {
            bool wasInsertedCorrectly;

            CustomerAccess customerDB = new CustomerAccess();
            wasInsertedCorrectly = customerDB.SaveCustomer(customerToSave);

            return wasInsertedCorrectly;
        }

        public bool LoginCustomer(string emailToLookUp, string passwordToVerify) {
            bool wasIdentified;

            CustomerAccess customberDb = new CustomerAccess();
            wasIdentified = customberDb.LoginCustomer(emailToLookUp, passwordToVerify);

            return wasIdentified;
        }
    }
}
