using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        // private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        // public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                //set private data
                mCustomerList = value;

            }

        }

        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public clsCustomerCollection()
        //{
        //    //create the Items of the test data
        //    clsCustomer TestItem = new clsCustomer();
        //    //set its properties
        //    TestItem.Subscription = true;
        //    TestItem.CustomerID = 6;
        //    TestItem.CustomerName = "Sab";
        //    TestItem.DateOfBirth = DateTime.Now;
        //    TestItem.CustomerEmail = "sab.smith@hotmail.com";
        //    TestItem.CustomerAddress = "18 Main Street";
        //    TestItem.CustomerTelephoneNo = "0768349761";
        //    //add the test item to the test list
        //    mCustomerList.Add(TestItem);
        //    // re initiliase the object for some new data
        //    TestItem = new clsCustomer();
        //    //set its properties
        //    TestItem.Subscription = true;
        //    TestItem.CustomerID = 2;
        //    TestItem.CustomerName = "Olivia";
        //    TestItem.DateOfBirth = DateTime.Now;
        //    TestItem.CustomerEmail = "Olivia@gmail.com";
        //    TestItem.CustomerAddress = "64 Zoo Lane";
        //    TestItem.CustomerTelephoneNo = "0784365860";
        //}

        //constructor for the class
        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields for the current records
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                AnCustomer.CustomerTelephoneNo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerTelephoneNo"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.Subscription = Convert.ToBoolean(DB.DataTable.Rows[Index]["Subscription"]);

            }

        
        
        }
        public clsCustomer ThisCustomer { get; set; }
    }


}