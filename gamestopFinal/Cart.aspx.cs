using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataModels;
using gamestopFinal.DataAccessLayer;

namespace gamestopFinal
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Status s = new Status();
            if (Session["cart"] == null)
            {
                ProductTier tier = new ProductTier();
                Product[] cart = tier.CartInit();
                Session["cart"] = cart;
            }

            Product[] games = (Product[])Session["cart"];
            ///games[]  0 = Red Dead, 1 = Ghost Recon, 2 = Forza 7
            s.tax = 0; s.subtotal = 0;
            
            ///string cartStatus = "Items in cart: <br />"; string[] c = new string[3];
            ///originally used this to display cart, then I realized I could make an
            ///array out of the Product object.

            for (int i = 0; i < 3; i++)
            {
                if (games[i].inCart == true)
                {
                    lblProductName.Text += games[i].productName + "<br />";
                    lblProductPrice.Text += "$" + games[i].productCost + "<br />";

                    s.subtotal += games[i].productCost;
                    s.cartProductIDs += games[i].productID + ", ";
                }
            }
            ///lblProductName.Style.Add("padding", "10px");
            ///lblProductPrice.Style.Add("padding", "10px");
            
            lblSubtotal.Style.Add("padding", "10px");
            lblTax.Style.Add("padding", "10px");
            lblTotal.Style.Add("padding", "10px");

            ///cartStatus = string.Concat(cartStatus, c[0], c[1], c[2]);

            if (games[0].inCart == false && games[1].inCart == false && games[2].inCart == false)
            {
                ///cartStatus += "The cart is empty.<br />";
                pnlCartEmpty.Visible = true;
                pnlCart.Visible = false;
                s.cartEmpty = true;
            }
            else
            {
                s.tax = Math.Round(s.subtotal * .08625, 2); s.total = s.subtotal + s.tax;
                lblSubtotal.Text = "$" + s.subtotal.ToString("0.00");  lblTax.Text = "$" + s.tax.ToString("0.00");
                lblTotal.Text = "$" + s.total.ToString("0.00");
                pnlCartEmpty.Visible = false;
                pnlCart.Visible = true;
                s.cartEmpty = false;
                
                ///cartStatus += "NY State Tax = $" + tax.ToString("0.00") +
                ///              "<br />The total cost is $" + total.ToString("0.00") + "<br />";
            }

            Session["s"] = s;

            ///if (cart != null)
            ///{
            ///string ProdName = cart["ProductName"];
            ///string ProdPrice = cart["ProductPrice"];
            ///subtotal = Double.Parse(ProdPrice);
            ///
            ///cartStatus = "In Cart: " + ProdName + ", Price = " + ProdPrice;
            ///string total = "The total price is $" + subtotal;
            ///}
            ///else
            ///{
            ///cartStatus = "The cart is empty.";
            ///}

            ///lblCart.Text = cartStatus;
        }

        protected void btnClearCart_Click(object sender, EventArgs e)
        {
           if (Session["cart"] != null)
            {
                Session["cart"] = null;
                ProductTier tier = new ProductTier();
                Product[] games = tier.CartInit();
                Session["cart"] = games;
            }
            
            Response.Redirect(Request.RawUrl);
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
        
    }
}