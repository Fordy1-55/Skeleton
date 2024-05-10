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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order Description
        AnOrder.OrderDescription = txtOrderDescription.Text;
        //capture the orderID
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrder.OrderPrice = Convert.ToDouble(txtPrice.Text);
        AnOrder.DateOrdered = Convert.ToDateTime(txtDateOrdered.Text);
        AnOrder.DeliveryInstructions = txtDeliveryInstructions.Text;
        AnOrder.ReturnAddress = txtReturnAddress.Text;
        AnOrder.OverseasDelivery = chkOverseas.Checked;
        //store the description in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");



    }
}