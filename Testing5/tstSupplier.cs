using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
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
    }
}
