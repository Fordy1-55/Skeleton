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


        public bool Find(int OrderId)
        {
            //set the private data members the test data value
            mOrderId = 25;
            mOrderDescription = "Test Description";
            mDateOrdered = Convert.ToDateTime("19/10/2003");
            mOrderPrice = Convert.ToDouble("1.99");
            mOverseasDelivery = true;
            mReturnAddress = "Test Address";
            mDeliveryInstructions = "Test Instructions";
            //always return true
            return true;
        }
    }
}