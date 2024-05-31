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
        if (IsPostBack == false)
        {
            DisplaySuppliers();
        }
    }

    private void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["SupplierID"] = -1;
        Response.Redirect("SupplierDataEntry");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;
        if(lstSupplierList.SelectedIndex!=-1)
        {
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}