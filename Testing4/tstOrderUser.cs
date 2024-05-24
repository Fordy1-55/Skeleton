using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //createt an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Cameron";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "password123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Order";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create a boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Cameron";
            string Password = "password123";
            //invoke the method
            Found = AnUser.FindUser(UserName,Password);
            //test to see if the result is true
            Assert.IsTrue(Found); 
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Cameron";
            string Password = "password123";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
