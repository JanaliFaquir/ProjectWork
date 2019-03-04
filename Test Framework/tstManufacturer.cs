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
            Int32 TestData = 456;
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
            Int32 TestData = 456;
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
            Int32 TestData = 456;
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
            String TestData = "a31";
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
            String TestData = "zack";
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
            String TestData = "zack@gmail.com";
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
            Int32 ManufacturerID = 456;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // test to see that the result is correct 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestManufacturerIDNoFound()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            // boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 ManufacturerID = 456;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // check the manufacturer id
            if (AnManufacturer.ManufacturerID != 456)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            // boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 ManufacturerID = 456;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // check the property
            if (AnManufacturer.Available != true)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestYearMadeFound()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            // boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 ManufacturerID = 456;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // check the property
            if (AnManufacturer.YearMade != Convert.ToDateTime("04/03/2018")) 
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}
