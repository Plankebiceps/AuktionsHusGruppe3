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

            bool wasInserted;
            string insertString = "insert into Auction(timeLeft, payment, result, paymentDate, productName, productDescription) output " +
                                  "INSERTED.Id VALUES (@timeLeft, @payment, @result, @paymentDate, @productName, @productDescription)";

            using (TransactionScope scope = new TransactionScope()) {
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

                        scope.Complete();

                        return wasInserted;

                    }
                }
            }
        }

        public void DeleteFromDb(int auctionId) {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                con.Open();
                using (SqlCommand cmdDeleteAuction = con.CreateCommand()) {
                    cmdDeleteAuction.CommandText = "DELETE FROM Auction WHERE id=@id";
                    cmdDeleteAuction.Parameters.AddWithValue("id", auctionId);
                    cmdDeleteAuction.ExecuteNonQuery();
                }
            }
        }

        public Auction GetAuctionById(int findAuctionId) {
            Auction foundAuction = new Auction();

            string queryString = "SELECT id, timeLeft, payment, result, paymentDate, productName, productDescription FROM Auction WHERE id = @id";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand readCommand = new SqlCommand(queryString, con)) {


                    SqlParameter idParam = new SqlParameter("@id", findAuctionId);
                    readCommand.Parameters.Add(idParam);

                    con.Open();

                    SqlDataReader reader = readCommand.ExecuteReader();
                    while (reader.Read()) {
                        foundAuction.AuctionId = reader.GetInt32(reader.GetOrdinal("id"));
                        foundAuction.TimeLeft = reader.GetDateTime(reader.GetOrdinal("timeLeft"));
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

        public void ModifySavedAuction(Auction anAuction) {

            string insertString = "UPDATE Auction SET timeLeft=@timeLeft, payment=@payment, result=@result, paymentDate=@paymentDate, " +
                                  "productName=@productName, productDescription=@productDescription WHERE id=@id";

            using (TransactionScope scope = new TransactionScope()) {
                using (SqlConnection con = new SqlConnection(connectionString)) {

                    using (SqlCommand CreateCommand = new SqlCommand(insertString, con)) {

                    SqlParameter idParam = new SqlParameter("@id", anAuction.AuctionId);
                    CreateCommand.Parameters.Add(idParam);
                    
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
                        /*int rowsAffected = */
                        int modified = CreateCommand.ExecuteNonQuery();

                        scope.Complete();
                        // Evaluate
                        //wasInserted = (rowsAffected == 6);

                        //return wasInserted;
                    }
                }
            }
        }

        public List<Auction> GetAllAuctions() {

            List<Auction> foundAuctions = null;
            Auction readAuction = null;

            string queryString = "select id, timeLeft, payment, result, paymentDate, " +
                                 "productName, productDescription from Auction";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, con)) {
                con.Open();
                // Execute read
                SqlDataReader auctionReader = readCommand.ExecuteReader();
                // Collect data
                if (auctionReader.HasRows) {
                    foundAuctions = new List<Auction>();
                    while (auctionReader.Read()) {
                        readAuction = GetAuctionFromReader(auctionReader);
                        foundAuctions.Add(readAuction);
                    }
                }
            }
            return foundAuctions;
        }

        public Auction GetAuctionFromReader(SqlDataReader auctionReader) {

            Auction foundAuction;
            int tempId;
            DateTime tempTimeLeft;
            bool tempPayment;
            string tempResult;
            DateTime tempPayDate;
            string tempProdNam;
            string tempProdDes;


            /* Kan ikke håndtere NULLS */
            tempId = auctionReader.GetInt32(auctionReader.GetOrdinal("id"));
            tempTimeLeft = auctionReader.GetDateTime(auctionReader.GetOrdinal("timeLeft"));
            tempPayment = auctionReader.GetBoolean(auctionReader.GetOrdinal("payment"));
            tempResult = auctionReader.GetString(auctionReader.GetOrdinal("result"));
            tempPayDate = auctionReader.GetDateTime(auctionReader.GetOrdinal("paymentDate"));
            tempProdNam = auctionReader.GetString(auctionReader.GetOrdinal("productName"));
            tempProdDes = auctionReader.GetString(auctionReader.GetOrdinal("productDescription"));
            foundAuction = new Auction(tempId, tempTimeLeft, tempPayment, tempResult, tempPayDate, tempProdNam, tempProdDes);
            return foundAuction;
        }




    }
}
    