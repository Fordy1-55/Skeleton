﻿using ClassLibrary;
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
            Staff.PerformanceTargetProperty = TestData;
            //Check if both values are equal
            Assert.AreEqual(Staff.PerformanceTargetProperty, TestData); 
        }

        [TestMethod]

        public void StartDatePropertyOK()
        {
            //Create instance
            clsStaff Staff = new clsStaff();
            //Create test data to be assigned
            DateTime TestData = DateTime.Now.Date;
            //Assign to propert
            clsStaff.StartDateProperty = TestData;
            //Check if both values match
            Assert.AreEqual(clsStaff.StartDateProperty, TestData);
        }

        [TestMethod]

        public void SpecialtyPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "A Specialty";
            clsStaff.SpecialtyProperty = TestData;
            Assert.AreEqual(clsStaff.SpecialtyProperty, TestData);
        }

        [TestMethod]

        public void ShiftTypePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "A type of shift";
            clsStaff.ShiftTypeProperty = TestData;
            Assert.AreEqual(clsStaff.ShiftTypeProperty, TestData);

        }

        [TestMethod]

        public void StaffIDPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            int TestData = 1;
            clsStaff.StaffIDProperty = TestData;
            Assert.AreEqual(clsStaff.StaffIDProperty, TestData);
        }

        [TestMethod] 

        public void NamePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "Staff Name";
            clsStaff.NameProperty = TestData;
            Assert.AreEqual(clsStaff.NameProperty, TestData);
        }

        [TestMethod]
        public void ManagerStatusPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean TestData = true;
            Staff.ManagerStatusProperty = TestData;
            Assert.AreEqual(Staff.ManagerStatusProperty, TestData);



        }

    }
}
