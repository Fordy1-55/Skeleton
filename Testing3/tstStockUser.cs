using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDpropertyOK()
        {
            //craete an instance3 of the class you want to craete
            clsStockUser AnUser = new clsStockUser();
            //create some test data to asign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two value sare the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamepropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "Aaron";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordpropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "password321";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropeertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "Stock";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create a boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Aaron";
            string Password = "password321";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNameFound()
        {
            //creae an instance of the class we want to craete
            clsStockUser AnUser = new clsStockUser();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Aaron";
            string Password = "password321";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id prperty
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
