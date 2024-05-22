using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store primary key of record value to be deleted
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get staff number of record to be deleted
        StaffID = Convert.ToInt32(Session["StaffID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create instance of collection class
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find record to delete
        StaffBook.ThisStaff.Find(StaffID);
        //DELETE RECORD
        StaffBook.Delete();
        //redirect to main page
        Response.Redirect("StaffList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to main page
        Response.Redirect("StaffList.aspx");
    }
}