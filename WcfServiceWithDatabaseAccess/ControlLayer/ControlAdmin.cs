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

        public Admin GetAdminByEmail(string emailToLookUp, string passwordToVerify) {
            Admin foundAdmin;

            AdminAccess adminDb = new AdminAccess();
            foundAdmin = adminDb.GetAdminByEmail(emailToLookUp, passwordToVerify);

            return foundAdmin;
        }
    }
}
