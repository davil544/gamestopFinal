using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataModels;

namespace gamestopFinal
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Status s = (Status)Session["s"];

            if (Session["s"] == null)
            {
                Response.Redirect("Cart.aspx");
            }
            else if (s.cartEmpty == true)
            {
                Response.Redirect("Cart.aspx");
            }
            ///^Checks to make sure the cart has something in it.
            ///If it doesn't, the page redirects.

            if (s.statNum == 1)
            {
                pnlGuestOrReg.Visible = false;
                pnlGuestCheckout.Visible = true;
                lblError.Text = "You did not fill out all of the necesary forms.  Please try again.";
            }

            Product[] games = (Product[])Session["cart"];
            s.tax = 0; s.subtotal = 0; s.total = 0;
            s.cartProductIDs = null;

            for (int i = 0; i < 3; i++)
            {
                if (games[i].inCart == true)
                {
                    lblProductName.Text += games[i].productName + "<br />";
                    lblProductPrice.Text += "$" + games[i].productCost + "<br />";
                    ///Makes double product appear, only charged once.

                    s.subtotal += games[i].productCost;

                    if (s.cartProductIDs != (games[i].productID + ", "))
                    {
                        s.cartProductIDs += games[i].productID + ", ";
                    }
                    
                }
            }

            s.tax = Math.Round(s.subtotal * .08625, 2); s.total = s.subtotal + s.tax;
            lblSubtotal.Text = "$" + s.subtotal.ToString("0.00"); lblTax.Text = "$" + s.tax.ToString("0.00");
            lblTotal.Text = "$" + s.total.ToString("0.00");
            Session["s"] = s;
        }

        protected void btnGuest_Click(object sender, EventArgs e)
        {
            pnlGuestOrReg.Visible = false; pnlGuestCheckout.Visible = true;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session["cc"] = null;
            Response.Redirect("Cart.aspx");
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            ///Set up what happens when you click continue
            try
            {
                Customer cust = new Customer(); CustomerCC creditCard = new CustomerCC();
                cust.fName = txtFname.Text;
                cust.lName = txtLname.Text;
                cust.address = txtAdd1.Text;
                cust.address2 = txtAdd2.Text;
                cust.city = txtCity.Text;
                cust.state = txtState.Text;
                cust.zip = int.Parse(txtZip.Text);
                Session["CustomerData"] = cust;

                creditCard.CardholderName = txtCardName.Text;
                creditCard.CardNumber = txtCardNum.Text;
                creditCard.CardExpDate = txtCardExpDate.Text;
                Session["cc"] = creditCard;

                Status s = (Status)Session["s"];
                s.statNum = 0;
                Session["s"] = s;

                Response.Redirect("CheckoutConfirm.aspx");
            }
            catch (FormatException ex)
            {
                Status s = (Status)Session["s"];
                s.statNum = 1;
                Session["s"] = s;
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}