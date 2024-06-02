using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class we want to create
            clsStaffUser User = new clsStaffUser();
            //test to see it exists
            Assert.IsNotNull(User);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create instance of class
            clsStaffUser user = new clsStaffUser();
            //assign test data to the property
            Int32 TestData = 1;
            //asssign data to the property
            user.UserID = TestData;
            //test to see both values are the same
            Assert.AreEqual(user.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser User = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Holly";
            //assign the data to the property
            User.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(User.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK() 
        {
            clsStaffUser User = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Password123";
            //assign the data to the property
            User.Password = TestData;
            //test to see both values are the same
            Assert.AreEqual(User.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser User = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Staff Book";
            //assign the data to the property
            User.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(User.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsStaffUser User = new clsStaffUser();
            //create boolean variable to store results of the validation
            Boolean Found = false;
            //create testdata to use with the method
            string UserName = "Holly";
            string Password = "Password123";
            //invoke the method
            Found = User.FindUser(UserName, Password);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create instance
            clsStaffUser User = new clsStaffUser();
            //create boolean value to store result
            Boolean Found = false;
            //create boolean variable to record if the data is OK
            Boolean OK = true;
            //create testdata to use with the method
            string UserName = "Holly";
            string Password = "Password123";
            //invoke the method
            Found = User.FindUser(UserName, Password);
            //check userID property
            if (User.UserName != UserName && User.Password != Password)
            {
                OK = false;
            }
            //test to seee result is correct
            Assert.IsTrue(OK);

        }
        

    }   
}
