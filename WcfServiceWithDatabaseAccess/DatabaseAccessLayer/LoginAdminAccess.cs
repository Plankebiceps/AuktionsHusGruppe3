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
    public class LoginAdminAccess
    {
        readonly string connectionString;


        public LoginAdminAccess()
        {
            connectionString = "data Source=.; database=3SemDB; integrated security=true";
        }

        public Admin CreateToDb(Admin aAdmin)
        {
            Admin madeAdmin;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmdInsertAdmin = con.CreateCommand())
                {
                    cmdInsertAdmin.CommandText = "INSERT INTO Person(firstName, lastName, email) VALUES (@firstName, @lastName, @email) INSERT INTO Admin(password) VALUES (@password)";
                    cmdInsertAdmin.Parameters.AddWithValue("firstName", aAdmin.FirstName);
                    cmdInsertAdmin.Parameters.AddWithValue("lastName", aAdmin.LastName);
                    cmdInsertAdmin.Parameters.AddWithValue("email", aAdmin.Email);
                    cmdInsertAdmin.Parameters.AddWithValue("password", aAdmin.Password);
                    cmdInsertAdmin.ExecuteNonQuery();
                }
                madeAdmin = aAdmin;
                return madeAdmin;
            }
        }
    }
}
