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
    public class EmployeeTier
    {
        private string connectionString;

        public EmployeeTier()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
            //ConfigurationManager used to pull from Web.config
        }

        /// <summary>
        /// This is a method that will return all customers from the CustomerInformation table.
        /// </summary>
        /// <returns>Returns a list of Employee Type.</returns>
        public List<Employee> getAllEmployees()
        {
            List<Employee> employeeList = null; Employee employee; string query;
            SqlConnection conn; SqlCommand cmd; SqlDataReader reader;   //declaring variables

            query = "SELECT * FROM EmployeeInfo;";
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
                    employeeList = new List<Employee>();

                    //read first row of data from list
                    while (reader.Read())
                    {
                        employee = new Employee();
                        employee.employeeID = (int)reader["EmployeeID"];
                        employee.fName = reader["FirstName"].ToString();
                        employee.lName = reader["LastName"].ToString();
                        employee.address = reader["Address"].ToString();
                        employee.address2 = reader["Address2"].ToString();
                        employee.city = reader["City"].ToString();
                        employee.state = reader["State"].ToString();
                        employee.zip = (int)reader["zip"];
                        employee.title = reader["JobTitle"].ToString();

                        employeeList.Add(employee);
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
            return employeeList;
        }
        /// <summary>
        /// (Hello Class)
        /// This method inserts one employee into the EmployeeInformation table.
        /// </summary>
        /// <param name="newEmployee">The customer info as a Employee type.
        /// (See comments in the class)</param>
        /// <returns>Returns true on success.</returns>
        public bool insertEmployee(Employee newEmployee)
        {
            SqlConnection conn; SqlCommand cmd; string query;
            bool success = false; int rows;   //used to store returned value(s)              

            //Do not concatenate values directly from form, leaves vulnerable to SQL Injection.  Scrub it first.
            query = "INSERT into EmployeeInfo (FirstName, LastName, Address, Address2, City, State, zip, JobTitle) " +
                    "VALUES(@fName, @lName, @add1, @add2, @city, @state, @zip, @title);";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);
            //cmd object scrubs the input in following lines

            cmd.Parameters.Add("@fName", SqlDbType.VarChar, 50).Value = newEmployee.fName;
            cmd.Parameters.Add("@lName", SqlDbType.VarChar, 50).Value = newEmployee.lName;
            cmd.Parameters.Add("@add1", SqlDbType.VarChar, 50).Value = newEmployee.address;
            cmd.Parameters.Add("@add2", SqlDbType.VarChar, 50).Value = newEmployee.address2;
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = newEmployee.city;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 50).Value = newEmployee.state;
            cmd.Parameters.Add("@zip", SqlDbType.Int).Value = newEmployee.zip;
            cmd.Parameters.Add("@title", SqlDbType.VarChar, 50).Value = newEmployee.title;

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

        public bool deleteEmployee(Employee newEmployee)
        {
            SqlConnection conn; SqlCommand cmd; string query;
            bool success = false; int rows;   //used to store returned value(s)              

            //Do not concatenate values directly from form, leaves vulnerable to SQL Injection.  Scrub it first.
            query = "DELETE from EmployeeInfo " +
                    "WHERE EmployeeID=@empID;";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);
            //cmd object scrubs the input in following lines

            cmd.Parameters.Add("@empID", SqlDbType.Int).Value = newEmployee.employeeID;
            
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
    }
}