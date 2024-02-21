using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataAccessLayer;
using gamestopFinal.DataModels;

namespace gamestopFinal.Admin.Inventory
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> productList;
            ProductTier productTier = new ProductTier();
            productList = productTier.getProductList();
            grdProducts.DataSource = productList;
            grdProducts.DataBind();

            Status state = (Status)Session["state"];
            if (Session["state"] != null)
            {
                if (state.statNum == 1)
                {
                    lblStatus.Text = "Entry deleted successfully!";
                }
                else if (state.statNum == 2)
                {
                    lblStatus.Text = "Entry created successfully!";
                }
                else if (state.statNum == 3)
                {
                    lblStatus.Text = "This entry is hardcoded into the website and cannot be deleted.";
                }

                Session["state"] = null;
            }
        }
        
        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct.aspx");
        }

        protected void btnRemProduct_Click(object sender, EventArgs e)
        {
            ///Make this button delete records from the DB, not 1 - 3
            ///as they are hardcoded in and things will break.
            Response.Redirect("DelProducts.aspx");
        }
    }
}