using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using System.Data.SqlClient;
using System.Transactions;

namespace WcfServiceWithDatabaseAccess.DatabaseAccessLayer
{
     public class ProductAccess
     {
        readonly string connectionString;
        public ProductAccess() 
        {
            connectionString = "data Source=.; database=3SemDB; integrated security=true"; 
        }

        public Product GetProductById(int findProductId)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Product foundProduct = null;
                string queryString = "select productId, name, description from Product where productId = @ProductId";
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand readCommand = new SqlCommand(queryString, con))
                {
                    //Prepace SQL
                    SqlParameter idParam = new SqlParameter("@ProductId", findProductId);
                    readCommand.Parameters.Add(idParam);

                    con.Open();

                    //Execute read
                    SqlDataReader productReader = readCommand.ExecuteReader();

                    if (productReader.HasRows)
                    {
                        int tempId;
                        string tempName, tempDescription;
                        while (productReader.Read())
                        {
                            tempId = productReader.GetInt32(productReader.GetOrdinal("productId"));
                            tempName = productReader.GetString(productReader.GetOrdinal("name"));
                            tempDescription = productReader.GetString(productReader.GetOrdinal("description"));
                            foundProduct = new Product(tempId, tempName, tempDescription);
                        }
                    }
                }
                return foundProduct; 
            }
        }

        public Product CreateToDb(Auction auction)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                int insertedId = 0;
                Product madeProduct = null;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmdInsertProd = con.CreateCommand())
                    {
                        cmdInsertProd.CommandText = "insert into Product(name, description, auctionId) output INSERTED.productId VALUES (@name, @description, @auctionId)";
                        cmdInsertProd.Parameters.AddWithValue("name", auction.product.Name);
                        cmdInsertProd.Parameters.AddWithValue("description", auction.product.Description);
                        cmdInsertProd.Parameters.AddWithValue("auctionId", auction.AuctionId);
                        insertedId = (int)cmdInsertProd.ExecuteScalar();
                    }
                }
                madeProduct = auction.product;
                madeProduct.ProductId = insertedId;
                return madeProduct;
            }
        }
    }
}
