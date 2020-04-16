using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.ControlLayer;

namespace WcfServiceWithDatabaseAccess.ServiceAccessLayer
{
    public class AdminLoginService : IAdminLoginService
    {
        public Admin CreateAdmin(Admin adminToCreate)
        {
            ControlLoginAdmin ctrlLoginAdmin = new ControlLoginAdmin();
            return ctrlLoginAdmin.CreateAdmin(adminToCreate);
        }

        public Admin LoginAdmin(Admin loginAdmin)
        {
            throw new NotImplementedException();
        }
    }
}
