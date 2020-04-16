using DesktopClientToService.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DesktopClientToService.ServiceRefAuction;

namespace DesktopClientToService.Utilities
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    public interface IService1
    {
        Auction ConvertFromServiceAuction(Auction aAuction);
        //Person ConvertToServicePerson(Employee employeePerson);
    }
    
}
