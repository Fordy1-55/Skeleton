using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private member data for thisOrder
        clsOrder mThisOrder = new clsOrder();



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





        public clsOrder ThisOrder
        {
            get
            {
                //get the private data
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        


        public int Add()
        {
            //adds a record to the database based on the values of mThisOrder
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OverseasDelivery", mThisOrder.OverseasDelivery);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@OrderDescription", mThisOrder.OrderDescription);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@DeliveryInstructions", mThisOrder.DeliveryInstructions);
            DB.AddParameter("@ReturnAddress", ThisOrder.ReturnAddress);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");




        }

        public void Update()
        {
            //update an existing record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@OverseasDelivery", mThisOrder.OverseasDelivery);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@OrderDescription", mThisOrder.OrderDescription);
            DB.AddParameter("@DateOrdered", mThisOrder.DateOrdered);
            DB.AddParameter("@DeliveryInstructions", mThisOrder.DeliveryInstructions);
            DB.AddParameter("@ReturnAddress", ThisOrder.ReturnAddress);
        }
    }




 




}