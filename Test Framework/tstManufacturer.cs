using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstManufacturer
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of our class clsManufacturer
            clsManufacturer AnManufacturer = new clsManufacturer();
            // check to see that the class is not null
            Assert.IsNotNull(AnManufacturer);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            // create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            // create spme test data to assign to the property 
            Boolean TestData = true;
            // assign the data to the property 
            AnManufacturer.Available = TestData;
            // test to see that the two values are the samme
            Assert.AreEqual(AnManufacturer.Available, TestData);
        }

        [TestMethod]
        public void YearMadePropertyOK()
        {
            //create an instance ok of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            // create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            AnManufacturer.YearMade = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnManufacturer.YearMade, TestData);
        }

        [TestMethod]
        public void ManufacturerIDPropertyOK()
        {
            //creat an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            // create some test data to assign to the property 
            Int32 TestData = 1;
            // assign the data to the property 
            AnManufacturer.ManufacturerID = TestData;
            // test to see tha the two values are the same 
            Assert.AreEqual(AnManufacturer.ManufacturerID, TestData);
        }

        [TestMethod]
        public void BatchProductionNoPropertyOK()
        {
            //creat an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            // create some test data to assign to the property 
            Int32 TestData = 1;
            // assign the data to the property 
            AnManufacturer.BatchProductionNo = TestData;
            // test to see tha the two values are the same 
            Assert.AreEqual(AnManufacturer.BatchProductionNo, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //creat an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            // create some test data to assign to the property 
            Int32 TestData = 1;
            // assign the data to the property 
            AnManufacturer.PhoneNo = TestData;
            // test to see tha the two values are the same 
            Assert.AreEqual(AnManufacturer.PhoneNo, TestData);
        }

        [TestMethod]
        public void CarModelPropertyOK()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            // create some test data to assign to the property 
            String TestData = "AB1";
            // assign the data to the property 
            AnManufacturer.CarModel = TestData;
            // test to see tha the two values are the same 
            Assert.AreEqual(AnManufacturer.CarModel, TestData);
        }

        [TestMethod]
        public void ChairManPropertyOK()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            // create some test data to assign to the property 
            String TestData = "Zack Lee";
            // assign the data to the property 
            AnManufacturer.ChairMan = TestData;
            // test to see tha the two values are the same 
            Assert.AreEqual(AnManufacturer.ChairMan, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            // create some test data to assign to the property 
            String TestData = "zacklee@manufacturer.com";
            // assign the data to the property 
            AnManufacturer.Email = TestData;
            // test to see tha the two values are the same 
            Assert.AreEqual(AnManufacturer.Email, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            // create some test data to use with the method 
            Int32 ManufacturerID = 1;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // test to see that the result is correct 
            Assert.IsTrue(Found);
        }

     


    }
}
