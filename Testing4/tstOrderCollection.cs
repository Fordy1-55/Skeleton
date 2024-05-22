using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
    
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an Item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OverseasDelivery = true;
            TestItem.OrderId = 7;
            TestItem.OrderPrice = 10;
            TestItem.OrderDescription = "Test Description";
            TestItem.DateOrdered = DateTime.Now;
            TestItem.DeliveryInstructions = "Test Instructions";
            TestItem.ReturnAddress = "Test Address";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OverseasDelivery = true;
            TestOrder.OrderId = 8;
            TestOrder.OrderPrice = 10;
            TestOrder.OrderDescription = "Test Description";
            TestOrder.DateOrdered = DateTime.Now;
            TestOrder.DeliveryInstructions = "Test Instructions";
            TestOrder.ReturnAddress = "Test Address";
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some tests data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OverseasDelivery = true;
            TestItem.OrderId = 9;
            TestItem.OrderPrice = 10;
            TestItem.OrderDescription = "Test Description";
            TestItem.DateOrdered = DateTime.Now;
            TestItem.DeliveryInstructions = "Test Instructions";
            TestItem.ReturnAddress = "Test Address";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see if the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OverseasDelivery = true;
            TestItem.OrderPrice = 13;
            TestItem.OrderDescription = "Test Description";
            TestItem.DateOrdered = DateTime.Now;
            TestItem.DeliveryInstructions = "Test Instructions";
            TestItem.ReturnAddress = "Test Address";
            TestItem.OrderId = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OverseasDelivery = true;
            TestItem.OrderPrice = 15;
            TestItem.OrderDescription = "Test Description";
            TestItem.DateOrdered = DateTime.Now;
            TestItem.DeliveryInstructions = "Test Instructions";
            TestItem.ReturnAddress = "Test Address";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            //Modify the test record
            TestItem.OverseasDelivery = false;
            TestItem.OrderPrice = 20;
            TestItem.OrderDescription = "Modified Description";
            TestItem.DateOrdered = DateTime.Now;
            TestItem.DeliveryInstructions = "Modified Instructions";
            TestItem.ReturnAddress = "Modified Address";
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OverseasDelivery = true;
            TestItem.OrderPrice = 15;
            TestItem.OrderDescription = "Test Description";
            TestItem.DateOrdered = DateTime.Now;
            TestItem.DeliveryInstructions = "Test Instructions";
            TestItem.ReturnAddress = "Test Address";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found#
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void ReportByReturnAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByReturnAddress("");
            //test to see that the two values are equal
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        public void ReportByReturnAddressNoneFound()
        {
            //create a instance of the class we want to create
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a Return Address that doesnt exist
            FilteredOrders.ReportByReturnAddress("xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);

        }

        public void ReportByReturnAddressTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredAddresses = new clsOrderCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a address that doesnt exist
            FilteredAddresses.ReportByReturnAddress("yyyyy");
            //check that the correct number of records are found
            if (FilteredAddresses.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredAddresses.OrderList[0].OrderId != 69)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredAddresses.OrderList[1].OrderId != 70)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}

