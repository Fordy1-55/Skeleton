using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store primary key with page level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of staff member to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not the new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtRole_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtShiftType_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnEnter_Click(object sender, EventArgs e)
    {
        //Create new instance of Staff Class
        clsStaff Staff = new clsStaff();
        //Capture the Name
        string Name = txtName.Text;
        //Capture the Role
        string Role = txtRole.Text;
        //Capture Shift Type
        string ShiftType = txtShiftType.Text;
        //Capture check box manager
        string ManagerStatus = chkManagerStatus.Text;
        //Capture check box performance target
        string PerformanceTarget = chkPerformanceTarget.Text;
        ////Capture the date
        string StartDate = txtStartDate.Text;
        //variable to store error message
        string Error = "";
        //validate the data
        Error = Staff.Valid(Name, Role, ShiftType, StartDate);
        if(Error == "")
        {
            //Capture the staff id
            Staff.StaffID = StaffID;
            //Capture the Name
            Staff.Name = Name;
            //Capture the Role
            Staff.Role = Role;
            //Capture Shift Type
            Staff.ShiftType = ShiftType;
            //Capture the date
            Staff.StartDate = Convert.ToDateTime(txtStartDate.Text);
            //Capture performance target
            Staff.PerformanceTarget = chkPerformanceTarget.Checked;
            //capture manager status
            Staff.ManagerStatus = chkManagerStatus.Checked;
            //create new instance of staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //If this is a new record, then add the data
            if(StaffID == -1)
            {
                //set thisstaff property
                StaffList.ThisStaff = Staff;
                //add new record
                StaffList.Add();

            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffID);
                //set thisstaff property
                StaffList.ThisStaff = Staff;
                //update the record
                StaffList.Update();


            }

            //Navigate to list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    

    }


    //protected void btnFind_Click(object sender, EventArgs e)
    //{
    //    //Create instance of staff class
    //    clsStaff Staff = new clsStaff();
    //    //create variable to store primary key
    //    Int32 StaffID;
    //    //variable to store result
    //    Boolean Found = false;
    //    //Get primary key entered by user
    //    StaffID = Convert.ToInt32(txtStaffId.Text);
    //    //find the record
    //    Found = Staff.Find(StaffID);
    //    //if found
    //    if (Found == true);
    //    {
    //        //Display the values of the properties in the form
    //        txtName.Text = Staff.Name;
    //        txtRole.Text = Staff.Role;  
    //        txtShiftType.Text = Staff.ShiftType;
    //        txtStartDate.Text = Staff.StartDate.ToString();
    //        chkManagerStatus.Checked = Staff.ManagerStatus;
    //        chkPerformamceTarget.Checked = Staff.PerformanceTarget;
    //    }
        

    //}

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //Create instance of staff class
        clsStaff Staff = new clsStaff();
        //create variable to store primary key
        Int32 StaffID;
        //variable to store result
        Boolean Found = false;
        //Get primary key entered by user
        StaffID = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = Staff.Find(StaffID);
        //if found
        if (Found == true) ;
        {
            //Display the values of the properties in the form
            txtName.Text = Staff.Name;
            txtRole.Text = Staff.Role;
            txtShiftType.Text = Staff.ShiftType;
            txtStartDate.Text = Staff.StartDate.ToString();
            chkManagerStatus.Checked = Staff.ManagerStatus;
            chkPerformanceTarget.Checked = Staff.PerformanceTarget;
        }
    }

    void DisplayStaff()
    {
        //create instance of staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find record to update
        StaffBook.ThisStaff.Find(StaffID);
        //display data for the record
        txtStaffId.Text = StaffBook.ThisStaff.StaffID.ToString();
        txtName.Text = StaffBook.ThisStaff.Name.ToString();
        txtRole.Text = StaffBook.ThisStaff.Role.ToString();
        txtShiftType.Text = StaffBook.ThisStaff.ShiftType.ToString();
        txtStartDate.Text = StaffBook.ThisStaff.StartDate.ToString();
        chkPerformanceTarget.Checked = StaffBook.ThisStaff.PerformanceTarget;
        chkManagerStatus.Checked = StaffBook.ThisStaff.ManagerStatus;
    }
}