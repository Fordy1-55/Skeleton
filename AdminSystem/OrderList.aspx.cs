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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the Order Collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of addresses in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "OrderDescription";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store primary key of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit :";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the recrod to be deleted
        Int32 OrderId;
        // if the recrod has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsOrderCollection AnOrder = new clsOrderCollection();
        //retrieve the value of address from the presentation layer
        AnOrder.ReportByOrderDescription(txtOrderDescriptionFilter.Text);
        //set the data source to the list of addresses in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "OrderDescription";
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrder = new clsOrderCollection();
        AnOrder.ReportByOrderDescription("");
        txtOrderDescriptionFilter.Text = "";
        lstOrderList.DataSource = AnOrder.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "OrderDescription";
        lstOrderList.DataBind();
    }

}



