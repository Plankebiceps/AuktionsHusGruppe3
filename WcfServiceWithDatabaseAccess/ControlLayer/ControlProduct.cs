using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using WcfServiceWithDatabaseAccess.DatabaseAccessLayer;

namespace WcfServiceWithDatabaseAccess.ControlLayer
{
    public class ControlProduct
        {
        public Product GetProductById(int findProductId)
        {
            Product foundProduct = null;

            ProductAccess productDb = new ProductAccess();
            foundProduct = productDb.GetProductById(findProductId);

            return foundProduct;
        }

        public Product CreateProduct(Auction productToCreate)
        {

            Product createdProduct = null;

            ProductAccess productDb = new ProductAccess();
            createdProduct = productDb.CreateToDb(productToCreate);

            return createdProduct;
        }
    }
}
