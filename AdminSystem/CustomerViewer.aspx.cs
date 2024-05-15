using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //Display the customer name for the entry
        Response.Write(AnCustomer.CustomerID);
        Response.Write(AnCustomer.CustomerName);
        Response.Write(AnCustomer.CustomerAddress);
        Response.Write(AnCustomer.CustomerEmail);
        Response.Write(AnCustomer.CustomerTelphoneNo);
        Response.Write(AnCustomer.DateOfBirth);
    }
}