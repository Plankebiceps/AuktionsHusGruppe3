using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using System.Data.SqlClient;

namespace WcfServiceWithDatabaseAccess.DatabaseAccessLayer
{
    public class BidAccess
    {
        readonly string connectionString;

        public BidAccess()
        {
            connectionString = "data Source=.; database=3SemDB; integrated security=true";
        }

        public void UpdateBid(Bid aBid)
        {
            string insertString = "UPDATE Bid SET price=@price WHERE bidId=@bidId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
                {
                    SqlParameter idParam = new SqlParameter("@bidId", aBid.BidId);
                    CreateCommand.Parameters.Add(idParam);
                    SqlParameter bidPrice = new SqlParameter("@price", aBid.Price);
                    CreateCommand.Parameters.Add(bidPrice);

                    con.Open();

                    CreateCommand.ExecuteNonQuery();
                }
            }
        }

        public bool SaveBid(Bid newBid, Customer aBidder)
        {
            bool wasInserted;
            string insertString = "insert into Bid(price, customerId) VALUES (@price, @customerId)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
                {

                    //Prepare SQL
                    SqlParameter bidPrice = new SqlParameter("@price", newBid.Price);
                    CreateCommand.Parameters.Add(bidPrice);
                    SqlParameter customerId = new SqlParameter("@customerId", );


                    return wasInserted;
                }
            }

        }
    }
}
