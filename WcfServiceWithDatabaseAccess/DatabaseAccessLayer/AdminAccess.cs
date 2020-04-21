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
    public class AdminAccess
    {
        readonly string connectionString;


        public AdminAccess()
        {
            connectionString = "data Source=.; database=3SemDB; integrated security=true";
        }

        public Admin CreateToDb(Admin anAdmin)
        {
            Admin madeAdmin;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmdInsertAdmin = con.CreateCommand())
                {
                    cmdInsertAdmin.CommandText = "INSERT INTO Admin(adminEmail, password) VALUES (@adminEmail, @password)";
                    cmdInsertAdmin.Parameters.AddWithValue("adminEmail", anAdmin.Email);
                    cmdInsertAdmin.Parameters.AddWithValue("password", anAdmin.Password);
                    cmdInsertAdmin.ExecuteNonQuery();
                }
                madeAdmin = anAdmin;
                return madeAdmin;
            }
        }

        public Admin LoginToDb(Admin aAdmin) {
            Admin adminToLogin = new Admin();

            string queryString = "SELECT email FROM Person WHERE email = @Email";

            using (SqlConnection con = new SqlConnection(connectionString)) {
            using (SqlCommand readCommand = new SqlCommand(queryString, con)) {

                    SqlParameter emailParam = new SqlParameter("@Email", aAdmin.Email);
                    readCommand.Parameters.Add(emailParam);

                    con.Open();

                    SqlDataReader reader = readCommand.ExecuteReader();
                    while (reader.Read()) {
                        adminToLogin.Email = reader.GetString(reader.GetOrdinal("email"));
                        adminToLogin.Password = reader.GetString(reader.GetOrdinal("password"));
                    }
                }
            }
            return adminToLogin;

        }
    }
}
