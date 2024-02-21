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
    public class InventoryTier
    {
        private SqlConnection conn; private SqlCommand cmd;
        private SqlDataAdapter da; private SqlDataReader reader;
        private DataSet ds; private string query;
        private string connectionString; private bool success;
        public InventoryTier()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
        }

        public bool checkout(Customer cust, CustomerCC credit, Status s)
        {
            CustomerTier tier = new CustomerTier();
            tier.insertCustomer(cust);  int rows;
            int custID = tier.getCustID(cust);

            query = "INSERT INTO SalesInfo (CustID, ProductIDs, ItemQuantity, TotalCost) " +
                "Values (@custID, @ProductIDs, @quantity, @total);";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);

            ///Time to scrub the input
            cmd.Parameters.Add("@custID", SqlDbType.Int).Value = custID;
            cmd.Parameters.Add("@ProductIDs", SqlDbType.VarChar, 9).Value = s.cartProductIDs;
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@total", SqlDbType.Float).Value = s.total;

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