using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceRefAdmin;
using DesktopClientToService.Utilities;



namespace DesktopClientToService.ServiceLayer {
    public class AdminService {

        public Admin CreateAdmin(Admin adminToCreate) {
            AdminServiceClient adminProxy = new AdminServiceClient();
            Admin aProxyAdmin = adminProxy.CreateAdmin(adminToCreate);

            return aProxyAdmin;
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

