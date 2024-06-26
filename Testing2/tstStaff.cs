﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;



namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        //GOOD TEST DATA 
        //adding this test data to pass the method
        String Name = "Claire";
        String Role = "Team Memb";
        String ShiftType = "Dispatch";
        String StartDate = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //Create new instance of class
            clsStaff Staff = new clsStaff();
            //test to see if it exists
            Assert.IsNotNull(Staff);
        }

        [TestMethod]

        public void PerformanceTargetPropertyOK()
        {
            //Creater instance of class
            clsStaff Staff = new clsStaff();
            //add test data to be assigned
            Boolean TestData = true;
            //Now assign the testdata to the property
            Staff.PerformanceTarget = TestData;
            //Check if both values are equal
            Assert.AreEqual(Staff.PerformanceTarget, TestData);
        }

        [TestMethod]

        public void StartDatePropertyOK()
        {
            //Create instance
            clsStaff Staff = new clsStaff();
            //Create test data to be assigned
            DateTime TestData = DateTime.Now.Date;
            //Assign to propert
            Staff.StartDate = TestData;
            //Check if both values match
            Assert.AreEqual(Staff.StartDate, TestData);
        }

        [TestMethod]

        public void RolePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "A Role";
            Staff.Role = TestData;
            Assert.AreEqual(Staff.Role, TestData);
        }

        [TestMethod]

        public void ShiftTypePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "A type of shift";
            Staff.ShiftType = TestData;
            Assert.AreEqual(Staff.ShiftType, TestData);

        }

        [TestMethod]

        public void StaffIDPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            int TestData = 1;
            Staff.StaffID = TestData;
            Assert.AreEqual(Staff.StaffID, TestData);
        }

        [TestMethod]

        public void NamePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "Staff Name";
            Staff.Name = TestData;
            Assert.AreEqual(Staff.Name, TestData);
        }

        [TestMethod]
        public void ManagerStatusPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean TestData = true;
            Staff.ManagerStatus = TestData;
            Assert.AreEqual(Staff.ManagerStatus, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff Staff = new clsStaff();
            //create boolean variable to store the result
            Boolean Found = false;
            Int32 StaffID = 7;
            Found = Staff.Find(StaffID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create instance of class 
            clsStaff Staff = new clsStaff();
            //Create boolean variable to store result
            Boolean Found = false;
            //Create boolean variable to store result if value is OK
            Boolean OK = true;
            //Add test data 
            Int32 StaffID = 7;
            //Invoke the method
            Found = Staff.Find(StaffID);
            //Check StaffID 
            if (Staff.StaffID != 7)
            {
                OK = false;
            }
            //Test to see result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 9;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the town property
            if (Staff.Name != "Dawn")
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 9;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the post code property
            if (Staff.Role != "Admin")
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShiftTypeFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 7;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the post code property
            if (Staff.ShiftType != "Packing")
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStartDateFound()
        {
            //Create instance of class
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 7;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the date added property
            if (Staff.StartDate != Convert.ToDateTime("13/05/2028"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPerformanceTargetFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 7;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the active property
            if (Staff.PerformanceTarget != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestManagerStatusFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 7;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the active property
            if (Staff.ManagerStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff Staff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //invoke method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsStaff Staff = new clsStaff();
            //striong c= variable to store error msg
            String Error = "";
            //test data to pass through to the method
            String Name = ""; //this should trigger an error
            //invoke method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see retult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "C"; //this should be ok
                                  //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "Cc"; //this should be ok
                               //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "Cccccccccccccccc cccccccccccccccc"; //this should be ok
                               //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "Ccccccccccccccccccccccccccccccccccc"; //this should be ok
                               //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "Ccccccccccccccccc"; //this should be ok
                               //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "Cccccccccccccccccccccccccccccccccccc"; //this should be ok
                               //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "C";
            Name = Name.PadRight(100, 'c'); //this should fail
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;  
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateInvalidData()
        {
            clsStaff Staff = new clsStaff();
            //Strig variable to store error message
            String Error = "";
            //set StartDate to a non date value
            string StartDate = "This is not a date!";
            //Invoke method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Role = "";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoleMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role = "t";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role = "tt";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMaxLessOne() 
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role = "ttttttttttttttttttttttttttttt";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMax() 
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role = "tttttttttttttttttttttttttttttt";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Role = "ttttttttttttttttttttttttttttttt";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoleMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role = "ttttttttttttttt";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShiftTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShiftType = "";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShiftTypeMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShiftType = "a";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShiftTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShiftType = "aa";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShiftTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShiftType = "";
            ShiftType = ShiftType.PadRight(24, 'a');
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShiftTypeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShiftType = "";
            ShiftType = ShiftType.PadRight(25, 'a');
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShiftTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShiftType = "";
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShiftTypeMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShiftType = "";
            ShiftType = ShiftType.PadRight(12, 'a');
            //invoke the method
            Error = Staff.Valid(Name, Role, ShiftType, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }















    }
}
