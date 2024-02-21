using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataAccessLayer;
using gamestopFinal.DataModels;

namespace gamestopFinal.Admin.Customers
{
    public partial class ListCustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Customer> customerList;
            CustomerTier customerTier = new CustomerTier();
            customerList = customerTier.getAllCustomers();
            grdCustomers.DataSource = customerList;

            grdCustomers.DataBind();

            Status state = (Status)Session["state"];
            if (Session["state"] != null)
            {
                if (state.statNum == 1)
                {
                    lblStatus.Text = "Entry deleted successfully!";
                }
                else if (state.statNum == 2)
                {
                    lblStatus.Text = "Entry created successfully!";
                }

                Session["state"] = null;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustRegistration.aspx");
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Response.Redirect("DelCustomers.aspx");
        }
    }
}