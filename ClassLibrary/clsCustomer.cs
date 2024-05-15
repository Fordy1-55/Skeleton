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


        public string CustomerAddress { get; set; }
        public bool Subscription { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTelphoneNo { get; set; }
        public string CustomerEmail { get; set; }

        public bool Find(int customerID)
        {
            //set the private data members to the test data value
            mCustomerID = 4;
           //always return true
           return true;
        }
    }

}
