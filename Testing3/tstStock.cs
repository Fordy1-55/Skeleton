using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {

        /*******INSTANCE OF THE CLASS TEST********/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instace of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exist
            Assert.IsNotNull(AnStock);
        }
        /******************PROPERTY OK TEST******************/

        [TestMethod]
        public void ProductAvailablePropertyOK()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //aasign the data to the property
            AnStock.ProductAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductAvailable, TestData);
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
            Double TestData = 6.25;
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

        /*********************FIND METHOD TEST*******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Productid = 1;
            //invoke the method
            Found = AnStock.Find(Productid);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /*********************PROPERTY DATA TEST*******************/

        [TestMethod]

        public void TestProductIdFound()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the address id
            if (AnStock.ProductId != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        public void TestDateAddedFound()
        {
            //create am instance of the new class we want to create
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable torecord if the data is OK )assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the DateAdded property
            if (AnStock.DateAdded != Convert.ToDateTime("04/05/2024"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the street property
            if (AnStock.ProductDescription != "Beanie is a brimless, soft, round, stretchy hat that fits snugly on your head – and can be dragged down to your ears. It’s a flexible cap that hugs your head and ears and saves them from freezing in the cold weather")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductTitleFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the street property
            if (AnStock.ProductTitle != "A Beanie")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductColourFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the street property
            if (AnStock.ProductColour != "Black, Blue, Red, Gray, White, Green, Orange, Brown, Purple")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the street property
            if (AnStock.ProductAvailable != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestProductPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AnStock.Find(ProductId);
            //check the street property
            if (AnStock.ProductPrice != 6.25)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}