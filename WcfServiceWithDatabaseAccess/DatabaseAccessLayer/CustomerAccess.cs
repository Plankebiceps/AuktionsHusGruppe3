﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceWithDatabaseAccess.ModelLayer;
using System.Data.SqlClient;
using WcfServiceWithDatabaseAccess.Utilities.Security;
using System.Transactions;

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
            //Customer tempCust = aCustomer;

            HashSalt hashSaltToSave = HashSalt.GenerateSaltedHash(64, aCustomer.Password);
            aCustomer.Salt = hashSaltToSave.Salt;
            aCustomer.Hash = hashSaltToSave.Hash;

            string insertString = "insert into Customer(address, firstName, lastName, customerEmail, hash, salt)" +
                                  "values(@Address, @FirstName, @LastName, @CustomerEmail, @Hash, @Salt)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand CreateCommand = new SqlCommand(insertString, con))
                {
                    SqlParameter addressParam = new SqlParameter("@Address", aCustomer.Address);
                    CreateCommand.Parameters.Add(addressParam);
                    SqlParameter fNameParam = new SqlParameter("@Firstname", aCustomer.FirstName);
                    CreateCommand.Parameters.Add(fNameParam);
                    SqlParameter lNameParam = new SqlParameter("@LastName", aCustomer.LastName);
                    CreateCommand.Parameters.Add(lNameParam);
                    SqlParameter eMailParam = new SqlParameter("@CustomerEmail", aCustomer.Email);
                    CreateCommand.Parameters.Add(eMailParam);
                    SqlParameter hashParam = new SqlParameter("@Hash", aCustomer.Hash);
                    CreateCommand.Parameters.Add(hashParam);
                    SqlParameter saltParam = new SqlParameter("@Salt", aCustomer.Salt);
                    CreateCommand.Parameters.Add(saltParam);

                    con.Open();
                    // Execute save
                    int rowsAffected = CreateCommand.ExecuteNonQuery();
                    // Evaluate
                    wasInserted = (rowsAffected == 1);

                    return wasInserted;
                }

            }
        }

        public bool LoginCustomer(string emailToLookUp, string passwordToVerify) {
            using (TransactionScope scope = new TransactionScope()) {   /* TransactionScope mangler funktionalitet */

                Customer customerToLogin = null;
                bool isPasswordMatched;

                string queryString = "SELECT customerEmail, salt, hash FROM Customer WHERE customerEmail = @customerEmail";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand readCommand = new SqlCommand(queryString, con)) {

                    // Prepare SQL
                    SqlParameter emailParam = new SqlParameter("@customerEmail", emailToLookUp);
                    readCommand.Parameters.Add(emailParam);

                    con.Open();

                    // Execute read
                    SqlDataReader userReader = readCommand.ExecuteReader();

                    if (userReader.HasRows) {
                        string readEmail, readSalt, readHash;
                        while (userReader.Read()) {
                            readEmail = userReader.GetString(userReader.GetOrdinal("customerEmail"));
                            readSalt = userReader.GetString(userReader.GetOrdinal("hash"));
                            readHash = userReader.GetString(userReader.GetOrdinal("salt"));
                            customerToLogin = new Customer(readEmail, readSalt, readHash);
                        }
                    } else {  //såfremt userReader ikke finder en email, der matcher password i DB - skal rettes til (exception??)
                        throw new Exception();
                    }
                    return isPasswordMatched = HashSalt.VerifyPassword(passwordToVerify, customerToLogin.Hash, customerToLogin.Salt);
                }
            }
        }

        public Customer GetCustomerByEmail(string emailToFind) {
            Customer foundCustomer = new Customer();

            string queryString = "SELECT id, address, firstName, lastName, customerEmail FROM Customer WHERE customerEmail = @customerEmail";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand readCommand = new SqlCommand(queryString, con)) {


                    SqlParameter idParam = new SqlParameter("@customerEmail", emailToFind);
                    readCommand.Parameters.Add(idParam);

                    con.Open();

                    SqlDataReader reader = readCommand.ExecuteReader();
                    while (reader.Read()) {
                        foundCustomer.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        foundCustomer.Address = reader.GetString(reader.GetOrdinal("address"));
                        foundCustomer.FirstName = reader.GetString(reader.GetOrdinal("firstName"));
                        foundCustomer.LastName = reader.GetString(reader.GetOrdinal("lastName"));
                        foundCustomer.Email = reader.GetString(reader.GetOrdinal("customerEmail"));

                    }
                }
            }
            return foundCustomer;
        }
    }
}
