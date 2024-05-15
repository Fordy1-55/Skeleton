using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass the method
        string DateOrdered = DateTime.Now.ToShortDateString();
        string OrderDescription = "Test Description";
        string OrderPrice = "1.99";
        string ReturnAddress = "Test Address";
        string DeliveryInstructions = "Test Instructions";




        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OverseasDeliveryPropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.OverseasDelivery = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OverseasDelivery, TestData);
        }

        [TestMethod]
        public void DateOrderedPropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateOrdered = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void OrderDescriptionPropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "A hat is cool";
            //assign the data to the property
            AnOrder.OrderDescription = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderDescription, TestData);
        }

        [TestMethod]
        public void OrderPricePropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Double TestData = 1.55;
            //assign the data to the property
            AnOrder.OrderPrice = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderPrice, TestData);
        }

        [TestMethod]
        public void ReturnAddressPropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Return Address";
            //assign the data to the property
            AnOrder.ReturnAddress = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.ReturnAddress, TestData);
        }

        [TestMethod]
        public void DeliveryInstructionsPropertyOK()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Delivery Instructions";
            //assign the data to the property
            AnOrder.DeliveryInstructions = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.DeliveryInstructions, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDescriptionFound()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order description
            if (AnOrder.OrderDescription != "TestHat")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateOrderedFound()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the date ordered
            if (AnOrder.DateOrdered != Convert.ToDateTime("10/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderPriceFound()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order price
            if (AnOrder.OrderPrice != Convert.ToDouble("5.55"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOverseasDeliveryFound()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the overseas delivery
            if (AnOrder.OverseasDelivery != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReturnAddressFound()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the return address
            if (AnOrder.ReturnAddress != "DMU")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryInstructionsFound()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the delivery instructions
            if (AnOrder.DeliveryInstructions != "At Door")
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDescription = "";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDescription = "a";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription,DeliveryInstructions, ReturnAddress, DateOrdered , OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDescriptionExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(500, 'a');
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void DeliveryInstructionsMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DeliveryInstructions = "";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryInstructionsMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string DeliveryInstructions = "a";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryInstructionsMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DeliveryInstructions = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryInstructionsMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DeliveryInstructions = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryInstructionsMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DeliveryInstructions = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryInstructionsMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DeliveryInstructions = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryInstructionsExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DeliveryInstructions = "";
            DeliveryInstructions = DeliveryInstructions.PadRight(500, 'a');
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReturnAddressMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ReturnAddress = "";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ReturnAddressMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ReturnAddress = "a";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReturnAddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string ReturnAddress = "aa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReturnAddressMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ReturnAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReturnAddressMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ReturnAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReturnAddressMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ReturnAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReturnAddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ReturnAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReturnAddressExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ReturnAddress = "";
            ReturnAddress = ReturnAddress.PadRight(500, 'a');
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMin()
        {
            //create an instancee of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is in less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOrderedMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateOrdered = TestDate.ToString();
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOrdered = TestDate.ToString();
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOrdered = TestDate.ToString();
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(100);
            string DateOrdered = TestDate.ToString();
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store error message
            String Error = "";
            //set the DateOrdered to a non date value
            string DateOrdered = "This is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double Price = 0;
            string OrderPrice = Price.ToString();
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double Price = 0.01;
            string OrderPrice = Price.ToString();
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double Price = 1.00;
            string OrderPrice = Price.ToString();
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderPrice = "This is not a price!";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }

    }
}
