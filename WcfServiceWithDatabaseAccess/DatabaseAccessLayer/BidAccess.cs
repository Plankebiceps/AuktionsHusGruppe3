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

        public bool UpdateBid(Bid aBid)
        {
            bool wasInserted;
            decimal bidMade;
            string insertString = "insert into Bid(price, auctionId) VALUES (@price, @auctionId)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
                {

                    //Prepace SQL
                    SqlParameter priceParam = new SqlParameter("@price", aBid.Price);
                    CreateCommand.Parameters.Add(priceParam);

                    return wasInserted;
                }
            }
        }
    }
}
