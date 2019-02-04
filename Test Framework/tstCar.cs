using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCar
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class clsCar
            clsCar ACar = new clsCar();
            //check to see that the class is not null
            Assert.IsNotNull(ACar);
        }
    }
}
