using System;

namespace ClassLibrary
{
    public class clsStock
    {
       
        //private data member for the Date property
        private DateTime mProductDate;
        //Date public property
        public DateTime ProductDate
        {
            get
            {
                //this line of code sends data out of the property
                return mProductDate;
            }
            set
            {
                //this line of code allows data into the property
                mProductDate = value;
            }
        }


        //private data member for the product id property
        private Int32 mProductId;
        //ProductId public property
        public Int32 ProductId
        {
            get 
            {
                //this line of code sends data out of the property
                return mProductId;
            }
            set 
            {
                //this line of code allows data into the property
                mProductId = value;
            }
        }


        //private data member for the  property
        private double mProductPrice;
        // public property    
        public double ProductPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mProductPrice;
            }
            set
            {
                //this line of code allows data into the property
                mProductPrice = value;
            }
        }



        //private data member for the  property
        private string mProductTitle;
        // public property
        public string ProductTitle
        {
            get
            {
                //this line of code sends data out of the property
                return mProductTitle;
            }
            set
            {
                //this line of code allows data into the property
                mProductTitle = value;
            }
        }


        //private data member for the  property
        private string mProductDescription;
        // public property
        public string ProductDescription
        {
            get
            {
                //this line of code sends data out of the property
                return mProductDescription;
            }
            set
            {
                //this line of code allows data into the property
                mProductDescription = value;
            }
        }


        //private data member for the  property
        private string mProductColour;
        // public property
        public string ProductColour
        {
            get
            {
                //this line of code sends data out of the property
                return mProductColour;
            }
            set
            {
                //this line of code allows data into the property
                mProductColour = value;
            }
        }


        //private data member for the  property
        private Boolean mProductAvailable;
        // public property
        public bool ProductAvailable
        {
            get
            {
                //this line of code sends data out of the property
                return mProductAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mProductAvailable = value;
            }
        }


        /**********************************FIND METHOD***********************************/
        public bool Find(int ProductId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", ProductId);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByProductId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the database to the private data members
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mProductDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ProductDate"]);
                mProductAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["ProductAvailable"]);
                mProductPrice = Convert.ToDouble(DB.DataTable.Rows[0]["ProductPrice"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mProductTitle = Convert.ToString(DB.DataTable.Rows[0]["ProductTitle"]);
                mProductColour = Convert.ToString(DB.DataTable.Rows[0]["ProductColour"]);
                //return that everything worked OK
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