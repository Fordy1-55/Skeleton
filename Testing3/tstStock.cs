using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instace of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exist
            Assert.IsNotNull(AnStock);

        }
    } 
}
