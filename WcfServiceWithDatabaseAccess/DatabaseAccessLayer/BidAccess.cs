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

        //public void UpdateBid(Bid aBid)
        //{
        //    string insertString = "UPDATE Bid SET price=@price WHERE bidId=@bidId";

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
        //        {
        //            SqlParameter idParam = new SqlParameter("@bidId", aBid.BidId);
        //            CreateCommand.Parameters.Add(idParam);
        //            SqlParameter bidPrice = new SqlParameter("@price", aBid.Price);
        //            CreateCommand.Parameters.Add(bidPrice);

        //            con.Open();

        //            CreateCommand.ExecuteNonQuery();
        //        }
        //    }
        //}

        public bool SaveBid(Bid aBid) {

            Bid tempBid = new Bid();

            Customer tempCustomer = new Customer();
            Auction tempAuction = new Auction();

            decimal bidAmount = aBid.BidAmount;
            tempCustomer.Id = aBid.CustomerId;
            tempAuction.AuctionId = aBid.AuctionId;

            bool wasInserted;

            string insertString = "INSERT INTO Bid(bidAmount, customerId, auctionId) " +
                                  "VALUES (@bidAmount, @customerId, @auctionId)";

            using (SqlConnection con = new SqlConnection(connectionString)) {

                using (SqlCommand CreateCommand = new SqlCommand(insertString, con)) {

                    SqlParameter bidAmountParam = new SqlParameter("@bidAmount", bidAmount);
                    CreateCommand.Parameters.Add(bidAmountParam);
                    SqlParameter customerIdParam = new SqlParameter("@customerId", tempCustomer.Id);
                    CreateCommand.Parameters.Add(customerIdParam);
                    SqlParameter auctionIdParam = new SqlParameter("@auctionId", tempAuction.AuctionId);
                    CreateCommand.Parameters.Add(auctionIdParam);

                    con.Open();
                    // Execute save
                    int rowsAffected = CreateCommand.ExecuteNonQuery();
                    // Evaluate
                    wasInserted = (rowsAffected == 6);

                    return wasInserted;
                }

            }
        }

        //public bool SaveBid(Bid newBid, Customer aBidder)
        //{
        //    bool wasInserted;
        //    string insertString = "insert into Bid(price, customerId) VALUES (@price, @customerId)";

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
        //        {

        //            //Prepare SQL
        //            SqlParameter bidPrice = new SqlParameter("@price", newBid.Price);
        //            CreateCommand.Parameters.Add(bidPrice);
        //            SqlParameter customerId = new SqlParameter("@customerId", );



        //        }
        //    }

        //}
    }
}
