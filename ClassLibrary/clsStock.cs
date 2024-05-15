using System;

namespace ClassLibrary
{
    public class clsStock
    {
       
        //private data member for the DateAdded property
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
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


        public bool Find(int ProductId)
        {
            //set the privatre data members to the test data value
            mProductId = 1;
            mDateAdded = Convert.ToDateTime("04/05/2024");
            mProductAvailable = true;
            mProductPrice = Convert.ToDouble(6.25);
            mProductDescription = "Beanie is a brimless, soft, round, stretchy hat that fits snugly on your head – and can be dragged down to your ears. It’s a flexible cap that hugs your head and ears and saves them from freezing in the cold weather";
            mProductTitle = "A Beanie";
            mProductColour = "Black, Blue, Red, Gray, White, Green, Orange, Brown, Purple";
            //always return true
            return true;
        }
    }
}