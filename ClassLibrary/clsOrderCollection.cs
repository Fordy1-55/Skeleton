using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //constructor for the class
        public clsOrderCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields for the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.OrderDescription = Convert.ToString(DB.DataTable.Rows[Index]["OrderDescription"]);
                AnOrder.DateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOrdered"]);
                AnOrder.OrderPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["OrderPrice"]);
                AnOrder.OverseasDelivery = Convert.ToBoolean(DB.DataTable.Rows[Index]["OverseasDelivery"]);
                AnOrder.ReturnAddress = Convert.ToString(DB.DataTable.Rows[Index]["ReturnAddress"]);
                AnOrder.DeliveryInstructions = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryInstructions"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
        








        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();



        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //worry about this later
            }
        }





        public clsOrder ThisOrder { get; set; }
    }
}