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
            Auction madeAuction = null;
            int insertedId = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmdInsertAuc = con.CreateCommand())
                {
                    cmdInsertAuc.CommandText = "insert into Auction(timeLeft, payment, result, paymentDate) output INSERTED.auctionId VALUES (@timeLeft, @payment, @result, @paymentDate)";
                    cmdInsertAuc.Parameters.AddWithValue("timeLeft", aAuction.TimeLeft);
                    cmdInsertAuc.Parameters.AddWithValue("payment", aAuction.Payment);
                    cmdInsertAuc.Parameters.AddWithValue("result", aAuction.Result);
                    cmdInsertAuc.Parameters.AddWithValue("paymentDate", aAuction.PaymentDate);
                    insertedId = (int)cmdInsertAuc.ExecuteScalar();
                }
            }
            madeAuction = aAuction;
            madeAuction.AuctionId = insertedId;
            return madeAuction;
            //}
        }
    }
}
