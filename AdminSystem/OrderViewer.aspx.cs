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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the order description for this entry
        Response.Write(AnOrder.OrderId);
        Response.Write(AnOrder.OrderDescription);
        Response.Write(AnOrder.DateOrdered);
        Response.Write(AnOrder.OrderPrice);
        Response.Write(AnOrder.ReturnAddress);
        Response.Write(AnOrder.DeliveryInstructions);
        Response.Write(AnOrder.OverseasDelivery);






    }
}