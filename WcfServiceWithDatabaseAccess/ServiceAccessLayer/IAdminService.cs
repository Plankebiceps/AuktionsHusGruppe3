﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceWithDatabaseAccess.ModelLayer;

namespace WcfServiceWithDatabaseAccess.ServiceAccessLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        Admin CreateAdmin(Admin adminToCreate);

        [OperationContract]
        bool LoginAdmin(string emailToLookUp, string passwordToVerify);
    }
}
