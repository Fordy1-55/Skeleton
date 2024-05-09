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
        //New instance of clsSupplier
         clsSupplier ASupplier = new clsSupplier();
        //Get the data from the session object
        ASupplier = (clsSupplier)Session["ASupplier"];
        //Display the supplier for this entry
        Response.Write(ASupplier.SupplierName);
        Response.Write(ASupplier.SupplierID);
        Response.Write(ASupplier.SupplierContactEmail);
        Response.Write(ASupplier.SupplierContactPhone);
        Response.Write(ASupplier.SupplierCity);
        Response.Write(ASupplier.SupplierAddDate);
        Response.Write(ASupplier.Availability);
    }
}