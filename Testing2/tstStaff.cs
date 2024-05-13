using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



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
            Staff.StartDateProperty = TestData;
            //Check if both values match
            Assert.AreEqual(Staff.StartDateProperty, TestData);
        }

        [TestMethod]

        public void RolePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "A Role";
            Staff.RoleProperty = TestData;
            Assert.AreEqual(Staff.RoleProperty, TestData);
        }

        [TestMethod]

        public void ShiftTypePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "A type of shift";
            Staff.ShiftTypeProperty = TestData;
            Assert.AreEqual(Staff.ShiftTypeProperty, TestData);

        }

        [TestMethod]

        public void StaffIDPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            int TestData = 1;
            Staff.StaffIDProperty = TestData;
            Assert.AreEqual(Staff.StaffIDProperty, TestData);
        }

        [TestMethod] 

        public void NamePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "Staff Name";
            Staff.NameProperty = TestData;
            Assert.AreEqual(Staff.NameProperty, TestData);
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
            Int32 StaffID = 4;
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
            Int32 StaffIDProperty = 7;
            //Invoke the method
            Found = Staff.Find(StaffIDProperty);
            //Check StaffID 
            if (Staff.StaffIDProperty != 7)
            {
                OK = false;
            }
            //Test to see result is correct
            Assert.IsTrue(OK);


        }


    }
}
