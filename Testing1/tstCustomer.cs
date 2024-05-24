using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices.ComTypes;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data

        string CustomerName = "Sabs";
        string CustomerAddress = "18 Main Street";
        string CustomerTelephoneNo = "0768349761";
        string CustomerEmail = "Sab.smith@hotmail.com";
        string DateOfBirth = DateTime.Now.ToShortDateString();

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an new instance
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message 
            string Error = "";
            //Invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see thta the results are correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerNameMinLessOne()
        {
            // create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string CustomerName = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "S"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "Ss"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "Sssssssss"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerNameNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "ssssssssss"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);     
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "sssss"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "S";
            CustomerName = CustomerName.PadRight(100, 's'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "sssssssssss"; //this should fail
                                                 //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth); 
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateOfBirthInvalidData()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //String variable to store any error message
            String Error = "";
            //set the DateOfBirth to a non date value
            string DateOfBirth = "This is not a date!";
            //Invoke method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerAddress = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerAddress = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);                 
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerEmail = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer  = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerEmail = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerEmail, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerTelephoneNo = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTelephoneNo = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerTelephoenNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTelephoneNo = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTelephoneNo = "";
            CustomerTelephoneNo = CustomerTelephoneNo.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelephoneNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTelephoneNo = "";
            CustomerTelephoneNo = CustomerTelephoneNo.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void CustomerTelephoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerTelephoneNo = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerTelephoneNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTelephoneNo = "";
            CustomerTelephoneNo = CustomerTelephoneNo.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerName, CustomerAddress, CustomerTelephoneNo, CustomerAddress, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }













    }











}