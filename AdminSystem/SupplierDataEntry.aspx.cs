using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
            if(SupplierID != -1)
            {
                DisplaySupplier();
            }
        }
    }

    void DisplaySupplier()
    {
        clsSupplierCollection supplierCollection = new clsSupplierCollection();
        supplierCollection.ThisSupplier.Find(SupplierID);
        txtSupplierID.Text = supplierCollection.ThisSupplier.SupplierID.ToString();
        txtSupplierName.Text = supplierCollection.ThisSupplier.SupplierName.ToString();
        txtSupplierContactEmail.Text = supplierCollection.ThisSupplier.SupplierContactEmail.ToString();
        chkAvailability.Checked = supplierCollection.ThisSupplier.Availability;
        txtSupplierAddDate.Text = supplierCollection.ThisSupplier.SupplierAddDate.ToString();
        txtSupplierContactPhone.Text = supplierCollection.ThisSupplier.SupplierAddDate.ToString();
        txtSupplierCity.Text = supplierCollection.ThisSupplier.SupplierCity.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //new instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();
        //Capture the supplier name
        string supplierName = txtSupplierName.Text;
        //Capture the Supplier ID
        string supplierID = txtSupplierID.Text;
        //Capture the Supplier email
        string supplierContactEmail = txtSupplierContactEmail.Text;
        //Capture the supplier phone
        string supplierContactPhone = txtSupplierContactPhone.Text;
        //Capture the supplier City
        string supplierCity = txtSupplierCity.Text;
        //Capture the date added
        string supplierAddDate = txtSupplierAddDate.Text;
        //Capture the availabitlity
        string Availability = chkAvailability.Text;

        string Error = "";
        Error = ASupplier.Valid(supplierName, supplierContactEmail, supplierContactPhone, supplierCity, supplierAddDate);
        if (Error == "")
        {
            ASupplier.SupplierName = supplierName;
            ASupplier.SupplierContactEmail = supplierContactEmail;
            ASupplier.SupplierCity = supplierCity;  
            ASupplier.SupplierContactPhone = supplierContactPhone;
            ASupplier.SupplierAddDate = Convert.ToDateTime(supplierAddDate);
            ASupplier.Availability = Convert.ToBoolean(Availability);
            ASupplier.SupplierID = Convert.ToInt32(SupplierID);

            clsSupplierCollection SupplierList = new clsSupplierCollection();
            if (SupplierID == -1)
            {
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Add();
                Response.Redirect("SupplierList.aspx");
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierID);
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Update();
            }
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