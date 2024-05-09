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
        //Creating new instance of clsStaff
        clsStaff Staff = new clsStaff();
        //Grab data from session object
        Staff = (clsStaff)Session["Staff"];
        //Display Staff ID for this emntry
        Response.Write(clsStaff.StaffIDProperty);
        Response.Write(clsStaff.NameProperty);
        Response.Write(clsStaff.RoleProperty);
        Response.Write(clsStaff.ShiftTypeProperty);


    }
}