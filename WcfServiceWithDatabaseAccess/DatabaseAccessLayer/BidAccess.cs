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
    public class BidAccess
    {
        readonly string connectionString;

        public BidAccess()
        {
            connectionString = "data Source=.; database=3SemDB; integrated security=true";
        }

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

            using (TransactionScope scope = new TransactionScope()) {
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

                        scope.Complete();

                        return wasInserted;
                    }
                }
            }
        }

        public Bid GetBidById(int bidId)
        {
            Bid foundBid = new Bid();

            string queryString = "SELECT bidAmount, customerId, auctionId FROM Bid WHERE auctionId = @auctionId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand readCommand = new SqlCommand(queryString, con))
                {


                    SqlParameter idParam = new SqlParameter("@auctionId", bidId);
                    readCommand.Parameters.Add(idParam);

                    con.Open();

                    SqlDataReader reader = readCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        foundBid.BidAmount = reader.GetDecimal(reader.GetOrdinal("bidAmount"));
                        foundBid.CustomerId = reader.GetInt32(reader.GetOrdinal("customerId"));
                        foundBid.AuctionId = reader.GetInt32(reader.GetOrdinal("auctionId"));

                    }
                }
            }
            return foundBid;
        }

        public List<Bid> GetAllBids(int auctionId) {

            List<Bid> foundBids = null;
            Bid foundBid = null;

            string queryString = "SELECT bidAmount, customerId, auctionId FROM Bid WHERE auctionId = @auctionId";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con)) {

                SqlParameter idParam = new SqlParameter("auctionId", auctionId);
                readCommand.Parameters.Add(idParam);

                con.Open();
                // Execute read
                SqlDataReader bidReader = readCommand.ExecuteReader();
                // Collect data
                if (bidReader.HasRows) {
                    foundBids = new List<Bid>();
                    while (bidReader.Read()) {
                        foundBid = GetBidFromReader(bidReader);
                        foundBids.Add(foundBid);
                    }
                }
            }
            return foundBids;
        }

        public Bid GetBidFromReader(SqlDataReader bidReader) {

            Bid foundBid;
            decimal tempBidAmount;
            int tempAuctionId;
            int tempCustId;

            /* Kan ikke håndtere NULLS */
            tempAuctionId = bidReader.GetInt32(bidReader.GetOrdinal("auctionId"));
            tempBidAmount = bidReader.GetDecimal(bidReader.GetOrdinal("bidAmount"));
            tempCustId = bidReader.GetInt32(bidReader.GetOrdinal("customerId"));
            foundBid = new Bid(tempBidAmount, tempAuctionId, tempCustId);
            return foundBid;
        }

    }
}
