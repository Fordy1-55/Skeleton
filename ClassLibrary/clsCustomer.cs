using System;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;

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
                mCustomerTelephoneNo = value;
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

        public string Valid(string CustomerName, string CustomerAddress, string CustomerTelephoneNo, string CustomerEmail, string DateOfBirth)

        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Customer Name is blank
            if (CustomerName.Length == 0)
            {
                //record the error
                Error = Error + "The Customers Name may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (CustomerName.Length > 10)
            {
                //record the error
                Error = Error + "The house no must be less than 10 characters : ";
            }


            // create an instance of DateTime to compare with DateTemp 
            // in the if statement 
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateOfBirth);

                if (DateTemp < DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
           
            
            
            //is the Address blank
            if (CustomerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the Address is too long
            if (CustomerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The Address must be less than 50 characters : ";
            }

            //is the Email blank
            if (CustomerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the Email is too long
            if (CustomerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The Email must be less than 50 characters : ";
            }

            //is the Telephone No blank
            if (CustomerTelephoneNo.Length == 0)
            {
                //record the error
                Error = Error + "The Telephone No may not be blank : ";
            }
            //if the TeleNo is too long
            if (CustomerTelephoneNo.Length > 50)
            {
                //record the error
                Error = Error + "The Telephone No must be less than 50 characters : ";
            }

            //return any error messages        
            return Error;






        }







    }



}


