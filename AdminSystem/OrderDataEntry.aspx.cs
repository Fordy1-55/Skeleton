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


    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderId.Text = AnOrder.OrderId.ToString();
            txtOrderDescription.Text = AnOrder.OrderDescription;
            txtPrice.Text = AnOrder.OrderPrice.ToString();
            txtDateOrdered.Text = AnOrder.DateOrdered.ToString();
            txtDeliveryInstructions.Text = AnOrder.DeliveryInstructions;
            txtReturnAddress.Text = AnOrder.ReturnAddress;
            chkOverseas.Checked = AnOrder.OverseasDelivery;
        }
    }
}