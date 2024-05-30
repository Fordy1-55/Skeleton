using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primarykey with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderId != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }





    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order Description
        string OrderDescription = txtOrderDescription.Text;
        //capture the orderID
        string OrderPrice = txtPrice.Text;
        string DateOrdered = txtDateOrdered.Text;
        string DeliveryInstructions = txtDeliveryInstructions.Text;
        string ReturnAddress = txtReturnAddress.Text;
        string OverseasDelivery = chkOverseas.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
        if (Error == "")
        {
            //capture the data
            AnOrder.OrderId = OrderId;
            AnOrder.OrderDescription = OrderDescription;
            AnOrder.OrderPrice = Convert.ToDecimal(OrderPrice);
            AnOrder.DateOrdered = Convert.ToDateTime(DateOrdered);
            AnOrder.DeliveryInstructions = DeliveryInstructions;
            AnOrder.ReturnAddress = ReturnAddress;
            AnOrder.OverseasDelivery = chkOverseas.Checked;
            //create a new instance of OrderCollection
            clsOrderCollection OrderList = new clsOrderCollection();
            
            //if this is a new record
            if (OrderId == -1)
            {
                //Set the ThisOrder Property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }

            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }



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

    void DisplayOrder()
    {
        //create an instance of the address book
        clsOrderCollection AnOrder = new clsOrderCollection();
        //find the record to update
        AnOrder.ThisOrder.Find(OrderId);
        //display the data for the record
        txtOrderId.Text = AnOrder.ThisOrder.OrderId.ToString();
        txtOrderDescription.Text = AnOrder.ThisOrder.OrderDescription;
        txtPrice.Text = AnOrder.ThisOrder.OrderPrice.ToString();
        txtDateOrdered.Text = AnOrder.ThisOrder.DateOrdered.ToString();
        txtDeliveryInstructions.Text = AnOrder.ThisOrder.DeliveryInstructions;
        txtReturnAddress.Text = AnOrder.ThisOrder.ReturnAddress;
        chkOverseas.Checked = AnOrder.ThisOrder.OverseasDelivery;
    }



    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list
        Response.Redirect("OrderList.aspx");
    }
}