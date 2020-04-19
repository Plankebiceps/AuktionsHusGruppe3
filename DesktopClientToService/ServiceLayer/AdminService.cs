using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


            //proxyRef.AdminServiceClient adminProxy = new proxyRef.AdminServiceClient();
            //clientRef.Admin aProxyAdmin = adminProxy.CreateAdmin(adminToCreate);

            //return aProxyAdmin;
        }

        //public ModelLayer.Admin LoginAdmin(Admin adminToLogin) {

        //    ModelLayer.Admin convertedAdmin = null;
        //    ServiceRefAdmin.Admin aProxyAdmin = null;

        //    using (AdminServiceClient adminProxy = new AdminServiceClient()) {
        //        aProxyAdmin = adminProxy.LoginAdmin(adminToLogin);
        //    }
        //    if (aProxyAdmin != null) {
        //        convertedAdmin = new ConvertDataAdmin().ConvertFromServiceAdmin(aProxyAdmin);
        //    }
        //    return convertedAdmin;
        //}

    }
}

