using System;
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
    public interface IProductService
    {
        [OperationContract]
        Product GetProductById(int productId);

        [OperationContract]
        Product CreateProduct(Auction productToCreate);

        [OperationContract]
        Product DeleteProduct(int productId);

        [OperationContract]
        Product ModifyProduct(string name, string description);
    }
}
