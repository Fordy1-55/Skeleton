using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the order id property
        private Int32 mOrderId;

        //orderId public property
        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }

        //private data member for the order description property
        private string mOrderDescription;
        //orderId public property
        public string OrderDescription
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDescription;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDescription = value;
            }
        }

        //private data member for the order price property
        private double mOrderPrice;
        //orderId public property
        public double OrderPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderPrice;
            }
            set
            {
                //this line of code allows data into the property
                mOrderPrice = value;
            }
        }

        //private data member for the overseas delivery property
        private bool mOverseasDelivery;
        //orderId public property
        public bool OverseasDelivery
        {
            get
            {
                //this line of code sends data out of the property
                return mOverseasDelivery;
            }
            set
            {
                //this line of code allows data into the property
                mOverseasDelivery = value;
            }
        }

        //private data member for the date ordered property
        private DateTime mDateOrdered;
        //orderId public property
        public DateTime DateOrdered
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOrdered;
            }
            set
            {
                //this line of code allows data into the property
                mDateOrdered = value;
            }
        }

        //private data member for the return address property
        private string mReturnAddress;
        //orderId public property
        public string ReturnAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mReturnAddress;
            }
            set
            {
                //this line of code allows data into the property
                mReturnAddress = value;
            }
        }

        //private data member for the delivery instructions property
        private string mDeliveryInstructions;
        //orderId public property
        public string DeliveryInstructions
        {
            get
            {
                //this line of code sends data out of the property
                return mDeliveryInstructions;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryInstructions = value;
            }
        }



        /******* FIND METHOD ******/
        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mOrderDescription = Convert.ToString(DB.DataTable.Rows[0]["OrderDescription"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOrdered"]);
                mOrderPrice = Convert.ToDouble(DB.DataTable.Rows[0]["OrderPrice"]);
                mOverseasDelivery = Convert.ToBoolean(DB.DataTable.Rows[0]["OverseasDelivery"]);
                mReturnAddress = Convert.ToString(DB.DataTable.Rows[0]["ReturnAddress"]);
                mDeliveryInstructions = Convert.ToString(DB.DataTable.Rows[0]["DeliveryInstructions"]);
                //return that everything worked okay
                return true;
            }
            //if no record found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string orderDescription, string deliveryInstructions, string returnAddress, object dateOrdered, string orderPrice)
        {
            //create a string variable to store the error
            String Error = "";
            if (orderDescription.Length == 0)
            {
                //record the error
                Error = Error + "The Order Description may not be blank : ";
            }
            if (orderDescription.Length > 50)
            {
                Error = Error + "The Order Description must be less than 51 characters : ";
            }
            //return any error messages
            return Error;

        }
    }
}