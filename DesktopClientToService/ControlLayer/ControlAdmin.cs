using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceLayer;
using DesktopClientToService.ServiceRefAdmin;

namespace DesktopClientToService.ControlLayer {
    public class ControlAdmin {

        //public Admin CreateAdmin() {

        //    Admin admin = new Admin();

        //    AdminService adminService = new AdminService();
        //    return adminService.CreateAdmin(admin);
        //}

        public Admin CreateAdmin(string firstName, string lastName, string email, string password) {
            Admin admin = new Admin {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            AdminService adminService = new AdminService();
            return adminService.CreateAdmin(admin);
        }

    }
}
