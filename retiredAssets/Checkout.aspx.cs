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
            Product[] games = (Product[])Session["cart"];
        }

        protected void btnGuest_Click(object sender, EventArgs e)
        {
            pnlGuestOrReg.Visible = false;  pnlGuestCheckout.Visible = true;
        }
    }
}