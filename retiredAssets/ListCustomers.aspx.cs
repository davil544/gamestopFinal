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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Customer> customerList;
            CustomerTier customerTier = new CustomerTier();
            customerList = customerTier.getAllCustomers();
            grdCustomers.DataSource = customerList;

            grdCustomers.DataBind();
        }
    }
}