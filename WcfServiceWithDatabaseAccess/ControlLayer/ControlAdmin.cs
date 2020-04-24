using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.DatabaseAccessLayer;
using WcfServiceWithDatabaseAccess.Utilities.Security;

namespace WcfServiceWithDatabaseAccess.ControlLayer
{
    public class ControlAdmin {
        public Admin CreateAdmin(Admin adminToCreate)
        {
            Admin createdAdmin;

            AdminAccess adminDb = new AdminAccess();
            createdAdmin = adminDb.CreateToDb(adminToCreate);

            return createdAdmin;
        }

        public bool LoginAdmin(string emailToLookUp, string passwordToVerify) {
            bool wasIdentified;

            AdminAccess adminDb = new AdminAccess();
            wasIdentified = adminDb.LoginAdmin(emailToLookUp, passwordToVerify);

            return wasIdentified;
        }
    }
}
