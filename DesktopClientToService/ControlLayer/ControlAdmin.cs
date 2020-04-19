using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceLayer;
using proxyRef = DesktopClientToService.ServiceRefAdmin;
using clientRef = DesktopClientToService.ModelLayer;

namespace DesktopClientToService.ControlLayer {
    public class ControlAdmin {

        public clientRef.Admin CreateAdmin(string firstName, string lastName, string email, string password) {
            clientRef.Admin admin = new clientRef.Admin {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            AdminService adminService = new AdminService();
            return adminService.CreateAdmin(admin);
        }

        //public ModelLayer.Admin LoginAdmin(Admin adminToLogin) {
        //    AdminService adminService = new AdminService();
        //    return adminService.LoginAdmin(adminToLogin);
        //}

    }
}
