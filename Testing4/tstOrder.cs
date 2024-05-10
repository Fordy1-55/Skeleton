using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
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
            string TestData = "Delivery Instructions";
            AnOrder.DeliveryInstructions = TestData;
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
            Int32 OrderId = 25;
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
            Int32 OrderId = 25;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 25)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDescriptionFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderDescription = 25;
            Found = AnOrder.Find(OrderDescription);
            if (AnOrder.OrderDescription != "Test Description")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateOrderedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 25;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.DateOrdered != Convert.ToDateTime("19/10/2003"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 25;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderPrice != Convert.ToDouble("1.99"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OverseasDeliveryFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 25;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OverseasDelivery != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ReturnAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 25;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ReturnAddress != "Test Address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
