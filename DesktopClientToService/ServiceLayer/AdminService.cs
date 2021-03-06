﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* To be removed notice "using" of References. One for Client ModelLayer
 * and one for the Service Reference --- No more using statements allowed in this class */
using proxyRef = DesktopClientToService.ServiceRefAdmin;
using clientRef = DesktopClientToService.ModelLayer;
using DesktopClientToService.Utilities;



namespace DesktopClientToService.ServiceLayer {
    public class AdminService {

        public clientRef.Admin CreateAdmin(clientRef.Admin adminToCreate) {

            proxyRef.Admin adminInServiceFormat = new ConvertDataAdmin().ConvertToServiceAdmin(adminToCreate);

            using (proxyRef.AdminServiceClient adminProxy = new proxyRef.AdminServiceClient()) {
                adminProxy.CreateAdmin(adminInServiceFormat);
            }
            return adminToCreate;

        }

        public bool LoginAdmin(string emailToLookUp, string passwordToVerify) {
            bool allOk = false;
            using (proxyRef.AdminServiceClient adminProxy = new proxyRef.AdminServiceClient()) {
                allOk = adminProxy.LoginAdmin(emailToLookUp, passwordToVerify);
            }
            return allOk;
        }
    }
}

