using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using System.Data.SqlClient;

namespace WcfServiceWithDatabaseAccess.DatabaseAccessLayer
{
    class CustomerAccess
    {
        readonly string connectionString;

        public CustomerAccess()
        {
            connectionString = "data Source=.; database=3SemDB; integrated security=true";
        }

        public bool SaveCustomer(Customer aCustomer)
        {
            bool wasInserted;

            string insertString = "insert into Customer(firstname, lastname, email, address) values(@FirstName, @LastName, @Email, @Address)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
                {
                    SqlParameter fNameParam = new SqlParameter("@Firstname", aCustomer.FirstName);
                    CreateCommand.Parameters.Add(fNameParam);
                    SqlParameter lNameParam = new SqlParameter("@LastName", aCustomer.LastName);
                    CreateCommand.Parameters.Add(lNameParam);
                    SqlParameter eMailParam = new SqlParameter("@Email", aCustomer.Email);
                    CreateCommand.Parameters.Add(eMailParam);
                    SqlParameter addressParam = new SqlParameter("@Address", aCustomer.Address);
                    CreateCommand.Parameters.Add(addressParam);
                    
                    con.Open();
                    // Execute save
                    int rowsAffected = CreateCommand.ExecuteNonQuery();
                    // Evaluate
                    wasInserted = (rowsAffected == 1);

                    return wasInserted;
                }

            }
        }
    }
}
