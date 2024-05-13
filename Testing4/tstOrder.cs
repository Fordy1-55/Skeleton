using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;

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
        public void OrderDescriptionMinLessOne()

        {
            //create a instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderDescription = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDescriptionMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDescription = "a";
            Error = AnOrder.Valid(OrderDescription, DeliveryInstructions, ReturnAddress, DateOrdered, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderDescription = "aa";
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

    }
}
