using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceRefProduct;

namespace DesktopClientToService.ServiceLayer
{
    public class ProductService
    {
        public Product GetProductById(int inputId)
        {
            ProductServiceClient productProxy = new ProductServiceClient();
            Product aProxyProduct = productProxy.GetProductById(inputId);

            return aProxyProduct;
        }
    }
}
