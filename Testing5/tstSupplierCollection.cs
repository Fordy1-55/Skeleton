using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //Create some test data, in this case a list, to assign to the property
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.Availability = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "foo";
            TestItem.SupplierContactEmail = "sam@simple.com";
            TestItem.SupplierContactPhone = "07986543254";
            TestItem.SupplierCity = "Leicester";
            TestItem.SupplierAddDate = DateTime.Now;  
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.Availability = true;
            TestSupplier.SupplierID = 1;
            TestSupplier.SupplierName = "foo";
            TestSupplier.SupplierCity = "Leicester";
            TestSupplier.SupplierAddDate = DateTime.Now;
            TestSupplier.SupplierContactPhone = "07986543213";
            TestSupplier.SupplierContactEmail = "sam@Simple.com";
            AllSuppliers.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.Availability = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "foo";
            TestItem.SupplierContactEmail = "sam@simple.com";
            TestItem.SupplierContactPhone = "07986543254";
            TestItem.SupplierCity = "Leicester";
            TestItem.SupplierAddDate = DateTime.Now;
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierName = "foo";
            TestItem.SupplierContactEmail = "someone@something.com";
            TestItem.Availability = true;
            TestItem.SupplierAddDate = DateTime.Now;
            TestItem.SupplierContactPhone = "07123456789";
            TestItem.SupplierCity = "Leicester";
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierName = "foo";
            TestItem.SupplierContactEmail = "someone@something.com";
            TestItem.Availability = true;
            TestItem.SupplierAddDate = DateTime.Now;
            TestItem.SupplierContactPhone = "07123456789";
            TestItem.SupplierCity = "Leicester";
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;

            TestItem.SupplierName = "Wah";
            TestItem.SupplierContactEmail = "somewhere@somehow.com";
            TestItem.Availability = true;
            TestItem.SupplierAddDate = DateTime.Now;
            TestItem.SupplierContactPhone = "07126543789";
            TestItem.SupplierCity = "Africa";
            AllSuppliers.ThisSupplier = TestItem;
            AllSuppliers.Update();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierName = "foo";
            TestItem.SupplierContactEmail = "someone@something.com";
            TestItem.Availability = true;
            TestItem.SupplierAddDate = DateTime.Now;
            TestItem.SupplierContactPhone = "07123456789";
            TestItem.SupplierCity = "Leicester";

            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            AllSuppliers.Delete();
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
    }
}
