using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

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

        public void CustomerIDPropertyOK()

        {
            clsCustomer AnCustomer = new clsCustomer();



            int TestData = 1;
            AnCustomer.CustomerID = TestData;
            Assert.AreEqual(AnCustomer.CustomerID, TestData);


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
            AnCustomer.CustomerTelephoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerTelephoneNo, TestData);
        }
      

        [TestMethod]
        public void TestSubscriptionFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 6;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the active property
            if (AnCustomer.Subscription != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 6;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the date added property
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("09/04/2003"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestCustomerEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume that it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 CustomerID = 6;
            // invoke the method
            Found = AnCustomer.Find(CustomerID);
            // check the customerAddress
            if (AnCustomer.CustomerEmail != "sab.smith@hotmail.com")

            {

                OK = false;
            }
            // test to see if the results is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]

        public void FindMethodOK()

        {   //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 6;
            //Invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);


        }

        [TestMethod]

        public void TestCustomerTelephoneNoFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume that it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 CustomerID = 6;
            // invoke the method
            Found = AnCustomer.Find(CustomerID);
            // check the customerAddress
            if (AnCustomer.CustomerTelephoneNo != "0768349761")

            {

                OK = false;
            }
            // test to see if the results is correct
            Assert.IsTrue(OK);


        }


        [TestMethod]

        public void TestCustomerNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume that it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 CustomerID = 6;
            // invoke the method
            Found = AnCustomer.Find(CustomerID);
            // check the customerAddress
            if (AnCustomer.CustomerName != "Sab")

            {

                OK = false;
            }
            // test to see if the results is correct
            Assert.IsTrue(Found);


        }


        [TestMethod]

        public void TestCustomerAddressFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume that it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 CustomerID = 6;
            // invoke the method
            Found = AnCustomer.Find(CustomerID);
            // check the customerAddress
            if (AnCustomer.CustomerAddress != "18 Main Street")

            {

                OK = false;
            }
            // test to see if the results is correct
            Assert.IsTrue(Found);


        }



        [TestMethod]

        public void TestCustomerIDFound()

        {
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume that it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 CustomerID = 6;
            // invoke the method
            Found = AnCustomer.Find(CustomerID);
            // check the customerID
            if (AnCustomer.CustomerID != 6)

            {
      
                OK = false;
            }
            // test to see if the results is correct
            Assert.IsTrue(OK);
       
        }
    }
   
    

        


}