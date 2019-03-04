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


        [TestMethod]
        public void FuelPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some trest data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACar.Fuel = TestData;
            //test to see thst the two values are the same
            Assert.AreEqual(ACar.Fuel, TestData);
        }

        [TestMethod]
        public void YearMadePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACar.YearMade = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.YearMade, TestData);
        }

        [TestMethod]
        public void CarIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACar.CarID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.CarID, TestData);
        }

        [TestMethod]
        public void ColourNoPropertyOK()
        {
            //create an instance f the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACar.ColourNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.ColourNo, TestData);
        }

        [TestMethod]
        public void CarNamePropertyOK()
        {
            //create an instance f the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "BMW";
            //assign the data to the property
            ACar.mCarName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.mCarName, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            //create an instance f the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "E30";
            //assign the data to the property
            ACar.mModel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.mModel, TestData);
        }

        [TestMethod]
        public void BodyTypePropertyOK()
        {
            //create an instance f the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Saloon";
            //assign the data to the property
            ACar.mBodyType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.mBodyType, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance f the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            decimal TestData = 2999.99m;
            //assign the data to the property
            ACar.mPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.mPrice, TestData);
        }

        [TestMethod]
        public void StockPropertyOK()
        {
            //create an instance f the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACar.mStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.mStock, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = ACar.Find(CarID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCarIDFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the car ID
            if (ACar.CarID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}