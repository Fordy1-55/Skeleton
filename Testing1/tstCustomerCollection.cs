using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instnace of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //CREATE instance of class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to be assigned
            //the test data must be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add new item to list
            //create an item of testdata
            clsCustomer TestItem = new clsCustomer();
            //set properties
            TestItem.Subscription = true;
            TestItem.CustomerName = "Sab";
            TestItem.CustomerID = 6;
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerEmail = "sab.smith@hotmail.com";
            TestItem.CustomerAddress = "18 Main Street";
            TestItem.CustomerTelephoneNo = "0768349761";
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllCustomers.CustomerList = TestList;
            //test to see both values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }



        [TestMethod]
        public void ListAndCountOK()
        {
            //CREATE instance of class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to be assigned to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add item to the list
            // create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set properties
            TestItem.Subscription = true;
            TestItem.CustomerName = "Sab";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerEmail = "sab.smith@hotmail.com";
            TestItem.CustomerAddress = "18 Main Street";
            TestItem.CustomerTelephoneNo = "0768349761";
            //add item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllCustomers.CustomerList = TestList;
            //test to see both values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //CREATE instance of class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to be assigned to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set properties
            TestCustomer.Subscription = true;
            TestCustomer.CustomerName = "Sab";
            TestCustomer.CustomerID = 6;
            TestCustomer.DateOfBirth = DateTime.Now;
            TestCustomer.CustomerEmail = "sab.smith@hotmail.com";
            TestCustomer.CustomerAddress = "18 Main Street";
            TestCustomer.CustomerTelephoneNo = "0768349761";
            //assign data to property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see both values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item of testdata
            clsCustomer TestItem = new clsCustomer();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Sabrina";
            TestItem.CustomerEmail = "Sabrina@hotmail.com";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.CustomerAddress = "90 Girraffe Lane";
            TestItem.CustomerTelephoneNo = "0784790358";
            TestItem.Subscription = true;
            //set thisCustomer to testdata
            AllCustomers.ThisCustomer = TestItem;
            //add record
            PrimaryKey = AllCustomers.Add();
            //set primary key of the testdata
            TestItem.CustomerID = PrimaryKey;
            //find record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that both values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }



    }
}
