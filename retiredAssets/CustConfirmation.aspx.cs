﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gamestopFinal.DataModels;
using gamestopFinal.DataAccessLayer;

namespace gamestopFinal
{
    public partial class CustConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerData"] != null)
            {
                Customer customer = (Customer)Session["CustomerData"];

                lblFname.Text = customer.fName;
                lblLname.Text = customer.lName;
                lblAdd1.Text = customer.address;
                lblAdd2.Text = customer.address2;
                lblCity.Text = customer.city;
                lblState.Text = customer.state;
                lblZip.Text = customer.zip.ToString();
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CustomerTier customerTier = new CustomerTier();
            Customer customer = (Customer)Session["CustomerData"];

            customerTier.insertCustomer(customer);

            Session["CustomerData"] = null;
            //set session variable to null when no longer needed,
            //already submitted into db.

            Response.Redirect("Index.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustRegistration.aspx");
        }
    }
}