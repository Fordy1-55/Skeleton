using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;



namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
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











    }
}
