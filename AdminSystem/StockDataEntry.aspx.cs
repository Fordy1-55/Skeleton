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


    
}