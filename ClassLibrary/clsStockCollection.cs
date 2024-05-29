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

        public void Update()
        {
            //adds a record to the database based on the value of mThisSTock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            DB.AddParameter("@ProductAvailable", mThisStock.ProductAvailable);
            DB.AddParameter("@ProductPrice", mThisStock.ProductPrice);
            DB.AddParameter("@ProductDate", mThisStock.ProductDate);
            DB.AddParameter("@ProductDescription", mThisStock.ProductDescription);
            DB.AddParameter("@ProductTitle", mThisStock.ProductTitle);
            DB.AddParameter("@ProductColour", mThisStock.ProductColour);
            //excute the stored procedure
            DB.Execute("sproc_tblProduct_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            //excute the stored procedure
            DB.Execute("sproc_tblProduct_Delete");
        }

        public void ReportByProductTitle(string ProductTitle)
        {
            //filters the record based on a full or partial proiduct title
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //
            DB.AddParameter("@ProductTitle", ProductTitle);
            //excute the stored procedure
            DB.Execute("sproc_tblProduct_FilteredByProductTitle");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        //constructor for the class
        public clsStockCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //excute stored proceudre
            DB.Execute("sproc_tblProduct_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of reocrd
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock object
                clsStock AnStock = new clsStock();
                //raed in the fields from the current record
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
        }
    }
}