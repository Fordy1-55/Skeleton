using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private member data for the CusomerId property
        private Int32 mCustomerID;

        // CustomerID public property
        public Int32 CustomerID
        {

            get 
            {
            //This line of code sends data outside the property
            return mCustomerID;
            }
            set
            {
                //This lie of code allows data inside of the property
                mCustomerID = value;
            }
        }

        // private data member for the date added property
        private DateTime mDateOfBirth;
        // DateAdded Public Property

        public DateTime DateOfBirth
        {
            get
            {
                // This Line of code sends data out of the property
                return mDateOfBirth;

            }

            set
            {
                // This line of code allows data inside of the property
                mDateOfBirth = value;
            }

        }

             // private data member for the date added property
        private String mCustomerAddress;
        // DateAdded Public Property

        public String CustomerAddress
        {
            get
            {
                // This Line of code sends data out of the property
                return mCustomerAddress;

            }

            set
            {
                // This line of code allows data inside of the property
                mCustomerAddress = value;
            }
        }

        // private data member for the date added property
        private String mCustomerEmail;
        // DateAdded Public Property

        public String CustomerEmail
        {
            get
            {
                // This Line of code sends data out of the property
                return mCustomerEmail;

            }

            set
            {
                // This line of code allows data inside of the property
                mCustomerEmail = value;
            }
        }

        // private data member for the date added property
        private String mCustomerTelephoneNo;
        // DateAdded Public Property

        public String CustomerTelephoneNo
        {
            get
            {
                // This Line of code sends data out of the property
                return mCustomerTelephoneNo;

            }

            set
            {
                // This line of code allows data inside of the property
                mCustomerTelephoneNo= value;
            }
        }

        // private data member for the date added property
        private String mCustomerName;
        // DateAdded Public Property

        public String CustomerName
        {
            get
            {
                // This Line of code sends data out of the property
                return mCustomerName;

            }

            set
            {
                // This line of code allows data inside of the property
                mCustomerName = value;
            }
        }

        //private data member for the active property
        private Boolean mSubscription;
        //active public property
        public bool Subscription
        {
            get
            {
                //this line of code sends data out of the property
                return mSubscription;
            }
            set
            {
                //this line of code allows data into the property
                mSubscription = value;
            }
        }





        public bool Find(int customerID)
        {
            //Create and Instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the customer id to search for 
            DB.AddParameter("@CustomerID", customerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerTelephoneNo = Convert.ToString(DB.DataTable.Rows[0]["CustomerTelephoneNo"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mSubscription = Convert.ToBoolean(DB.DataTable.Rows[0]["Subscription"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;

            }

        }
    }  

    }


