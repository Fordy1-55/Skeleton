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
        Staff.StaffIDProperty = Convert.ToInt32(txtStaffId.Text);
        //Capture the Name
        Staff.NameProperty = txtName.Text;
        //Capture the Role
        Staff.RoleProperty = txtRole.Text;
        //Capture Shift Type
        Staff.ShiftTypeProperty = txtShiftType.Text;
        //Capture check box manager
        //clsStaff.ManagerStatus = chkManagerStatus.Checked;
        //Capture the date
        Staff.StartDateProperty = Convert.ToDateTime(txtStartDate.Text);
        //Store staff id in session object
        Session["Staff"] = Staff;
        //Navigate to view
        Response.Redirect("StaffViewer.aspx");



    }
}