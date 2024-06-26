﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomer();
        }
    }

     void DisplayCustomer()
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to the list of address in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name for the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the data field to display 
        lstCustomerList.DataTextField = "CustomerName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }
}