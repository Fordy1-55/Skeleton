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
    }
}
