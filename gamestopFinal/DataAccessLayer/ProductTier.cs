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
    public class ProductTier
    {
        private SqlConnection conn; private SqlCommand cmd;
        private SqlDataAdapter da; private SqlDataReader reader;
        private DataSet ds; private string query;
        private string connectionString; private bool success;

        public ProductTier()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyData"].ToString();
        }

        public DataSet getAllProducts()
        {
            return ds;
        }

        public List<Product> getProductList()
        {
            List<Product> productList = null;
            Product product = null;

            query = "SELECT * FROM Products;";
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    productList = new List<Product>();
                    while (reader.Read())
                    {
                        product = new Product();
                        product.productID = (int)reader["ProductID"];
                        if (reader["ProductName"] != DBNull.Value)
                        {
                            product.productName = reader["ProductName"].ToString();
                        }
                        else
                        {
                            product.productName = "";
                        }

                        if (reader["ProductDescription"] != DBNull.Value)
                        {
                            product.productDescription = reader["ProductDescription"].ToString();
                            ///For some reason this returns the ProductName, couldn't figure out why.
                        }
                        else
                        {
                            product.productDescription = "";
                        }

                        ///decimal productCost = (decimal)reader["ProductCost"];
                        ///bool CostNull = checkNumNull(productCost);
                        ///CostNull == false
                        ///old if statement: reader["ProductCost"] != DBNull.Value
                        
                        if ((reader["ProductPrice"]) != DBNull.Value) 
                        {
                            product.productCost = (float)(double)reader["ProductPrice"];
                        }
                        else
                        {
                            product.productCost = 0.00F;
                        }
                       

                        if (reader["ProductImage"] != DBNull.Value)
                        {
                            product.productImage = (byte[])reader["ProductImage"];
                        }
                        else
                        {
                            product.productImage = null;
                        }

                        productList.Add(product);
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

            return productList;
        }

        public bool deleteProduct(int productID)
        {
            SqlConnection conn; SqlCommand cmd; string query;
            bool success = false; int rows;   //used to store returned value(s)              

            //Do not concatenate values directly from form, leaves vulnerable to SQL Injection.  Scrub it first.
            query = "DELETE from Products " +
                    "WHERE ProductID=@prodID;";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);
            //cmd object scrubs the input in following lines

            cmd.Parameters.Add("@prodID", SqlDbType.Int).Value = productID;

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

        public bool insertProduct(Product product)
        {
            return success;
        }

        public bool updateProduct(Product product)
        {
            return success;
        }

        public byte[] getImage(int productID)
        {
            byte[] theImage = null;

            if (productID == -1)
            {
                query = "SELECT * FROM ProductsNoPics " +
                "WHERE ProductID = @ID;";
            }
            else
            {
                query = "SELECT * FROM Products " +
                "WHERE ProductID = @ID;";
            }
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);

            if (productID == -1)
            {
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = 1;
            }
            else
            {
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = productID;
            }

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    ///don't need a while statement if only pulling up 1 record
                    reader.Read();
                    if (reader["ProductImage"] != DBNull.Value)
                    {
                        theImage = (byte[])reader["ProductImage"];
                    }
                    else
                    {
                        theImage = null;
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

            return theImage;
        }

        public Boolean saveProduct(Product product)
        {
            int rows;   ///Product Array: 0 = Name, 1 = Description, and 2 is price

            query = "INSERT INTO Products (ProductName, ProductDescription, ProductPrice, ProductImage) " +
                     "Values(@ProdName, @ProdDesc, @ProdPrice, @ProdImage);";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@ProdName", SqlDbType.VarChar, 50).Value = product.productName;
            cmd.Parameters.Add("@ProdDesc", SqlDbType.VarChar, 200).Value = product.productDescription;
            cmd.Parameters.Add("@ProdPrice", SqlDbType.Float).Value = product.productCost;
            cmd.Parameters.Add("@ProdImage", SqlDbType.Image).Value = product.productImage;

            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();

                if (rows >= 1)
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
        private bool checkNumNull(double n)
        {
            if (n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Product[] CartInit()
        {
            Product[] games = new Product[3];

            ///Apparently must initialize array before use
            for (int i = 0; i < 3; i++)
            {
                games[i] = new Product();
            }
            
            ///0 = Red Dead, 1 = Ghost Recon, 2 = Forza 7
            ///HttpCookie cart = new HttpCookie("cart");
            games[0].productName = "Red Dead Redemption 2";
            games[0].productCost = 59.99F;
            games[0].productDescription = "Developed by the creators of Grand Theft Auto V and Red Dead Redemption, " +
                "Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. " +
                "The game's vast and atmospheric world will also provide the foundation for a brand new online multiplayer experience.";
            games[0].productID = 1;
            games[0].inCart = false;

            games[1].productName = "Tom Clancy's Ghost Recon: Future Soldier";
            games[1].productCost = 19.99F;
            games[1].productDescription = "Join an elite team of special-ops soldiers in the globe’s most deadly " +
                "warzones to hunt down the highest value targets.";
            games[1].productID = 2;
            games[1].inCart = false;

            games[2].productName = "Forza Motorsport 7";
            games[2].productDescription = "Experience the thrill of motorsport at the limit with the most comprehensive, beautiful and authentic " +
                "racing game ever made. Enjoy gorgeous graphics at 60fps and native 4K resolution in HDR. Collect and race more than 700 cars, " +
                "including the largest collection of Ferraris, Porsches, and Lamborghinis ever. Challenge yourself across 30 famous destinations " +
                "and 200 ribbons, where race conditions change every time you return to the track.";
            games[2].productCost = 49.99F;
            games[2].productID = 3;
            games[2].inCart = false;

            return games;
        }

        public string TruncateString(string str, int maxlength)
        {
            return str.Substring(0, Math.Min(str.Length, maxlength));
        }
    }
}