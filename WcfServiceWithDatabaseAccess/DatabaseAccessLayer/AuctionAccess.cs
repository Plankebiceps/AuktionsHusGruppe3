using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using System.Data.SqlClient;
using System.Transactions;

namespace WcfServiceWithDatabaseAccess.DatabaseAccessLayer {
    public class AuctionAccess {
        readonly string connectionString;


        public AuctionAccess() {
            connectionString = "data Source=.; database=3SemDB; integrated security=true";
        }


        public bool SaveAuction(Auction anAuction) {

            //using (TransactionScope scope = new TransactionScope())
            //{
            bool wasInserted;
            string insertString = "insert into Auction(timeLeft, payment, result, paymentDate, productName, productDescription) output " +
                                  "INSERTED.auctionId VALUES (@timeLeft, @payment, @result, @paymentDate, @productName, @productDescription)";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                
                using (SqlCommand CreateCommand = new SqlCommand(insertString, con)) {
                    
                    //Prepace SQL
                    SqlParameter timeLeftParam = new SqlParameter("@timeLeft", anAuction.TimeLeft);
                    CreateCommand.Parameters.Add(timeLeftParam);
                    SqlParameter paymentParam = new SqlParameter("@payment", anAuction.Payment);
                    CreateCommand.Parameters.Add(paymentParam);
                    SqlParameter resultParam = new SqlParameter("@result", anAuction.Result);
                    CreateCommand.Parameters.Add(resultParam);
                    SqlParameter payDateParam = new SqlParameter("@paymentDate", anAuction.PaymentDate);
                    CreateCommand.Parameters.Add(payDateParam);
                    SqlParameter prodNameParam = new SqlParameter("@productName", anAuction.ProductName);
                    CreateCommand.Parameters.Add(prodNameParam);
                    SqlParameter prodDescriptParam = new SqlParameter("@productDescription", anAuction.ProductDescription);
                    CreateCommand.Parameters.Add(prodDescriptParam);

                    con.Open();
                    // Execute save
                    int rowsAffected = CreateCommand.ExecuteNonQuery();
                    // Evaluate
                    wasInserted = (rowsAffected == 6);

                    return wasInserted;

                }
            }
        }



        public void DeleteFromDb(int auctionId) {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                con.Open();
                using (SqlCommand cmdDeleteAuction = con.CreateCommand()) {
                    cmdDeleteAuction.CommandText = "DELETE FROM Auction WHERE AuctionId=@auctionId";
                    cmdDeleteAuction.Parameters.AddWithValue("auctionId", auctionId);
                    cmdDeleteAuction.ExecuteNonQuery();
                }
            }
        }


        public Auction GetAuctionById(int findAuctionId) {
            Auction foundAuction = new Auction();

            string queryString = "select auctionId, timeLeft, payment, result, paymentDate, productName, productDescription FROM Auction WHERE auctionId = @auctionId";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand readCommand = new SqlCommand(queryString, con)) {


                    SqlParameter idParam = new SqlParameter("@AuctionId", findAuctionId);
                    readCommand.Parameters.Add(idParam);

                    con.Open();

                    SqlDataReader reader = readCommand.ExecuteReader();
                    while (reader.Read()) {
                        foundAuction.AuctionId = reader.GetInt32(reader.GetOrdinal("auctionId"));
                        foundAuction.TimeLeft = reader.GetDecimal(reader.GetOrdinal("timeLeft"));
                        foundAuction.Payment = reader.GetBoolean(reader.GetOrdinal("payment"));
                        foundAuction.Result = reader.GetString(reader.GetOrdinal("result"));
                        foundAuction.PaymentDate = reader.GetDateTime(reader.GetOrdinal("paymentDate"));
                        foundAuction.ProductName = reader.GetString(reader.GetOrdinal("productName"));
                        foundAuction.ProductDescription = reader.GetString(reader.GetOrdinal("productDescription"));
                    }
                }
            }
            return foundAuction;
        }

    }
}
    