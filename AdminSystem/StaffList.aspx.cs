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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this a new record
        Session["StaffID"] = -1;
        //redirect to data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of the record to be edited
        Int32 StaffID;
        //if record has been selected from list
        if(lstStaffList.SelectedIndex != -1)
        {
            //get primary key value of record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //REDIRECT TO edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else  //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of record to be deleted
        Int32 StaffID;
        //if record selected
        if (lstStaffList.SelectedIndex != -1)
        {
            //grab primary key value from record delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store data in session object
            Session["StaffID"] = StaffID;
            //redirect to deletion page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record selected
        {
            //display error msg
            lblError.Text = "Select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create instance of staff object
        clsStaffCollection Staff = new clsStaffCollection();
        //retrieve name from presentation layer
        Staff.ReportByName(txtFilter.Text);
        //set data source to staff list in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set name of primary lkey
        lstStaffList.DataValueField = "StaffID";
        //set name of field to display
        lstStaffList.DataValueField = "Name";
        //bind data to list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create instance of staff object
        clsStaffCollection Staff = new clsStaffCollection();
        //set empty string
        Staff.ReportByName("");
        //clear existing filter to tidy up interface
        txtFilter.Text = "";
        //set data source to staff list in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set name of primary lkey
        lstStaffList.DataValueField = "StaffID";
        //set name of field to display
        lstStaffList.DataValueField = "Name";
        //bind data to list
        lstStaffList.DataBind();
    }
}