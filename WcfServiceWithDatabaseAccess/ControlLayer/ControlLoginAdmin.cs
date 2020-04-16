using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.DatabaseAccessLayer;

namespace WcfServiceWithDatabaseAccess.ControlLayer
{
    public class ControlLoginAdmin
    {
        public Admin CreateAdmin(Admin adminToCreate)
        {
            Admin createdAdmin;

            LoginAdminAccess loginAdminDb = new LoginAdminAccess();
            createdAdmin = loginAdminDb.CreateToDb(adminToCreate);

            return createdAdmin;
        }

        //public Admin LoginAdmin(Admin loginAdmin)
        //{
        //    Admin loggedAdmin;

        //    LoginAdminAccess loginAdminDb = new LoginAdminAccess();
        //    loggedAdmin = loginAdminDb.LoginToDb(loginAdmin);

        //    return loggedAdmin;
        //}
    }
}
