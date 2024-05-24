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
        string CustomerName = txtCustomerName.Text;
        //Capture customer Address
        string CustomerAddress = txtCustomerAddress.Text;
        //Capture Customer Telephone Number
        string CustomerTelephoneNo = txtCustomerTelephone.Text;
        //Capture customers date of birth
        string DateOfBirth = txtDateOfBirth.Text;
        //Capture Customers email address
        string CustomerEmail = txtCustomerEmail.Text;
        //Capture active checkbox
        string Subscription = chkSubscription.Text;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
        if (Error == "")
        {
            //capture the customer name
            AnCustomer.CustomerName = CustomerName;
            //capture the customer email
            AnCustomer.CustomerEmail = CustomerEmail;
            //capture customer address
            AnCustomer.CustomerAddress = CustomerAddress;
            //capture customer TelephoneNo
            AnCustomer.CustomerTelephoneNo = CustomerTelephoneNo;
            //capture the customers date of birth
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //Store the Customer Name in the session object
            Session["AnCustomer"] = AnCustomer;
            //navigate to view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }


    

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class 
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store a primary key
        Int32 CustomerID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);   
        //find the record
        Found = AnCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            // display the values of the properties in the form
            txtCustomerAddress.Text = AnCustomer.CustomerAddress;
            txtCustomerEmail.Text = AnCustomer.CustomerEmail;   
            txtCustomerName.Text = AnCustomer.CustomerName;
            txtCustomerTelephone.Text = AnCustomer.CustomerTelephoneNo;
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
            chkSubscription.Checked = AnCustomer.Subscription;


        }
    }

    
}