using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.ControlLayer;

namespace WcfServiceWithDatabaseAccess.ServiceAccessLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AdminService : IAdminService
    {
        public Admin CreateAdmin(Admin adminToCreate) {
            ControlAdmin ctrlAdmin = new ControlAdmin();
            return ctrlAdmin.CreateAdmin(adminToCreate);
        }

        public void DoWork()
        {
        }

        public Admin LoginAdmin(Admin loginAdmin) {
            throw new NotImplementedException();
        }
    }
}
