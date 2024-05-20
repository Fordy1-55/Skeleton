using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnOK_Click(object sender, EventArgs e)

    {
      //create a new instance of clsCustomer
      clsCustomer AnCustomer = new clsCustomer();
        //capture Customer Name
        AnCustomer.CustomerName = txtCustomerName.Text;
        //Capture customerID
        AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //Capture customer Address
        AnCustomer.CustomerAddress = txtCustomerAddress.Text;
        //Capture Customer Telephone Number
        AnCustomer.CustomerTelephoneNo = txtCustomerTelephone.Text;
        //Capture customers date of birth
        AnCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        //Capture Customers email address
        AnCustomer.CustomerEmail = txtCustomerEmail.Text;
        //Capture active checkbox
        AnCustomer.Subscription = chkSubscription.Checked;
        //Store the Customer Name in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to view page
        Response.Redirect("CustomerViewer.aspx");
    }

    
}