using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceRefCustomer;
using DesktopClientToService.ModelLayer;

namespace DesktopClientToService.Utilities {
    public class ConvertDataCustomer {

        public ModelLayer.Customer ConvertFromServiceCustomer(ServiceRefCustomer.Customer serviceCustomer) {
            ModelLayer.Customer clientCustomer = null;
            if (serviceCustomer != null) {
                clientCustomer = new ModelLayer.Customer {
                    Id = serviceCustomer.Id,
                    Address = serviceCustomer.Address,
                    FirstName = serviceCustomer.FirstName,
                    LastName = serviceCustomer.LastName,
                    Email = serviceCustomer.Email,
                    Password = serviceCustomer.Password,
                    Salt = serviceCustomer.Salt,
                    Hash = serviceCustomer.Hash
                };
            }
            return clientCustomer;
        }

        public ServiceRefCustomer.Customer ConvertToServiceCustomer(ModelLayer.Customer desktopCustomer) {
            ServiceRefCustomer.Customer serviceCustomer = null;
            if (desktopCustomer != null) {
                serviceCustomer = new ServiceRefCustomer.Customer {
                    Id = desktopCustomer.Id,
                    Address = desktopCustomer.Address,
                    FirstName = desktopCustomer.FirstName,
                    LastName = desktopCustomer.LastName,
                    Email = desktopCustomer.Email,
                    Password = desktopCustomer.Password,
                    Salt = desktopCustomer.Salt,
                    Hash = desktopCustomer.Hash
                };
            }
            return serviceCustomer;
        }
    }
}
