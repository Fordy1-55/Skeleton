using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK ()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer ();
            //test to see if it exists
            Assert.IsNotNull (AnCustomer);
        }
    }
}
