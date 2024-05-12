using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data member for the supplier id property
        private Int32 mSupplierID;
        //private data member for date added property
        private DateTime mSupplierAddDate;
        //private data member for Supplier Name
        private String mSupplierName;
        //private data member for Supplier Email
        private String mSupplierContactEmail;
        //private data member for Supplier Phone
        private String mSupplierContactPhone;
        //private data member for Supplier City
        private String mSupplierCity;
        //private data member for Supplier Availability
        private bool mAvailability;
        public bool Availability
        { 
            get
            {
                return mAvailability;
            }
            set
            {
                mAvailability = value;
            }
        }
        public DateTime SupplierAddDate 
        {
            get
            {
                //this line sends data out of the property
                return mSupplierAddDate;
            }
            set
            { 
                //this line allows data into the property
                mSupplierAddDate = value;
            }
        }
        public int SupplierID { 
            get
            {
                //this line sends data out of the property
                return mSupplierID;
            }
            set 
            {
                //this line allows data into the property
                mSupplierID = value;
            } 
        }
        public string SupplierName 
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }
        public string SupplierContactEmail
        { 
            get
            {
                return mSupplierContactEmail;
            }
            set
            {
                mSupplierContactEmail = value;
            }
        }
        public string SupplierContactPhone 
        { 
            get
            {
                return mSupplierContactPhone;
            }
            set
            {  
                mSupplierContactPhone = value;
            }
        }
        public string SupplierCity 
        { 
            get
            {
                return mSupplierCity;
            }
            set
            {
                mSupplierCity = value;  
            }
        }
        /*******FIND METHOD*******/
        public bool Find(int supplierID)
        {
            //set the private data members to the test data value
            mSupplierID = 21;
            mSupplierAddDate = Convert.ToDateTime("12/05/24");
            mSupplierName = "Test Name";
            mAvailability = true;
            mSupplierContactEmail = "Test@Email.com";
            mSupplierContactPhone = "07357960435";

            //always return true
            return true;
        }
    }
}