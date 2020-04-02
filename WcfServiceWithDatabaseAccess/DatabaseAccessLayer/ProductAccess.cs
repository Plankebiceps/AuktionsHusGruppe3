using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using System.Data.SqlClient;


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
            Product foundProduct = null;
            string queryString = "select productId, name, description from Product where productId = @ProductId";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con))
            {
                
            }
            return foundProduct;
        }

     }
}
