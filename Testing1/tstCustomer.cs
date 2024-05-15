using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        public int AnCustomerID { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see if it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]

        public void SubscriptionPropertyOK()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            AnCustomer.Subscription = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Subscription, TestData);

        }
        [TestMethod]

        public void DateOfBirthPropertyOK()

        // Instance for the class
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the poperty
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to a property
            AnCustomer.DateOfBirth = TestData;
            // test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);

        }




        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Customer Name";
            //assign the data to the property
            AnCustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Customer Email";
            //assign the data to the property
            AnCustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);


        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "CustomerAddress";
            //assign the data to the property
            AnCustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerTelephoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Customer Telephone Number";
            //assign the data to the property
            AnCustomer.CustomerTelphoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerTelphoneNo, TestData);
        }

        [TestMethod]

        public void CustomerIDPropertyOK()

        {
            clsCustomer AnCustomer = new clsCustomer();
            int TestData =1;
            //clsCustomer.CustomerID = TestData;
            //Assert.AreEqual(clsCustomer.CustomerID, TestData);

        }

        
       


    }
}
