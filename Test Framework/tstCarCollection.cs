using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstCarCollection
    {
        public object TestCar { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCars);
        }

        [TestMethod]
        public void CarListOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            //in this case that data needs to be a list of objects
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list
            //create the item of test data
            clsCar TestItem = new clsCar();
            //set its properties
            TestItem.Fuel = true;
            TestItem.CarID = 3;
            TestItem.ColourNo = 4;
            TestItem.YearMade = DateTime.Now.Date;
            TestItem.CarName = "Audi";
            TestItem.Model = "A6 Sedan C8";
            TestItem.BodyType = "SUV";
            TestItem.Price = 44737.99m;
            TestItem.Stock = 3;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.CarList, TestList);
        }

       
        [TestMethod]
        public void ThisCarPropertyOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            clsCar TestCar = new clsCar();
            //set the properties of the test object
            TestCar.Fuel = true;
            TestCar.CarID = 3;
            TestCar.ColourNo = 4;
            TestCar.CarName = "Audi";
            TestCar.Model = "A6 Sedan C8";
            TestCar.BodyType = "SUV";
            TestCar.Price = 44737.99m;
            TestCar.Stock = 3;
            TestCar.YearMade = DateTime.Now.Date;
            //assign the data to the property
            AllCars.ThisCar = TestCar;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.ThisCar, TestCar);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list
            //create the time of test data
            clsCar TestItem = new clsCar();
            //set its properties
            TestItem.Fuel = true;
            TestItem.CarID = 3;
            TestItem.ColourNo = 4;
            TestItem.CarName = "Audi";
            TestItem.Model = "A6 Sedan C8";
            TestItem.BodyType = "SUV";
            TestItem.Price = 44737.99m;
            TestItem.Stock = 3;
            TestItem.YearMade = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, TestList.Count);

        }

    }
}
