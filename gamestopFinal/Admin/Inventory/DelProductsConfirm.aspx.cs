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
    public partial class DelProductsConfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RemovedProduct"] != null)
            {
                Product prod = (Product)Session["RemovedProduct"];
                lblRemove.Text = prod.productID.ToString();
            }
            else
            {
                Response.Redirect("DelProducts.aspx");
            }

            List<Product> productList;
            ProductTier productTier = new ProductTier();
            productList = productTier.getProductList();
            grdProducts.DataSource = productList;

            grdProducts.DataBind();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            ProductTier tier = new ProductTier();   Status s = new Status();
            Product product = (Product)Session["RemovedProduct"];   

            if (product.productID <= 3)
            {
                s.statNum = 3;
                Session["RemovedProduct"] = null;
                Response.Redirect("Products.aspx");
            }
            else
            {
                bool success = tier.deleteProduct(product.productID);

                if (success == true)
                {
                    s.statNum = 1;
                }
                else
                {
                    s.statNum = 0;
                }
                
                Session["state"] = s;
                Session["RemovedProduct"] = null;
                Response.Redirect("Products.aspx");
            }

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}