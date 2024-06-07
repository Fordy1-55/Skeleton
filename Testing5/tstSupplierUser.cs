using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing5
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierUser AUser = new clsSupplierUser();
            Assert.IsNotNull(AUser);  
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsSupplierUser AUser = new clsSupplierUser();
            Int32 TestData = 1;
            AUser.UserID = TestData;
            Assert.AreEqual(AUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsSupplierUser AUser = new clsSupplierUser();
            string TestData = "Caleb";
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsSupplierUser AUser = new clsSupplierUser();
            string TestData = "password123";
            AUser.Password = TestData;
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsSupplierUser AUser = new clsSupplierUser();
            string TestData = "Supplier";
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplierUser AUser = new clsSupplierUser();
            Boolean Found = false;
            string Username = "Caleb";
            string Password = "Password123";
            Found = AUser.FindUser(Username, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsSupplierUser ASupplier = new clsSupplierUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Caleb";
            string Password = "Password123";
            Found = ASupplier.FindUser(UserName, Password);

            if (ASupplier.UserName != UserName && ASupplier.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
