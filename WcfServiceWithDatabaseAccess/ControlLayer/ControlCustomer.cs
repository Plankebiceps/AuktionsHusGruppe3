using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.DatabaseAccessLayer;

namespace WcfServiceWithDatabaseAccess.ControlLayer
{
    class ControlCustomer
    {
        public bool InsertCustomer(Customer customerToSave)
        {
            bool wasInsertedCorrectly;

            CustomerAccess customerDB = new CustomerAccess();
            wasInsertedCorrectly = customerDB.SaveCustomer(customerToSave);

            return wasInsertedCorrectly;
        }
    }
}
