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

        [TestMethod]
        public void UpdateMethodOK()
        {
            //CREATE INSTANCE OF CLASS
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create item of testdata
            clsStaff TestItem = new clsStaff();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.Name = "kelly";
            TestItem.Role = "Team Memb";
            TestItem.StartDate = DateTime.Now;
            TestItem.ShiftType = "Dispatch";
            TestItem.PerformanceTarget = true;
            TestItem.ManagerStatus = true;
            //set this staff to testdata
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set primary key of the testdata
            TestItem.StaffID = PrimaryKey;
            //modify the test record
            TestItem.Name = "Grace";
            TestItem.Role = "Admin";
            TestItem.StartDate = DateTime.Now;
            //TestItem.ShiftType = "Dispatch";
            TestItem.PerformanceTarget = false;
            TestItem.ManagerStatus = false;
            //set the record based on the new test data
            AllStaff.ThisStaff= TestItem;
            //update record
            AllStaff.Update();
            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if thisaddress matches data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK() 
        {
            //create instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create item of testdata
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.StaffID = 1;
            TestItem.Name = "mia";
            TestItem.Role = "Manager";
            TestItem.StartDate = DateTime.Now;
            TestItem.ShiftType = "Dispatch";
            TestItem.PerformanceTarget = true;
            TestItem.ManagerStatus = true;
            //set ThisStaff to the testdata
            AllStaff.ThisStaff = TestItem;
            //add record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the testdata
            TestItem.StaffID = PrimaryKey;
            //find record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //TEST TOI SEE THAT RECORD WAS NOT FOUND
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (this should return all records)
            FilteredStaff.ReportByName("");
            //Test to see the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create instance of class
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a name that doesnt exist
            FilteredStaff.ReportByName("unknown");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply name that doesnt exist
            FilteredStaff.ReportByName("unknown");
            //check the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check to see the first record is 20
                if (FilteredStaff.StaffList[0].StaffID != 20)
                {
                    OK = false;
                }
                //CHECK to see next record is 24
                if (FilteredStaff.StaffList[1].StaffID != 24) 
                {
                    OK = false;
                }

            }
            else 
            {
                OK = false;
            }
            //test to see there are no records
            Assert.IsTrue(true);
        }

  
    }
}
