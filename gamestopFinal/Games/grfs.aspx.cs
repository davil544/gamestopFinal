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
    public partial class grfs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductTier productTier = new ProductTier();
            Product[] grfs = (Product[])Session["cart"];

            lblTitle.Text = grfs[1].productName;
            lblDesc.Text = grfs[1].productDescription;
            lblPrice.Text = grfs[1].productCost.ToString();
            imgGame.ImageUrl = "/Handlers/ProductImage.ashx?ID=2";
        }

        protected void btnAddGrfs_Click(object sender, EventArgs e)
        {
            Product[] games = (Product[])Session["cart"];
            games[1].inCart = true;

            Session["cart"] = games;
            Response.Redirect("/Cart.aspx");
        }
    }
}