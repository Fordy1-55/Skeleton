using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ProductId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        ProductId = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ProductId != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        //create an instance of the product book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update
        StockBook.ThisStock.Find(ProductId);
        //display the data for the record
        txtProductId.Text = StockBook.ThisStock.ProductId.ToString();
        txtProductDate.Text = StockBook.ThisStock.ProductDate.ToString();
        txtProductPrice.Text = StockBook.ThisStock.ProductPrice.ToString();
        txtProductTitle.Text = StockBook.ThisStock.ProductTitle;
        txtProductDescription.Text = StockBook.ThisStock.ProductDescription;
        txtProductColour.Text = StockBook.ThisStock.ProductColour;
        ChkAvaible.Checked = StockBook.ThisStock.ProductAvailable;
    }

 
    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the Product Title, Product Description, Product Colour, Product Id, Product Price, Date Added, Available check box
        string ProductTitle = txtProductTitle.Text;
        string ProductDescription = txtProductDescription.Text;
        string ProductColour = txtProductColour.Text;
        string ProductPrice = txtProductPrice.Text;
        string ProductDate = txtProductDate.Text;
        string ProductAvailable = ChkAvaible.Text;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AnStock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
        if (Error == "")
        {
            //capture the Product Title, Product Description, Product Colour, Product Price, Date Added
            AnStock.ProductId = ProductId; // DON'T MISS THIS BIT!!!    
            AnStock.ProductTitle = ProductTitle;
            AnStock.ProductDescription = ProductDescription;
            AnStock.ProductColour = ProductColour;
            AnStock.ProductDate = Convert.ToDateTime(ProductDate);            
            AnStock.ProductPrice = Convert.ToDecimal(ProductPrice);
            AnStock.ProductAvailable = ChkAvaible.Checked;
            //create a new instance of this stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e ProductId = -1 then add the data
            if (ProductId == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AnStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(ProductId);
                //set the ThisStock property
                StockList.ThisStock = AnStock;
                //update the record
                StockList.Update();
            }

            //redirect back to the list page          
            Response.Redirect("StockList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
      
    }


    protected void BTNfIND_Click(object sender, EventArgs e)
    {
        //create an instance of the sock class
        clsStock AnStock = new clsStock();
        //create a variable to score the primary key
        Int32 ProductId;
        //create a variable to store the results of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ProductId = Convert.ToInt32(txtProductId.Text);
        //find the recore
        Found = AnStock.Find(ProductId);
        //iffound
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtProductId.Text = AnStock.ProductId.ToString();
            txtProductDate.Text = AnStock.ProductDate.ToString();
            txtProductPrice.Text = AnStock.ProductPrice.ToString();
            txtProductTitle.Text = AnStock.ProductTitle;
            txtProductDescription.Text = AnStock.ProductDescription;
            txtProductColour.Text = AnStock.ProductColour;
            ChkAvaible.Checked = AnStock.ProductAvailable;


        }
    }

    protected void txtProductId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProductTitle_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProductDescription_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProductColour_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProductPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProductDate_TextChanged(object sender, EventArgs e)
    {

    }
}