using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using gamestopFinal.DataModels;

namespace gamestopFinal.DataAccessLayer
{
    public class CustomerTier
    {
        private string connectionString;

        public CustomerTier()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
            //ConfigurationManager used to pull from Web.config
        }

        /// <summary>
        /// This is a method that will return all customers from the CustomerInformation table.
        /// </summary>
        /// <returns>Returns a list of Customer Type.</returns>
        public List<Customer> getAllCustomers()
        {
            List<Customer> customerList = null; Customer customer; string query;
            SqlConnection conn; SqlCommand cmd; SqlDataReader reader;   //declaring variables

            query = "SELECT * FROM CustomerInfo;";
            
            //End SQL command with semicolons, helps prevent against injection attacks.
            //Never concatinate with queries either.

            conn = new SqlConnection(connectionString);
            //Creating new instance of connection, won't work without connectionString configured.

            cmd = new SqlCommand(query, conn);
            //In order to use, attributes must be created as objects.

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                //Reader will contain rows of data, test for it.
                if (reader.HasRows)
                {
                    customerList = new List<Customer>();

                    //read first row of data from list
                    while (reader.Read())
                    {
                        customer = new Customer();
                        customer.custID = (int)reader["CustID"];
                        customer.fName = reader["FirstName"].ToString();
                        customer.lName = reader["LastName"].ToString();
                        customer.address = reader["Address"].ToString();
                        customer.address2 = reader["Address2"].ToString();
                        customer.city = reader["City"].ToString();
                        customer.state = reader["State"].ToString();
                        customer.zip = (int)reader["zip"];

                        customerList.Add(customer);
                        //Model neatly wraps up data into an object.

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally  //Used for cleanup, closing connection, memory management, garbage collection, etc.
            {
                conn.Close();
            }
            //Try / Catch / Finally Exeption handling,  use when code may fail upon executing (ex: If the server is offline the code will fail.)
            //This tells the code what to do if an error occurs  
            return customerList;
        }
        /// <summary>
        /// (Hello Class)
        /// This method inserts one customer into the CustomerInformation table.
        /// </summary>
        /// <param name="newCustomer">The customer info as a Customer type.
        /// (See comments in the class)</param>
        /// <returns>Returns true on success.</returns>
        public bool insertCustomer(Customer newCustomer)
        {
            SqlConnection conn; SqlCommand cmd; string query;
            bool success = false; int rows;   //used to store returned value(s)              

            //Do not concatenate values directly from form, leaves vulnerable to SQL Injection.  Scrub it first.
            query = "INSERT into CustomerInfo (FirstName, LastName, Address, Address2, City, State, zip) " +
                    "VALUES(@fName, @lName, @add1, @add2, @city, @state, @zip);";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);
            //cmd object scrubs the input in following lines

            cmd.Parameters.Add("@fName", SqlDbType.VarChar, 50).Value = newCustomer.fName;
            cmd.Parameters.Add("@lName", SqlDbType.VarChar, 50).Value = newCustomer.lName;
            cmd.Parameters.Add("@add1", SqlDbType.VarChar, 50).Value = newCustomer.address;
            cmd.Parameters.Add("@add2", SqlDbType.VarChar, 50).Value = newCustomer.address2;
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = newCustomer.city;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 2).Value = newCustomer.state;
            cmd.Parameters.Add("@zip", SqlDbType.Int).Value = newCustomer.zip;

            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery(); //returns a number of rows affected.
                if (rows > 0)
                {
                    success = true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return success;
       }

        public bool deleteCustomer(Customer newCustomer)
        {
            SqlConnection conn; SqlCommand cmd; string query;
            bool success = false; int rows;   //used to store returned value(s)              

            //Do not concatenate values directly from form, leaves vulnerable to SQL Injection.  Scrub it first.
            query = "DELETE from CustomerInfo " +
                    "WHERE CustID=@custID;";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);
            //cmd object scrubs the input in following lines

            cmd.Parameters.Add("@custID", SqlDbType.Int).Value = newCustomer.custID;

            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery(); //returns a number of rows affected.
                if (rows > 0)
                {
                    success = true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }

        public int getCustID(Customer cust)
        {
            Customer customer; string query;    int custID = 0;
            SqlConnection conn; SqlCommand cmd; SqlDataReader reader;   //declaring variables

            query = "SELECT CustID FROM CustomerInfo " +
                "WHERE FirstName = @fname and LastName = @lName and Address = @add1;";
            

            conn = new SqlConnection(connectionString);
           
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@fName", SqlDbType.VarChar, 50).Value = cust.fName;
            cmd.Parameters.Add("@lName", SqlDbType.VarChar, 50).Value = cust.lName;
            cmd.Parameters.Add("@add1", SqlDbType.VarChar, 50).Value = cust.address;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                //Reader will contain rows of data, test for it.
                if (reader.HasRows)
                {
                    
                    //read first row of data from list
                    while (reader.Read())
                    {
                        customer = new Customer();
                        customer.custID = (int)reader["CustID"];
                        custID = customer.custID;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
           
            return custID;
        }
    }
} 
