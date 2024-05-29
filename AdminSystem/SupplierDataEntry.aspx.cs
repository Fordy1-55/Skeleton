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
        string SupplierName = txtSupplierName.Text;
        //Capture the Supplier ID
        string SupplierID = txtSupplierID.Text;
        //Capture the Supplier email
        string SupplierContactEmail = txtSupplierContactEmail.Text;
        //Capture the supplier phone
        string SupplierContactPhone = txtSupplierContactPhone.Text;
        //Capture the supplier City
        string SupplierCity = txtSupplierCity.Text;
        //Capture the date added
        string SupplierAddDate = txtSupplierAddDate.Text;
        //Capture the availabitlity
        string Availability = chkAvailability.Text;

        string Error = "";
        Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
        if (Error == "")
        {
            ASupplier.SupplierName = SupplierName;
            ASupplier.SupplierContactEmail = SupplierContactEmail;
            ASupplier.SupplierCity = SupplierCity;  
            ASupplier.SupplierContactPhone = SupplierContactPhone;
            ASupplier.SupplierAddDate = Convert.ToDateTime(SupplierAddDate);
            ASupplier.Availability = Convert.ToBoolean(Availability);
            ASupplier.SupplierID = Convert.ToInt32(SupplierID);

            clsSupplierCollection SupplierList = new clsSupplierCollection();
            SupplierList.ThisSupplier = ASupplier;
            SupplierList.Add();
            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            //Display the error message
            lblError.Text = Error;
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        Int32 SupplierID;
        Boolean Found = false;
        SupplierID = Convert.ToInt32(txtSupplierID.Text);
        Found = ASupplier.Find(SupplierID);
        if (Found == true)
        {
            txtSupplierName.Text = ASupplier.SupplierName;
            txtSupplierContactEmail.Text = ASupplier.SupplierContactEmail;
            txtSupplierContactPhone.Text = ASupplier.SupplierContactPhone;
            txtSupplierCity.Text = ASupplier.SupplierCity;
            txtSupplierAddDate.Text = ASupplier.SupplierAddDate.ToString();
            chkAvailability.Checked = ASupplier.Availability;
        }
    }


}