using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using WcfServiceWithDatabaseAccess.ModelLayer;

namespace WcfServiceWithDatabaseAccess.ServiceAccessLayer {
   
    [ServiceContract]
    public interface ICustomerService {

        [OperationContract]
        bool AddCustomer(Customer customerToSave);

        [OperationContract]
        bool LoginCustomer(string emailToLookUp, string passwordToVerify);

        [OperationContract]
        Customer GetCustomerByEmail(string emailToFind);

        }
}
