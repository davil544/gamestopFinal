using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataAccessLayer;
using gamestopFinal.DataModels;

namespace gamestopFinal.Admin.Employees
{
    public partial class ListEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> employeeList;
            EmployeeTier employeeTier = new EmployeeTier();
            employeeList = employeeTier.getAllEmployees();
            grdEmployees.DataSource = employeeList;
            grdEmployees.DataBind();

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

        protected void btnAddEmp_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpRegistration.aspx");
        }

        protected void btnRemEmp_Click(object sender, EventArgs e)
        {
            Response.Redirect("DelEmployees.aspx");
        }
    }
}