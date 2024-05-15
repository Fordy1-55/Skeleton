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
            int TestData = 1;
            AnCustomer.CustomerID = TestData;
            Assert.AreEqual(AnCustomer.CustomerID, TestData);

        }

        [TestMethod]

        public void FindMethodOK()

        {   //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //Invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);


        }


        [TestMethod]

        public void TestCustomerIDFound()

        {  clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume that it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 CustomerID = 4;
            // invoke the method
            Found = AnCustomer.Find(CustomerID);
            // check the customerID
            if(AnCustomer.CustomerID != 4)
            {
                OK = false;
            }
            // test to see if the results is correct
            Assert.IsTrue(OK);









        }




    }
}
