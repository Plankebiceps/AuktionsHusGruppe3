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
using System.Diagnostics;
using System.Configuration;

namespace WcfServiceWithDatabaseAccess.DatabaseAccessLayer {
    public class AdminAccess {
        readonly string connectionString;


        public AdminAccess() {
            connectionString = "data Source=.; database=3SemDB; integrated security=true";
        }

        public Admin CreateToDb(Admin anAdmin) {
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
                return anAdmin;
            }
        }


        public bool LoginAdmin(string emailToLookUp, string passwordToVerify) {
            using (TransactionScope scope = new TransactionScope()) {   /* TransactionScope mangler funktionalitet */

                Admin adminToLogin = null;
                bool isPasswordMatched;

                string queryString = "SELECT adminEmail, salt, hash FROM Admin WHERE adminEmail = @adminEmail";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand readCommand = new SqlCommand(queryString, con)) {

                    // Prepare SQL
                    SqlParameter emailParam = new SqlParameter("@adminEmail", emailToLookUp);
                    readCommand.Parameters.Add(emailParam);

                    con.Open();

                    // Execute read
                    SqlDataReader userReader = readCommand.ExecuteReader();

                    if (userReader.HasRows) {
                        string readEmail, readSalt, readHash;
                        while (userReader.Read()) {
                            readEmail = userReader.GetString(userReader.GetOrdinal("adminEmail"));
                            readSalt = userReader.GetString(userReader.GetOrdinal("salt"));
                            readHash = userReader.GetString(userReader.GetOrdinal("hash"));
                            adminToLogin = new Admin(readEmail, readSalt, readHash);
                        }
                    } else {  //såfremt userReader ikke finder en email, der matcher password i DB - skal rettes til (exception??)
                        throw new Exception();
                    }
                    return isPasswordMatched = HashSalt.VerifyPassword(passwordToVerify, adminToLogin.Salt, adminToLogin.Hash);
                }
            }
        }
    }
}

