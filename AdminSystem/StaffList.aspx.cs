using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is first time page is displayed
        if (IsPostBack == false)
        {
            //update list box
            DisplayStaff();
        }

    }

    void DisplayStaff()
    {
        //create instance of staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set data source ro list of staff in collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set name of primary key
        lstStaffList.DataValueField = "StaffID";
        //set data field to display
        lstStaffList.DataTextField = "Name";
        //bind data to the list
        lstStaffList.DataBind();
    }
}