using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass the method
        string ProductDescription = "Test Description";
        string ProductTitle = "Test Title";
        string ProductColour = "Test colour";
        string ProductDate = DateTime.Now.ToShortDateString();
        string ProductPrice = "6.25";

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
            AnStock.ProductDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductDate, TestData);
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
            Decimal TestData = 6.25M;
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
            string TestData = "Beanie is a brimless, soft, round, stretchy hat that fits snugly on your head – and can be dragged down to your ears. It’s a flexible cap that hugs your head and ears and saves them from freezing in the cold weather.                                  ";
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

        public void TestProoductDateFound()
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
            if (AnStock.ProductDate != Convert.ToDateTime("03/05/2024"))
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
            if (AnStock.ProductDescription != "Beanie is a brimless, soft, round, stretchy hat that fits snugly on your head – and can be dragged down to your ears. It’s a flexible cap that hugs your head and ears and saves them from freezing in the cold weather.                                  ")
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
            if (AnStock.ProductTitle != "Cuffless Beanie")
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
            if (AnStock.ProductColour != "Black")
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
            if (AnStock.ProductPrice != Convert.ToDecimal("6.25"))  
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        /************************** VALID METHOD ********************************/

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock1 = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStock1.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            //test to see that he result is correct
            Assert.AreEqual(Error, "");
        }

        /************************* Product Description ***********************************/

        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductDescription = "";
            Error = AnStock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductDescription = "a";
            Error = AnStock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductDescription = "aa";
            Error = AnStock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMaxLessOne()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(249, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMax()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(250, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMid()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(125, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionMaxPlussOne()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(251, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptionExtremeMax()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(500, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        /************************** Product Title***********************************/

        [TestMethod]
        public void ProductTitleMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductTitle = "";
            Error = AnStock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductTitle = "a";
            Error = AnStock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductTitle = "aa";
            Error = AnStock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleMaxLessOne()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductTitle = "";
            ProductTitle = ProductTitle.PadRight(49, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleMax()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductTitle = "";
            ProductTitle = ProductTitle.PadRight(50, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleMaxPlusOne()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductTitle = "";
            ProductTitle = ProductTitle.PadRight(51, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductTitleMid()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductTitle = "";
            ProductTitle = ProductTitle.PadRight(25, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        /*************************** Prdouct Colour **************************/


        [TestMethod]
        public void ProductColourMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductColour = "";
            Error = AnStock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductColourMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductColour = "a";
            Error = AnStock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductColourMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ProductColour = "aa";
            Error = AnStock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductColourMaxLessOne()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductColour = "";
            ProductColour = ProductColour.PadRight(49, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductColourMax()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductColour = "";
            ProductColour = ProductColour.PadRight(50, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductColourMaxPlusOne()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductColour = "";
            ProductColour = ProductColour.PadRight(51, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductColourMid()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductColour = "";
            ProductColour = ProductColour.PadRight(25, 'a');
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }
        /*************************** Product Date *********************************/

        [TestMethod]
        public void ProductDateExtremeMin()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string ProductDate = TestDate.ToString();
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDateMinLessOne()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string ProductDate = TestDate.ToString();
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDateMin()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string ProductDate = TestDate.ToString();
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDateMinPlusOne()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string ProductDate = TestDate.ToString();
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDateExtremeMax()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string ProductDate = TestDate.ToString();
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductDateInvalidData() 
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductDate = "this is not a date!";
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        /********************** Product Price *******************************/

        [TestMethod]
        public void ProductPriceExtremeMin()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            Decimal Price = 0M;
            string ProductPrice = Price.ToString();
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMin()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            Decimal Price = 0.01M;
            string ProductPrice = Price.ToString();
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMinPlusOne()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            Decimal Price = 1.00M;
            string ProductPrice = Price.ToString();
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceInvaliddata()
        {
            clsStock Anstock = new clsStock();
            String Error = "";
            string ProductPrice = "This is not a price!";
            Error = Anstock.Valid(ProductDescription, ProductTitle, ProductColour, ProductDate, ProductPrice);
            Assert.AreNotEqual(Error, "");
        }
    }
}