using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instace of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exist
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //aasign the data to the property
            AnStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK() 
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //aasign the data to the property
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }

        [TestMethod]
        public void ProductIdPropertyOK() 
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //aasign the data to the property
            AnStock.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductId, TestData);
        }

        [TestMethod]
        public void ProductPricePropertyOK()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Double TestData = 5.66;
            //aasign the data to the property
            AnStock.ProductPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductPrice, TestData);
        }

        [TestMethod]
        public void ProductTitlePropertyOK()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "A Beanie";
            //aasign the data to the property
            AnStock.ProductTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductTitle, TestData);
        }

        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Beanie is a brimless, soft, round, stretchy hat that fits snugly on your head – and can be dragged down to your ears. It’s a flexible cap that hugs your head and ears and saves them from freezing in the cold weather";
            //aasign the data to the property
            AnStock.ProductDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductDescription, TestData);
        }

        [TestMethod]
        public void ProductKeyWordPropertyOK()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Beanie, Hat, Cap";
            //aasign the data to the property
            AnStock.ProductKeyWord = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductKeyWord, TestData);
        }

        [TestMethod]
        public void ProductColourPropertyOK()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Black, Blue, Red, Gray, White, Green, Orange, Brown, Purple";
            //aasign the data to the property
            AnStock.ProductColour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductColour, TestData);
        }

        [TestMethod]
        public void ProductImagePropertyOK()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "A Picture";
            //aasign the data to the property
            AnStock.ProductImage = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductImage, TestData);
        }

    }
}
