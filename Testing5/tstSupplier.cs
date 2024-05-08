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
            ASupplier.Active = TestData;
            Assert.AreEqual(ASupplier.Active, TestData);
        }

        [TestMethod]
        public void DateAddedSupplierOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.DateAdded = TestData;
            Assert.AreEqual(ASupplier.DateAdded, TestData);
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
            ASupplier.Name = TestData;
            Assert.AreEqual(ASupplier.Name, TestData);
        }

        [TestMethod]
        public void ContactEmailSupplierOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "he got an email";
            ASupplier.Email = TestData;
            Assert.AreEqual(ASupplier.Email, TestData);
        }

        [TestMethod]
        public void ContactPhoneSupplierOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "he got a phone";
            ASupplier.Phone = TestData;
            Assert.AreEqual(ASupplier.Phone, TestData);
        }

        [TestMethod]
        public void CitySupplierOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "city";
            ASupplier.City = TestData;
            Assert.AreEqual(ASupplier.City, TestData);
        }
    }
}
