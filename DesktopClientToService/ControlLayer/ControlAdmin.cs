using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* To be removed! --- Controller's can only know and use ServiceLayer and ModelLayer */
using DesktopClientToService.ServiceLayer;
using DesktopClientToService.ModelLayer;

namespace DesktopClientToService.ControlLayer {
    public class ControlAdmin {

        public Admin CreateAdmin(string email, string password) {
            Admin admin = new Admin {
                Email = email,
                Password = password
            };

            AdminService adminService = new AdminService();
            return adminService.CreateAdmin(admin);
        }

        public ModelLayer.Admin LoginAdmin(string email, string password) {
            Admin admin = new Admin {
                Email = email,
                Password = password
            };

            AdminService adminService = new AdminService();
            return adminService.LoginAdmin(admin);
        }

        public Admin GetAdminByEmail(string emailToLookUp) {
            AdminService adminService = new AdminService();
            return adminService.GetAdminByEmail(emailToLookUp);
        }

    }
}
