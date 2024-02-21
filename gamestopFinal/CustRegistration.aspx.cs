using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataModels;

namespace gamestopFinal
{
    public partial class CustRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            newCustomer.fName = txtFname.Text;
            newCustomer.lName = txtLname.Text;
            newCustomer.address = txtAdd1.Text;
            newCustomer.address2 = txtAdd2.Text;
            newCustomer.city = txtCity.Text;
            newCustomer.state = txtState.Text;
            newCustomer.zip = int.Parse(txtZip.Text);

            Session["CustomerData"] = newCustomer;

            //Request object used on client, contains query strings.
            //Response objects such as below used on server side.
            Response.Redirect("CustConfirmation.aspx");
        }

        protected void BtnClr_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}