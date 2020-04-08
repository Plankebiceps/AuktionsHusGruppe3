using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopClientToService.ServiceLayer;
using DesktopClientToService.ServiceRefProduct;


namespace DesktopClientToService.ControlLayer
{
    public class ControlProduct
    {

        public Product CreateProduct(string name, string description)
        {
            Product product = new Product
            {
                Name = name,
                Description = description
            };

            ProductService ps = new ProductService();
            return ps.CreateProduct(product);
        }

        public Product GetProductById(int inputId)
        {
            ProductService ps = new ProductService();
            return ps.GetProductById(inputId);
        }
    }
}