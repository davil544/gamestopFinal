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
    public partial class DelCustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Customer> customerList;
            CustomerTier customerTier = new CustomerTier();
            customerList = customerTier.getAllCustomers();
            grdCustomers.DataSource = customerList;

            grdCustomers.DataBind();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.custID = int.Parse(txtRemove.Text);

            Session["RemovedCustomer"] = customer;
            Response.Redirect("DelCustConfirm.aspx");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListCustomers.aspx");
        }
    }
}