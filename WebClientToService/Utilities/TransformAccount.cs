using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClientToService.Models;
using WebClientToService.ServiceRefCustomer;

namespace WebClientToService.Utilities
{
    public class TransformAccount
    {
        public ServiceRefCustomer.Customer WebConvertToServiceCustomer(Models.WebCustomer webCustomerToAdd)
        {
            ServiceRefCustomer.Customer webServiceCustomer = null;
            if (webCustomerToAdd != null)
            {
               webServiceCustomer  = new ServiceRefCustomer.WebCustomer
                {
                    Id = webCustomerToAdd.Id,
                    FirstName = webCustomerToAdd.FirstName,
                    LastName = webCustomerToAdd.LastName,
                    Address = webCustomerToAdd.Address,
                    Email = webCustomerToAdd.CustomerEmail,
                    Salt = webCustomerToAdd.Salt,
                    Hash = webCustomerToAdd.Hash
                };
            }
            return webServiceCustomer;
        }
    }
}