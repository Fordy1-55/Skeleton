using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of he class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exist
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK() 
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign the property
            //in the case the new data needs to be a list of data
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ProductAvailable = true;  
            TestItem.ProductId = 1;
            TestItem.ProductDate = DateTime.Now;
            TestItem.ProductPrice = 6.25M;
            TestItem.ProductDescription = "Test Description";
            TestItem.ProductTitle = "Test Title";
            TestItem.ProductColour = "Test Colour";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);           
        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.ProductAvailable = true;
            TestStock.ProductId = 1;
            TestStock.ProductDate = DateTime.Now;
            TestStock.ProductPrice = 6.25M;
            TestStock.ProductDescription = "Test Description";
            TestStock.ProductTitle = "Test Title";
            TestStock.ProductColour = "Test Colour";
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);

        }

        [TestMethod]
        public void StockListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign the property
            //in the case the new data needs to be a list of data
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ProductAvailable = true;
            TestItem.ProductId = 1;
            TestItem.ProductDate = DateTime.Now;
            TestItem.ProductPrice = 6.25M;
            TestItem.ProductDescription = "Test Description";
            TestItem.ProductTitle = "Test Title";
            TestItem.ProductColour = "Test Colour";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockCount, TestList.Count);
        }

    }
}
