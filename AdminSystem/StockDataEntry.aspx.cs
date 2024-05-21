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

    protected void txtProductTitle_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProductDescription_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProductColour_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProductId_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtProductPrice_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtProductDate_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the Product Title, Product Description, Product Colour, Product Id, Product Price, Date Added, Available check box
        AnStock.ProductTitle = txtProductTitle.Text;

        AnStock.ProductDescription = txtProductDescription.Text;

        AnStock.ProductColour = txtProductColour.Text;
 
        AnStock.ProductId = Convert.ToInt32(txtProductId.Text);
 
        AnStock.ProductPrice = Convert.ToDouble(txtProductPrice.Text);

        AnStock.ProductDate = Convert.ToDateTime(DateTime.Now);

        AnStock.ProductAvailable = ChkAvaible.Checked;  
        //store the data in the session object
        Session["AnStock"] = AnStock;
        //display the prodcut id for this entry
        Response.Redirect("StockViewer.aspx");
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
}