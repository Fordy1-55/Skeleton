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
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //get the data from the session object
        AnStock = (clsStock)Session["AnStock"];
        //display the prodcut Title for this entry
        Response.Write(AnStock.ProductTitle);
        //display the prodcut Description for this entry
        Response.Write(AnStock.ProductDescription);
        //display the prodcut Colour for this entry
        Response.Write(AnStock.ProductColour);
        //display the prodcut Id for this entry
        Response.Write(AnStock.ProductId);
        //display the prodcut Price for this entry
        Response.Write(AnStock.ProductPrice);
        //display the prodcut Date for this entry
        Response.Write(AnStock.DateAdded);
        //display the prodcut 'Available' for this entry
        Response.Write(AnStock.Available);

    }
}