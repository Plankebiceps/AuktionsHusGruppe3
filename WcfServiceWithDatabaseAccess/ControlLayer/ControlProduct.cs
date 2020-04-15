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

        public Product CreateProduct(Product productToCreate)
        {
            Product createdProduct = null;
            Auction tempAuction = null;



            // Opret Product og send til DB
            ProductAccess productDb = new ProductAccess();
            createdProduct = productDb.CreateToDb(productToCreate);

            // Opret Auction - og send til DB
            ControlAuction controlAuction = new ControlAuction();
            controlAuction.CreateAuction(tempAuction);

            // Hent Auction ID
            AuctionAccess auctionAccess = new AuctionAccess();
            auctionAccess.CreateToDb(tempAuction);

            int tempId = tempAuction.AuctionId;

            // Opdatér Product med udhentet Auction ID
            createdProduct.AuctionId = tempId;


            // Returnér
            return createdProduct;

        }
    }
}
