﻿using ClassLibrary;
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
            TestItem.ProductId = 6;
            TestItem.ProductDate = DateTime.Now;
            TestItem.ProductPrice = 10;
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
            TestStock.ProductId = 7;
            TestStock.ProductDate = DateTime.Now;
            TestStock.ProductPrice = 10;
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
            TestItem.ProductId = 8;
            TestItem.ProductDate = DateTime.Now;
            TestItem.ProductPrice = 10;
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

        [TestMethod]
        public void StockAddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductAvailable = true;
            TestItem.ProductId = 1;
            TestItem.ProductDate = DateTime.Now;
            TestItem.ProductPrice = 12;
            TestItem.ProductDescription = "Test Description";
            TestItem.ProductTitle = "Test Title";
            TestItem.ProductColour = "Test Colour";
            //set This stock to the text data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void StockUpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign the property
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductAvailable = true;
            TestItem.ProductDate = DateTime.Now;
            TestItem.ProductPrice = 15;
            TestItem.ProductDescription = "Test Description";
            TestItem.ProductTitle = "Test Title";
            TestItem.ProductColour = "Test Colour";
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the recored
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //modify the test record
            TestItem.ProductAvailable = true;
            TestItem.ProductDate = DateTime.Now;
            TestItem.ProductPrice = 20;
            TestItem.ProductDescription = "Modified Description";
            TestItem.ProductTitle = "Modified Title";
            TestItem.ProductColour = "Modified Colour";
            //set the record based on  the new test data
            AllStocks.ThisStock = TestItem;
            //update the reocrd
            AllStocks.Update();
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(AllStocks.ThisStock, TestItem);

        }

        [TestMethod]
        public void StockDeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign the property
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductAvailable = true;
            TestItem.ProductDate = DateTime.Now;
            TestItem.ProductPrice = 15;
            TestItem.ProductDescription = "Test Description";
            TestItem.ProductTitle = "Test Titles";
            TestItem.ProductColour = "Test Colour";
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the recored
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //findthe record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now find the record 
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductTitleMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a blank string(that should return all records)
            FilteredStocks.ReportByProductTitle("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockCount, FilteredStocks.StockCount);
        }

        [TestMethod]
        public void ReportByProductTitleNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a code that doesn't exist
            FilteredStocks.ReportByProductTitle("xxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStocks.StockCount);
        }

        [TestMethod]
        public void ReportByProductTitleTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a proiduct title that doesnt exist
            FilteredStocks.ReportByProductTitle("yyyy yyyyy");
            //check to see that the number of records are found
            if (FilteredStocks.StockCount == 2)
            {
                //check to see thast the first record is 25
                if (FilteredStocks.StockList[0].ProductId != 120)
                {
                    OK = false;
                }
                //check to see that the first record is 26 
                if (FilteredStocks.StockList[1].ProductId != 121)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there is no data
            Assert.IsTrue(OK);
        }

    }
}
