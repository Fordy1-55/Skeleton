using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
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
            AnCustomer.SubscriptionProperty = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnCustomer.SubscriptionProperty, TestData);

        }
        [TestMethod]

        public void DateOfBirthPropertyOK()

        // Instance for the class
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the poperty
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to a property
            AnCustomer.DateOfBirthProperty = TestData;
            // test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.DateOfBirthProperty, TestData);

        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Customer Name";
            //assign the data to the property
            AnCustomer.CustomerNameProperty = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerNameProperty, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Customer Email";
            //assign the data to the property
            AnCustomer.CustomerEmailProperty = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerEmailProperty, TestData);

        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "CustomerAddress";
            //assign the data to the property
            AnCustomer.CustomerAddressProperty = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerAddressProperty, TestData);
        }

        [TestMethod]
        public void CustomerTelephoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Customer Telephone Number";
            //assign the data to the property
            AnCustomer.CustomerTelphoneNoProperty = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerTelphoneNoProperty, TestData);
        }

    }
}
