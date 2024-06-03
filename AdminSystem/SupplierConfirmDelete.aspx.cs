using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
    }

    protected void btnCnfrmY_Click(object sender, EventArgs e)
    {
        clsSupplierCollection SupplierList = new clsSupplierCollection();
        SupplierList.ThisSupplier.Find(SupplierID);
        SupplierList.Delete();
        Response.Redirect("SupplierList.aspx");
    }


    protected void btnCnfrmN_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }
}