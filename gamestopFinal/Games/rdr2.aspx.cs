using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataAccessLayer;
using gamestopFinal.DataModels;

namespace gamestopFinal.Games
{
    public partial class rdr2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductTier productTier = new ProductTier();
            Product[] redDead = (Product[])Session["cart"];

            lblTitle.Text = redDead[0].productName;
            ///productList = productTier.getProductList();
            ///make Product Page load info from db
            lblDesc.Text = redDead[0].productDescription;
            lblPrice.Text = redDead[0].productCost.ToString();
            imgGame.ImageUrl = "/Handlers/ProductImage.ashx?ID=1";
        }

        protected void btnAddRdr2_Click(object sender, EventArgs e)
        {
            Product[] games = (Product[])Session["cart"];
            games[0].inCart = true;

            Session["cart"] = games;
            Response.Redirect("/Cart.aspx");
        }
    }
}