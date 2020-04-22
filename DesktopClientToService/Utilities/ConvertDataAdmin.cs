﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceRefAuction;
using DesktopClientToService.ModelLayer;

namespace DesktopClientToService.Utilities {
    public class ConvertDataAdmin {

        public ModelLayer.Admin ConvertFromServiceAdmin(ServiceRefAdmin.Admin serviceAdmin) {
            ModelLayer.Admin clientAdmin = null;
            if (serviceAdmin != null) {
                clientAdmin = new ModelLayer.Admin {
                    FirstName = serviceAdmin.FirstName,
                    LastName = serviceAdmin.LastName,
                    Email = serviceAdmin.Email,
                    Password = serviceAdmin.Password,

                };
            }
            return clientAdmin;
        }

        public ServiceRefAdmin.Admin ConvertToServiceAdmin(ModelLayer.Admin desktopAdmin) {
            ServiceRefAdmin.Admin serviceAdmin = null;
            if (desktopAdmin != null) {
                serviceAdmin = new ServiceRefAdmin.Admin {
                    FirstName = desktopAdmin.FirstName,
                    LastName = desktopAdmin.LastName,
                    Email = desktopAdmin.Email,
                    Password = desktopAdmin.Password,
                };
            }
            return serviceAdmin;
        }
    }
}
