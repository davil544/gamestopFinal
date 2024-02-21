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
    public partial class DelEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> employeeList;
            EmployeeTier employeeTier = new EmployeeTier();
            employeeList = employeeTier.getAllEmployees();
            grdEmployees.DataSource = employeeList;

            grdEmployees.DataBind();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            ///Code to remove employee from table goes here.  Use input from text box
            Employee employee = new Employee();
            employee.employeeID = int.Parse(txtRemove.Text);

            Session["RemovedEmployee"] = employee;
            Response.Redirect("DelEmployeeConfirm.aspx");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListEmployees.aspx");
        }
    }
}