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
    public partial class DelProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> productList;
            ProductTier productTier = new ProductTier();
            productList = productTier.getProductList();
            grdProducts.DataSource = productList;
            grdProducts.DataBind();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.productID = int.Parse(txtRemove.Text);

            Session["RemovedProduct"] = product;
            Response.Redirect("DelProductsConfirm.aspx");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }
    }
}