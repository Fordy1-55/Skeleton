using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //new instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();
        //Capture the supplier name
        ASupplier.SupplierName = txtSupplierName.Text;
        //Capture the Supplier ID
        ASupplier.SupplierID = Convert.ToInt32(txtSupplierID.Text);
        //Capture the Supplier email
        ASupplier.SupplierContactEmail = txtSupplierContactEmail.Text;
        //Capture the supplier phone
        ASupplier.SupplierContactPhone = txtSupplierContactPhone.Text;
        //Capture the supplier City
        ASupplier.SupplierCity = txtSupplierCity.Text;
        //Capture the date added
        ASupplier.SupplierAddDate = Convert.ToDateTime(txtSupplierAddDate.Text);
        //Capture the availabitlity
        ASupplier.Availability = Convert.ToBoolean(chkAvailability.Checked);
        //Sotre the name in the session object
        Session["ASupplier"] = ASupplier;
        //navigate to the supplier view page
        Response.Redirect("SupplierViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}