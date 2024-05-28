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
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        //create an instance of the stock collection
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to the list of stocks in the collection
        lstStockList.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ProductId";
        //set the data field to display
        lstStockList.DataTextField = "ProductTitle";
        //bind the data tp the list
        lstStockList.DataBind();
    }

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["ProductId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value  of the record to be edited
        Int32 ProductId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key of the record to edit
            ProductId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the adata in the session object
            Session["ProductId"] = ProductId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else       //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit :";
        }
    }
}