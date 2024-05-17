﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        //Capture the StaffID
        Staff.StaffID= Convert.ToInt32(txtStaffId.Text);
        //Capture the Name
        Staff.Name = txtName.Text;
        //Capture the Role
        Staff.Role = txtRole.Text;
        //Capture Shift Type
        Staff.ShiftType = txtShiftType.Text;
        //Capture check box manager
        Staff.ManagerStatus = chkManagerStatus.Checked;
        //Capture check box performance target
        Staff.PerformanceTarget = chkPerformamceTarget.Checked;
        //Capture the date
        Staff.StartDate = Convert.ToDateTime(txtStartDate.Text);
        //Store staff id in session object
        Session["Staff"] = Staff;
        //Navigate to view
        Response.Redirect("StaffViewer.aspx");



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
            chkPerformamceTarget.Checked = Staff.PerformanceTarget;
        }
    }
}