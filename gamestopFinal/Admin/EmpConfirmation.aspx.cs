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
    public partial class EmpConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmployeeData"] != null)
            {
                Employee employee = (Employee)Session["EmployeeData"];

                lblFname.Text = employee.fName;
                lblLname.Text = employee.lName;
                lblAdd1.Text = employee.address;
                lblAdd2.Text = employee.address2;
                lblCity.Text = employee.city;
                lblState.Text = employee.state;
                lblZip.Text = employee.zip.ToString();
                lblTitle.Text = employee.title;
            }
            else
            {
                Response.Redirect("EmpRegistration.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            EmployeeTier employeeTier = new EmployeeTier();
            Employee employee = (Employee)Session["EmployeeData"];

            employeeTier.insertEmployee(employee);

            Session["EmployeeData"] = null;
            //set session variable to null when no longer needed,
            //already submitted into db.

            Status state = new Status();
            state.statNum = 2;
            Session["state"] = state;

            Response.Redirect("ListEmployees.aspx");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpRegistration.aspx");
        }
    }
}