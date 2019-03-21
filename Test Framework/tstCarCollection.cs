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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Fuel = true;
            TestItem.CarID = 3;
            TestItem.ColourNo = 4;
            TestItem.CarName = "Audi";
            TestItem.Model = "A6 Sedan C8";
            TestItem.BodyType = "SUV";
            TestItem.Price = 47739.99m;
            TestItem.Stock = 3;
            TestItem.YearMade = DateTime.Now.Date;
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of the test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Fuel = true;
            TestItem.CarID = 3;
            TestItem.ColourNo = 4;
            TestItem.CarName = "Audi";
            TestItem.Model = "A6 Sedan C8";
            TestItem.BodyType = "SUV";
            TestItem.Price = 47739.99m;
            TestItem.Stock = 3;
            TestItem.YearMade = DateTime.Now.Date;
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //delete the record
            AllCars.Delete();
            //now find the record
            Boolean Found = AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of the test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Fuel = true;
            TestItem.CarID = 3;
            TestItem.ColourNo = 4;
            TestItem.CarName = "Audi";
            TestItem.Model = "A6 Sedan C8";
            TestItem.BodyType = "SUV";
            TestItem.Price = 47739.99m;
            TestItem.Stock = 3;
            TestItem.YearMade = DateTime.Now.Date;
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //modify the test data
            TestItem.Fuel = false;
            TestItem.CarID = 3;
            TestItem.ColourNo = 5;
            TestItem.CarName = "Audi";
            TestItem.Model = "A6 Sedan C8";
            TestItem.BodyType = "SUV";
            TestItem.Price = 49939.99m;
            TestItem.Stock = 2;
            TestItem.YearMade = DateTime.Now.Date;
            //set the record based on the new test data
            AllCars.ThisCar = TestItem;
            //update the record0
            AllCars.Update();
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see ThisCar matches the test data
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void ReportByModelMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS CONTAINING UNFILTERED RESULTS
            clsCarCollection AllCars = new clsCarCollection();
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //apply a blank string (should return all records)
            FilteredCars.ReportByModel("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, FilteredCars.Count);
        }

        [TestMethod]
        public void ReportByModelNoneFound()
        {
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //apply a model that doesn't exist
            FilteredCars.ReportByModel("xxxxxxxxxx xxxxxxxxxx xxxxx");
            //test  to see that there are no records
            Assert.AreEqual(0, FilteredCars.Count);
        }

        [TestMethod]
        public void ReportByMethodTestDataFound()
        {
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //var to store outcomes
            Boolean OK = true;
            //apply a model that doesn't exist
            FilteredCars.ReportByModel("121321313212132132131321321321");
            //check that the correct number of records are found
            if (FilteredCars.Count == 2)
            {
                //check that the first record is ID 4
                if (FilteredCars.CarList[0].CarID != 9)
                {
                    OK = false;
                }
                //check that the first record is ID 1
                if (FilteredCars.CarList[1].CarID != 10)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsFalse(OK);
        }
    }
}
