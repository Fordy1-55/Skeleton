using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //CREATE instance of class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to be assigned
            //the test data must be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add new item to list
            //create an item of testdata
            clsStaff TestItem = new clsStaff();
            //set properties
            TestItem.StaffID = 1;
            TestItem.Name = "Test";
            TestItem.Role = "Team Memb";
            TestItem.StartDate = DateTime.Now;
            TestItem.ShiftType = "Dispatch";
            TestItem.PerformanceTarget = true;
            TestItem.ManagerStatus = true;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllStaff.StaffList = TestList;
            //test to see both values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create instance
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //create some test data to assign
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllStaff.Count = SomeCount;
        //    //test to see the values are the same
        //    Assert.AreEqual(AllStaff.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //Create instance of class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create testdata to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties to the test object
            TestStaff.StaffID = 1;
            TestStaff.Name = "Test";
            TestStaff.Role = "Team Memb";
            TestStaff.StartDate = DateTime.Now;
            TestStaff.ShiftType = "Dispatch";
            TestStaff.PerformanceTarget = true;
            TestStaff.ManagerStatus = true;
            //assign data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //CREATE instance of class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to be assigned
            //the test data must be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add new item to list
            //create an item of testdata
            clsStaff TestItem = new clsStaff();
            //set properties
            TestItem.StaffID = 1;
            TestItem.Name = "Test";
            TestItem.Role = "Team Memb";
            TestItem.StartDate = DateTime.Now;
            TestItem.ShiftType = "Dispatch";
            TestItem.PerformanceTarget = true;
            TestItem.ManagerStatus = true;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllStaff.StaffList = TestList;
            //test to see both values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create item of testdata
            clsStaff TestItem = new clsStaff();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.StaffID = 1;
            TestItem.Name = "Test";
            TestItem.Role = "Team Memb";
            TestItem.StartDate = DateTime.Now;
            TestItem.ShiftType = "Dispatch";
            TestItem.PerformanceTarget = true;
            TestItem.ManagerStatus = true;
            //set thisStaff to testdata
            AllStaff.ThisStaff = TestItem;
            //add record
            PrimaryKey = AllStaff.Add();
            //set primary key of the testdata
            TestItem.StaffID = PrimaryKey;
            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that both values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

  
    }
}
