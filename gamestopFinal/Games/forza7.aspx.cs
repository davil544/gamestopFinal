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
    public partial class forza7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductTier productTier = new ProductTier();
            Product[] forza7 = (Product[])Session["cart"];

            lblTitle.Text = forza7[2].productName;
            lblDesc.Text = forza7[2].productDescription;
            lblPrice.Text = forza7[2].productCost.ToString();
            imgGame.ImageUrl = "/Handlers/ProductImage.ashx?ID=3";
        }

        protected void btnAddForza7_Click(object sender, EventArgs e)
        {
            Product[] games = (Product[])Session["cart"];
            games[2].inCart = true;

            Session["cart"] = games;
            Response.Redirect("/Cart.aspx");
        }
    }
}