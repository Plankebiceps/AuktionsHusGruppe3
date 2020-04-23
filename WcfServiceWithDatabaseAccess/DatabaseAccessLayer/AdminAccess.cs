using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using System.Data.SqlClient;
using System.Transactions;
using System.Data;
using WcfServiceWithDatabaseAccess.Utilities.Security;

namespace WcfServiceWithDatabaseAccess.DatabaseAccessLayer {
    public class AdminAccess {
        readonly string connectionString;


        public AdminAccess() {
            connectionString = "data Source=.; database=3SemDB; integrated security=true";
        }

        public Admin CreateToDb(Admin anAdmin) {
            Admin madeAdmin;
            using (SqlConnection con = new SqlConnection(connectionString)) {
                con.Open();
                using (SqlCommand cmdInsertAdmin = con.CreateCommand()) {
                    cmdInsertAdmin.CommandText = "INSERT INTO Admin(salt, hash, adminEmail) VALUES (@salt, @hash, @adminEmail)";

                    HashSalt hashSaltToSave = HashSalt.GenerateSaltedHash(64, anAdmin.Password);
                    anAdmin.Salt = hashSaltToSave.Salt;
                    anAdmin.Hash = hashSaltToSave.Hash;

                    cmdInsertAdmin.Parameters.AddWithValue("@salt", anAdmin.Salt);
                    cmdInsertAdmin.Parameters.AddWithValue("@hash", anAdmin.Hash);
                    cmdInsertAdmin.Parameters.AddWithValue("@adminEmail", anAdmin.Email);

                    cmdInsertAdmin.ExecuteNonQuery();
                }
                madeAdmin = anAdmin;
                return madeAdmin;
            }
        }


        public Admin GetAdminByEmail(string emailToLookUp) {
            using (TransactionScope scope = new TransactionScope()) {
                Admin adminToGet = null;

                string queryString = "select adminEmail, salt, hash from Admin where adminEmail = @adminEmail";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand readCommand = new SqlCommand(queryString, con)) {

                    // Prepare SQL
                    SqlParameter emailParam = new SqlParameter("@adminEmail", emailToLookUp);
                    readCommand.Parameters.Add(emailParam);

                    con.Open();

                    // Execute read
                    SqlDataReader userReader = readCommand.ExecuteReader();

                    if (userReader.HasRows) {
                        string tempEmail, tempSalt, tempHash;
                        while (userReader.Read()) {
                            tempEmail = userReader.GetString(userReader.GetOrdinal("adminEmail"));
                            tempSalt = userReader.GetString(userReader.GetOrdinal("hash"));
                            tempHash = userReader.GetString(userReader.GetOrdinal("salt"));
                            adminToGet = new Admin(tempEmail, tempSalt, tempHash);
                        }
                    }
                }
                return adminToGet;
            }
        }



    }
}

