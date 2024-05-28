using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    public class clsStockCollection
    {

        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private member data ofr thisStock
        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        { get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //Set the private data
                mStockList = value;
            }
        }

        public int StockCount
        {
            get
            {
                //return the count list
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock 
        {
            get 
            {
                //return private data
                return mThisStock;
            }
            set 
            {
                //set the private data
                mThisStock = value;
            } 
        }


        public int Add()
        {
            //adds a record to the database based on the value of mThisSTock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductAvailable", mThisStock.ProductAvailable);
            DB.AddParameter("@ProductPrice", mThisStock.ProductPrice);
            DB.AddParameter("@ProductDate", mThisStock.ProductDate);
            DB.AddParameter("@ProductDescription", mThisStock.ProductDescription);
            DB.AddParameter("@ProductTitle", mThisStock.ProductTitle);
            DB.AddParameter("@ProductColour", mThisStock.ProductColour);

            //return the primary key of the new record
            return DB.Execute("sproc_tblProduct_Insert");
        }


        //constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable for index
            Int32 RecordCount = 0;
            //object for the data
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("sproc_tblProduct_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount) 
            {
                //create a blank stock
                clsStock AnStock = new clsStock();
                //read i the fields for the currecnt reocrd
                AnStock.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AnStock.ProductDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ProductDate"]);
                AnStock.ProductAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["ProductAvailable"]);
                AnStock.ProductPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ProductPrice"]);
                AnStock.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                AnStock.ProductTitle = Convert.ToString(DB.DataTable.Rows[Index]["ProductTitle"]);
                AnStock.ProductColour = Convert.ToString(DB.DataTable.Rows[Index]["ProductColour"]);
                //add the record to the private data member
                mStockList.Add(AnStock);
                //point at the next record
                Index++;
            }

            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ProductAvailable = true;
            TestItem.ProductId = 1;
            TestItem.ProductDate = DateTime.Now;
            TestItem.ProductPrice = 6.25M;
            TestItem.ProductDescription = "Test Description";
            TestItem.ProductTitle = "Test Title";
            TestItem.ProductColour = "Test Colour";
            //add the test item to the test list
            mStockList.Add(TestItem);
            //re intialise the object for some new data
            TestItem = new clsStock();
            //set its properties
            TestItem.ProductAvailable = true;
            TestItem.ProductId = 2;
            TestItem.ProductDate = DateTime.Now;
            TestItem.ProductPrice = 6.50M;
            TestItem.ProductDescription = "Test Didderent Description";
            TestItem.ProductTitle = "Test Another Title";
            TestItem.ProductColour = "Test Diiferent Colour";
            //add the item to the test list
            mStockList.Add(TestItem);
        }

    }
}