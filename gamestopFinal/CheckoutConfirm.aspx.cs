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
    public partial class CheckoutConfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["CustomerData"] == null || Session["cc"] == null)
            {
                Response.Redirect("Checkout.aspx");
            }

            Customer cust = (Customer)Session["CustomerData"];  CustomerCC creditCard = (CustomerCC)Session["cc"];
            Product[] games = (Product[])Session["cart"];   Status s = (Status)Session["s"];

            lblFname.Text = cust.fName;
            lblLname.Text = cust.lName;
            lblAdd1.Text = cust.address;
            lblAdd2.Text = cust.address2;
            lblCity.Text = cust.city;
            lblState.Text = cust.state;
            lblZip.Text = cust.zip.ToString();

            for (int i = 0; i < 3; i++)
            {
                if (games[i].inCart == true)
                {
                    lblProductName.Text += games[i].productName + "<br />";
                    lblProductPrice.Text += "$" + games[i].productCost + "<br />";

                    s.subtotal += games[i].productCost;
                }
            }
            s.tax = Math.Round(s.subtotal * .08625, 2); s.total = s.subtotal + s.tax;
            lblSubtotal.Text = "$" + s.subtotal.ToString("0.00"); lblTax.Text = "$" + s.tax.ToString("0.00");
            lblTotal.Text = "$" + s.total.ToString("0.00");

            lblCardholderName.Text = creditCard.CardholderName;
            lblCardNum.Text = creditCard.CardNumber.Substring(Math.Max(0, creditCard.CardNumber.Length - 4));
            lblCardExp.Text = creditCard.CardExpDate;
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            InventoryTier tier = new InventoryTier();
            Customer cust = (Customer)Session["CustomerData"]; CustomerCC creditCard = (CustomerCC)Session["cc"];
            Status s = (Status)Session["s"];


            bool done = tier.checkout(cust, creditCard, s);

            if (done == true)
            {
                Session["cc"] = null;   Session["s"] = null;
                Response.Redirect("CheckoutConfirmed.aspx");
            }
            else
            {
                Response.Redirect("Cart.aspx");
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Session["CustomerData"] = null;
            Session["cc"] = null;
            Response.Redirect("Checkout.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session["CustomerData"] = null;
            Session["cc"] = null;
            Response.Redirect("Cart.aspx");
        }
    }
}