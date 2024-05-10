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

        private string mOrderDescription;
        public string OrderDescription
        {
            get
            {
                return mOrderDescription;
            }
            set
            {
                mOrderDescription = value;
            }
        }

        private double mOrderPrice;
        public double OrderPrice
        {
            get
            {
                return mOrderPrice;
            }
            set
            {
                mOrderPrice = value;
            }
        }

        private bool mOverseasDelivery;
        public bool OverseasDelivery
        {
            get
            {
                return mOverseasDelivery;
            }
            set
            {
                mOverseasDelivery = value;
            }
        }

        private DateTime mDateOrdered;
        public DateTime DateOrdered
        {
            get
            {
                return mDateOrdered;
            }
            set
            {
                mDateOrdered = value;
            }
        }

        private string mReturnAddress;
        public string ReturnAddress

        public string DeliveryInstructions { get; set; }

        public bool Find(int OrderId)
        {
            //set the private data members the test data value
            mOrderId = 25;
            mOrderDescription = "Test Description";
            mDateOrdered = Convert.ToDateTime("19/10/2003");
            mOrderPrice = Convert.ToDouble("1.99");
            mOverseasDelivery = true;
            mReturnAddress = "Test Address";
            //always return true
            return true;
        }
    }
}