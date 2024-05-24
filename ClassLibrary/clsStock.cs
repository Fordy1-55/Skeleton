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
        private decimal mProductPrice;
        // public property    
        public decimal ProductPrice
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
                mProductPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ProductPrice"]);
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

        public string Valid(string productDescription, string productTitle, string productColour, string productDate, string productPrice)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            Decimal PriceTemp;

            /*********************** Product Description ***********************/
            if (productDescription.Length == 0) 
            {
                
                Error = Error + "The product description may not be blank : ";
            }
            if (productDescription.Length > 250) 
            {
                
                Error = Error + "The product description must be less than 250 : ";
            }

            /*********************** Product Colour ***********************/
       
            if (productTitle.Length == 0)
            {
                
                Error = Error + "The product title may not be blank : ";
            }
            if (productTitle.Length > 50)
            {
                
                Error = Error + "The product title must be less than 50 : ";
            }

            /*********************** Product Colour ***********************/

            if (productColour.Length == 0)
            {

                Error = Error + "The product colour may not be blank : ";
            }
            if (productColour.Length > 50)
            {

                Error = Error + "The product colour must be less than 50 : ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                
                DateTemp = Convert.ToDateTime(productDate);
              
                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                
                if (DateTemp > DateComp)
                {
                    
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //create an instance of the Decimal to compare with PriceTemp
            //in the if statement
            try
            {
                PriceTemp = Convert.ToDecimal(productPrice);
                if (PriceTemp < 0.01M)
                {
                    Error = Error + "The Price cannot be less than £0.01 : ";
                }
            }
            catch
            {
                Error = Error + "This is an invalid Price!";
            }

            //return any error message
            return Error;
        }
    }
}