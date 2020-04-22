using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using System.Data.SqlClient;
using System.Transactions;
using System.Data;

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

        public Admin LoginToDb(Admin anAdmin) {

            Admin adminToLogin;
            using (SqlConnection con = new SqlConnection(connectionString)) {
                con.Open();
                using (SqlCommand cmdSelectAdmin = con.CreateCommand()) {
                    cmdSelectAdmin.CommandText = "Select * from Admin where adminEmail=@adminEmail and password=@password";
                    cmdSelectAdmin.Parameters.AddWithValue("adminEmail", anAdmin.Email);
                    cmdSelectAdmin.Parameters.AddWithValue("password", anAdmin.Password);
                    cmdSelectAdmin.ExecuteScalar();
                }
                adminToLogin = anAdmin;
                return adminToLogin;

            }
        }
    }
}
