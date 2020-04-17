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
    public class AuctionAccess
    {
        readonly string connectionString;


        public AuctionAccess()
        {
            connectionString = "data Source=.; database=3SemDB; integrated security=true";
        }

        public Auction CreateToDb(Auction aAuction)
        {
            //using (TransactionScope scope = new TransactionScope())
            //{
            Auction madeAuction;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmdInsertAuc = con.CreateCommand())
                {
                    cmdInsertAuc.CommandText = "insert into Auction(timeLeft, payment, result, paymentDate, productName, productDescription) output INSERTED.auctionId VALUES (@timeLeft, @payment, @result, @paymentDate, @productName, @productDescription)";
                    cmdInsertAuc.Parameters.AddWithValue("timeLeft", aAuction.TimeLeft);
                    cmdInsertAuc.Parameters.AddWithValue("payment", aAuction.Payment);
                    cmdInsertAuc.Parameters.AddWithValue("result", aAuction.Result);
                    cmdInsertAuc.Parameters.AddWithValue("paymentDate", aAuction.PaymentDate);
                    cmdInsertAuc.Parameters.AddWithValue("productName", aAuction.ProductName);
                    cmdInsertAuc.Parameters.AddWithValue("productDescription", aAuction.ProductDescription);
                    cmdInsertAuc.ExecuteScalar();



                }
            }
            madeAuction = aAuction;
            return madeAuction;
            //}

        }
        public Auction GetAuctionById(int findAuctionId)
        {
            Auction foundAuction = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmdFindAuction = con.CreateCommand())
                {
                    cmdFindAuction.CommandText = "select auctionId, timeLeft, payment, result, paymentDate, productName, productDescription FROM Auction WHERE AuctionId = @auctionId";
                    SqlDataReader reader = cmdFindAuction.ExecuteReader();
                    while (reader.Read())
                    {
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
        public void DeleteAuction(int DeletedById)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmdFindAuction = con.CreateCommand())
                {

                }
            }


        }
    }
}
