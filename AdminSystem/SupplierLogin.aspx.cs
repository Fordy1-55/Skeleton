using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtPassword_TextChanged(object sender, EventArgs e)
    {

    }

    protected void BtnLogin0_Click(object sender, EventArgs e)
    {
        clsSupplierUser AUser = new clsSupplierUser();
        string UserName = txtUsername.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AUser.FindUser(UserName, Password);
        Session["AUser"] = AUser;

        if (txtUsername.Text == "")
        {
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password";
        }
        else if (Found == true)
        {
            Response.Redirect("SupplierList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login Details are Incorrect. Please try again";
        }
    }



    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}