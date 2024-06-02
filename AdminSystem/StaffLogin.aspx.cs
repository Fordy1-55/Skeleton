using ClassLibrary;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffLogin : System.Web.UI.Page
{

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create instance
        clsStaffUser User = new clsStaffUser();
        //create the variables to store username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create variable to store result of find user operation
        Boolean Found = false;
        //get the username and password entered by the user
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = User.FindUser(UserName, Password);
        Session["User"] = User;
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
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again ";
        }



    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}