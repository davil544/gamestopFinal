using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataModels;

namespace gamestopFinal.Admin.Employees
{
    public partial class EmpRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();
            newEmployee.fName = txtFname.Text;
            newEmployee.lName = txtLname.Text;
            newEmployee.address = txtAdd1.Text;
            newEmployee.address2 = txtAdd2.Text;
            newEmployee.city = txtCity.Text;
            newEmployee.state = txtState.Text;
            newEmployee.zip = int.Parse(txtZip.Text);
            newEmployee.title = txtTitle.Text;

            Session["EmployeeData"] = newEmployee;

            //Request object used on client, contains query strings.
            //Response objects such as below used on server side.
            Response.Redirect("EmpConfirmation.aspx");
        }

        protected void btnClr_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListEmployees.aspx");
        }
    }
}