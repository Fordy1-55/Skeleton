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
        public bool Find(int SupplierID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierContactEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierContactEmail"]);
                mSupplierContactPhone = Convert.ToString(DB.DataTable.Rows[0]["SupplierContactPhone"]);
                mSupplierAddDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplierAddDate"]);
                mSupplierCity = Convert.ToString(DB.DataTable.Rows[0]["SupplierCity"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string supplierName, string supplierContactEmail, string supplierContactPhone, string supplierCity, string supplierAddDate)
        {
            String Error = "";
            DateTime DateTemp;
            DateTime DateComp = DateTime.Now.Date;

            if (supplierName.Length < 1 || supplierName.Length > 50)
            {
                Error = Error + "The Name Length cannot exceed 50 characters or be less than 1 character!";
            }
            

            if (supplierContactPhone.Length > 11 || supplierContactPhone.Length < 11)
            {
                Error = Error + "The phone number can be no longer or shorter than 11 characters!";
            }

            if ( supplierCity.Length < 1 || supplierCity.Length > 50)
            {
                Error = Error + "The City name cannot exceed 50 characters or be less than one character!";
            }
            try
            {
                DateTemp = Convert.ToDateTime(supplierAddDate);
                if (DateTemp < DateTime.Now.Date.AddYears(-1) || DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date Added cannot exceed 1 year in the past or be in the future";
                }
            }
            catch
            {
                Error = Error + "The date was not valid";
            }

            return Error;
        }
    }
}