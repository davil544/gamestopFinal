using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataAccessLayer;
using gamestopFinal.DataModels;

namespace gamestopFinal
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///HttpCookie cart = Request.Cookies["cart"];
            if (Session["cart"] == null)
            {
                ///HttpCookie cart = (HttpCookie)Session["cart"];
                ///maybe create list that contains contents of cart,
                ///since i can't figure out cookies, use session things
                ///to store and pass data.
                ///Inventory inv = new Inventory();
                ///inv.CartForza7 = false;
                ///inv.CartGrfs = false;
                ///inv.CartRdr2 = false;
                ///Session["cart"] = inv;
                ///0 = Red Dead, 1 = Ghost Recon, 2 = Forza 7
                ///HttpCookie cart = new HttpCookie("cart");

                ProductTier productTier = new ProductTier();
                Product[] game = productTier.CartInit();
                Session["cart"] = game;
            }
            
            Product[] games = (Product[])Session["cart"];
            ProductTier tier = new ProductTier();
            lblRdr2Title.Text = games[0].productName;
            lblRdr2Desc.Text = tier.TruncateString(games[0].productDescription, 150) + "...";
            lblRdr2Cost.Text = "$" + games[0].productCost;

            lblGrfsTitle.Text = games[1].productName;
            lblGrfsDesc.Text = games[1].productDescription;
            lblGrfsCost.Text = "$" + games[1].productCost;

            lblForza7Title.Text = games[2].productName;
            lblForza7Desc.Text = tier.TruncateString(games[2].productDescription, 150) + "...";
            lblForza7Cost.Text = "$" + games[2].productCost;

            imgRdr2.ImageUrl = "/Handlers/ProductImage.ashx?ID=1";
            imgGrfs.ImageUrl = "/Handlers/ProductImage.ashx?ID=2";
            imgForza7.ImageUrl = "/Handlers/ProductImage.ashx?ID=3";
        }

        protected void btnAddRdr2_Click(object sender, EventArgs e)
        {
            
            ///0 = Red Dead, 1 = Ghost Recon, 2 = Forza 7
            ///HttpCookie cart = new HttpCookie("cart");
            ///cart["ProductName"] = 
            ///cart["ProductPrice"] = "59.99";
            ///cart.Expires.AddDays(7);
            ///Inventory inv = (Inventory)Session["cart"];
            ///inv.CartRdr2 = true;
            Product[] games = (Product[])Session["cart"];
            games[0].inCart = true;

            Session["cart"] = games;
            Response.Redirect("Cart.aspx");
        }

        protected void btnAddGrfs_Click(object sender, EventArgs e)
        {
            Product[] games = (Product[])Session["cart"];
            games[1].inCart = true;

            Session["cart"] = games;
            Response.Redirect("Cart.aspx");
        }

        protected void btnAddForza7_Click(object sender, EventArgs e)
        {
            Product[] games = (Product[])Session["cart"];
            games[2].inCart = true;

            Session["cart"] = games;
            Response.Redirect("Cart.aspx");
        }

        protected void btnDetailsRdr2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Games/rdr2.aspx");
        }

        protected void btnDetailsGrfs_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Games/grfs.aspx");
        }

        protected void btnDetailsForza7_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Games/forza7.aspx");

        }
    }
}