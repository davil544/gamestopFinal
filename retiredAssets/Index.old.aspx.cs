using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gamestopFinal
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cart = new HttpCookie("cart");
            cart.Values["contents"] = ""
            
            if (Session["Cart"]==null)
            {
                List<string> myCart = new List<string>();
                myCart.Add()
            }
        }

        protected void btnAddRdr2(object sender, EventArgs e)
        {
            Response.Redirect("/Cart/Cart.aspx");
        }
    }
}