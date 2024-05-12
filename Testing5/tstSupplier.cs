using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        /*******INSTANCE OF THE CLASS TEST*******/
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void AvailableSupplierOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean TestData = true;
            ASupplier.Availability = TestData;
            Assert.AreEqual(ASupplier.Availability, TestData);
        }

        [TestMethod]
        public void DateAddedSupplierOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.SupplierAddDate = TestData;
            Assert.AreEqual(ASupplier.SupplierAddDate, TestData);
        }

        [TestMethod]
        public void SupplierIDOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 1;
            ASupplier.SupplierID = TestData;
            Assert.AreEqual(ASupplier.SupplierID, TestData);
        }

        [TestMethod]
        public void NameSupplierOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "Hats";
            ASupplier.SupplierName = TestData;
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void ContactEmailSupplierOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "he got an email";
            ASupplier.SupplierContactEmail = TestData;
            Assert.AreEqual(ASupplier.SupplierContactEmail, TestData);
        }

        [TestMethod]
        public void ContactPhoneSupplierOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "he got a phone";
            ASupplier.SupplierContactPhone = TestData;
            Assert.AreEqual(ASupplier.SupplierContactPhone, TestData);
        }

        [TestMethod]
        public void CitySupplierOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "city";
            ASupplier.SupplierCity = TestData;
            Assert.AreEqual(ASupplier.SupplierCity, TestData);
        }

        /*******FIND METHOD TEST*******/

        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierID = 21;
            Found = ASupplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }

        /*******PROPERTY DATA TESTS*******/
        [TestMethod]
        public void TestSupplierIdFound() 
        { 
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]    
        public void TestDateaddedFound() 
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierAddDate != Convert.ToDateTime("12/05/24"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierName != "Test Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierEmailFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierContactEmail != "Test@Email.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierPhoneFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = ASupplier.Find(SupplierID);
            if(ASupplier.SupplierContactPhone != "07357960435")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TstSupplierCityFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = ASupplier.Find(SupplierID);
            if(ASupplier.SupplierCity != "Test City")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierAvailabilityFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = ASupplier.Find(SupplierID);
            if(ASupplier.Availability != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }   
}
