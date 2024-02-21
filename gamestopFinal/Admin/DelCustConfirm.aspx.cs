using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataAccessLayer;
using gamestopFinal.DataModels;

namespace gamestopFinal.Admin
{
    public partial class DelCustConfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RemovedCustomer"] != null)
            {
                Customer customer = (Customer)Session["RemovedCustomer"];
                lblRemove.Text = customer.custID.ToString();
            }
            else
            {
                Response.Redirect("DelCustomers.aspx");
            }

            List<Customer> customerList;
            CustomerTier customerTier = new CustomerTier();
            customerList = customerTier.getAllCustomers();
            grdCustomers.DataSource = customerList;

            grdCustomers.DataBind();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            CustomerTier customerTier = new CustomerTier();
            Customer customer = (Customer)Session["RemovedCustomer"];
            customerTier.deleteCustomer(customer);
            Session["RemovedCustomer"] = null;

            Status state = new Status();
            state.statNum = 1;
            Session["state"] = state;

            Response.Redirect("ListCustomers.aspx");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("DelCustomers.aspx");
        }
    }
}