using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceRefAdmin;


namespace DesktopClientToService.ServiceLayer {
    public class AdminService {

        public Admin CreateAdmin(Admin adminToCreate) {
            AdminServiceClient adminProxy = new AdminServiceClient();
            Admin aProxyAdmin = adminProxy.CreateAdmin(adminToCreate);

            return aProxyAdmin;
        }
    }
}
