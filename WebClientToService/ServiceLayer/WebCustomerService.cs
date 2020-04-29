using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClientToService.Utilities;
using clientRef = WebClientToService.Models;
using proxyRefCus = WebClientToService.ServiceRefCustomer;


namespace WebClientToService.ServiceLayer
{
    public class WebCustomerService
    {
        public bool CreateCustomerAccount(clientRef.WebCustomer webCustomerToAdd)
        {
            bool webAllOk = false;
            proxyRefCus.Customer customerInServiceFormat = new Account().WebConvertToServiceCustomer(webCustomerToAdd);
            using (proxyRefCus.CustomerServiceClient customerProxy = new proxyRefCus.CustomerServiceClient())
            {
                webAllOk = customerProxy.AddCustomer(customerInServiceFormat);
            }
            return webAllOk;
        }

        public bool LoginCustomer(string emailToLookUp, string passwordToVerify)
        {
            bool webAllOk = false;
            using (proxyRefCus.CustomerServiceClient customerProxy = new proxyRefCus.CustomerServiceClient())
            {
                webAllOk = customerProxy.LoginCustomer(emailToLookUp, passwordToVerify);
            }
            return webAllOk;
        }
    }
}