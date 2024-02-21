using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataModels;

namespace gamestopFinal
{
    public partial class CheckoutConfirmed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer cust = (Customer)Session["CustomerData"];
            lblCustName.Text = cust.fName;
            Session["CustomerData"] = null;
            Session["cart"] = null;
        }
    }
}