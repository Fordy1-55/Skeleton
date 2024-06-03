using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the stock user class
        clsStockUser AnUser = new clsStockUser();
        //create the variables to store the username and password 
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the username and password by the user
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(UserName, Password);
        //add a session to capture the user name
        Session["AnUser"] = AnUser;
        //if username and/or password is empty
        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a username ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password ";
        }
        else if (Found == true)
        {
            Response.Redirect("StockList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}