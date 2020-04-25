using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* To be removed notice "using" of References. One for Client ModelLayer
 * and one for the Service Reference --- No more using statements allowed in this class */
using proxyRef = DesktopClientToService.ServiceRefCustomer;
using clientRef = DesktopClientToService.ModelLayer;
using DesktopClientToService.Utilities;

namespace DesktopClientToService.ServiceLayer {
    public class CustomerService {

        public bool AddCustomer(clientRef.Customer customerToAdd) {
            bool allOk = false;
            proxyRef.Customer customerInServiceFormat = new ConvertDataCustomer().ConvertToServiceCustomer(customerToAdd);
            using (proxyRef.CustomerServiceClient customerProxy = new proxyRef.CustomerServiceClient()) {
                allOk = customerProxy.AddCustomer(customerInServiceFormat);
            }
            return allOk;
        }

        public bool LoginCustomer(string emailToLookUp, string passwordToVerify) {
            bool allOk = false;
            using (proxyRef.CustomerServiceClient customerProxy = new proxyRef.CustomerServiceClient()) {
                allOk = customerProxy.LoginCustomer(emailToLookUp, passwordToVerify);
            }
            return allOk;
        }
    }
}
