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
    public partial class DelEmployeeConfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RemovedEmployee"] != null)
            {
                Employee employee = (Employee)Session["RemovedEmployee"];
                lblRemove.Text = employee.employeeID.ToString();
            }
            else
            {
                Response.Redirect("DelEmployees.aspx");
            }

            List<Employee> employeeList;
            EmployeeTier employeeTier = new EmployeeTier();
            employeeList = employeeTier.getAllEmployees();
            grdEmployees.DataSource = employeeList;

            grdEmployees.DataBind();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            EmployeeTier employeeTier = new EmployeeTier();
            Employee employee = (Employee)Session["RemovedEmployee"];
            employeeTier.deleteEmployee(employee);
            Session["RemovedEmployee"] = null;

            Status state = new Status();
            state.statNum = 1;
            Session["state"] = state;
            
            Response.Redirect("ListEmployees.aspx");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("DelEmployees.aspx");
        }
    }
}