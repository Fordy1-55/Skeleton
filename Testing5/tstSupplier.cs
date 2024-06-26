﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Mail;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        string SupplierName = "Jack";
        string SupplierContactEmail = "sam@simple.com";
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
            string SupplierName = ""; //This should trigger an error
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
        public void SupplierNameMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            SupplierName = SupplierName.PadRight(25, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(49, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(50, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(51, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtrememax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]    
        public void SupplierContactPhoneMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactPhone = "1234567891";
            Error = ASupplier.Valid(SupplierContactPhone, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierContactPhoneMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactPhone = "12345678910";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactPhoneMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactPhone = "123456789101";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactPhoneExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactPhone = "";
            SupplierContactPhone = SupplierContactPhone.PadRight(500, '1');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierCityMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierCity = "";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierCityMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierCity = "";
            SupplierCity = SupplierCity.PadRight(49, '1');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierCityMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierCity = "a";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierCityMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierCity = "";
            SupplierCity = SupplierCity.PadRight(50, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierCityMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierCity = "aa";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierCityMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierCity = "";
            SupplierCity = SupplierCity.PadRight(51, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddDateExtremeMin() 
        { 
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date.AddYears(-100);
            string SupplierAddDate = testDate.ToString();
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddDateMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            String TestDate = "31/12/2022";
            string SupplierAddDate = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddDateMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string SupplierAddDate = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddDateMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddDays(1);
            string SupplierAddDate = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddDateExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(100);
            string SupplierAddDate = TestDate.ToString();
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddDateInvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierAddDate = "This is, in fact, not a Date!";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactEmailvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactEmail = "Geoff@gmail.com";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierContactEmailInvalid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactEmail = "JhonnJonesgmail.com";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactEmailMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactEmail = "";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactEmailMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactEmail = "a@simple.com";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactEmailMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactEmail = "aa@simple.com";
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactEmailMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactEmail = "@simple.com";
            SupplierContactEmail = SupplierContactEmail.PadLeft(49, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactEmailMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactEmail = "@simple.com";
            SupplierContactEmail = SupplierContactEmail.PadLeft(50, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactEmailMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactEmail = "@simple.com";
            SupplierContactEmail = SupplierContactEmail.PadLeft(51, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactEmailMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactEmail = "@simple.com";
            SupplierContactEmail = SupplierContactEmail.PadLeft(25, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactEmailExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            string Error = "";
            string SupplierContactEmail = "@simple.com";
            SupplierContactEmail = SupplierContactEmail.PadLeft(500, 'a');
            Error = ASupplier.Valid(SupplierName, SupplierContactEmail, SupplierContactPhone, SupplierCity, SupplierAddDate);
            Assert.AreNotEqual(Error, "");
        }
    }   
}
