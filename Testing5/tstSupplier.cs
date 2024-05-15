using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        string SupplierName = "Jack";
        string SupplierContactEmail = "Jack@Jmail.com";
        string SupplierContactPhone = "73579401735";
        string SupplierCity = "Leicester";
        string SupplierAddDate = DateTime.Now.ToShortDateString();
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
            Int32 SupplierID = 6;
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
            Int32 SupplierID = 6;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierID != 6)
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
            Int32 SupplierID = 6;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierAddDate != Convert.ToDateTime("13/05/2024"))
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
            Int32 SupplierID = 6;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierName != "Adidas")
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
            Int32 SupplierID = 6;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierContactEmail != "Adidas@Adidas.com")
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
            Int32 SupplierID = 6;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierContactPhone != "07854322345")
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
            Int32 SupplierID = 6;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.SupplierCity != "Leicester")
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
            Int32 SupplierID = 6;
            Found = ASupplier.Find(SupplierID);
            if (ASupplier.Availability != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = ""; //This should trigger an error
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "a";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne() 
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "aa";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            SupplierName = SupplierName.PadRight(49, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            SupplierName.PadRight(50, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            SupplierName.PadRight(51, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtrememax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            SupplierName.PadRight(500, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]    
        public void SupplierContactPhoneMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            SupplierContactPhone = "1234567891";
            Error = ASupplier.Valid(SupplierContactPhone, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierContactPhoneMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            SupplierContactPhone = "12345678910";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactPhoneMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            SupplierContactPhone = "123456789101";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactPhoneExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            SupplierContactPhone.PadRight(500, '1');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");

        }





    }   
}
