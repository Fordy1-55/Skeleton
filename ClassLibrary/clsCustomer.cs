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
            //set the private data members to the test data value
            mCustomerID = 4;
            mDateOfBirth = Convert.ToDateTime("12/06/2002");
            mCustomerAddress = "14 Maiden Drive";
            mCustomerEmail = "BillyRussel@hotmail.com";
            mCustomerTelephoneNo = "0734964327";
            mCustomerName = "Billy";
            mSubscription = true;
            //always return true
            return true;
        }
    }  

    }


