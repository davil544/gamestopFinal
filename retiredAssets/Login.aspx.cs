using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gamestopFinal.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void formAdminLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            ///Auto authenticate to make life easy, not secure
            e.Authenticated = true;
        }

        protected void adminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Index.aspx");
        }
    }
}