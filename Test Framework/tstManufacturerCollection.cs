using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstManufacturerCollection
    {
        public object TestManufacturer { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllManufacturers);
        }

        [TestMethod]
        public void ManufacturerListOK()
        {
            //create an instace of the class we want to create 
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            // create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsManufacturer> TestList = new List<clsManufacturer>();
            //add an item to the list 
            //create the item of test data 
            clsManufacturer TestItem = new clsManufacturer();
            // set its properties 
            TestItem.Available = true;
            TestItem.ManufacturerID = 456;
            TestItem.BatchProductionNo = 4;
            TestItem.YearMade = DateTime.Now.Date;
            TestItem.CarModel = "a31";
            TestItem.ChairMan = "zack";
            TestItem.Email = "zack@gmail.com";
            TestItem.PhoneNo = 987647652;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllManufacturers.ManufacturerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllManufacturers.ManufacturerList, TestList);
        }


        [TestMethod]
        public void ThisManufacturerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create sme test data to assign to tthe property 
            clsManufacturer TestManufacturer = new clsManufacturer();
            // set the properties of the test object 
            TestManufacturer.Available = true;
            TestManufacturer.ManufacturerID = 456;
            TestManufacturer.BatchProductionNo = 4;
            TestManufacturer.YearMade = DateTime.Now.Date;
            TestManufacturer.CarModel = "a31";
            TestManufacturer.ChairMan = "zack";
            TestManufacturer.Email = "zack@gmail.com";
            TestManufacturer.PhoneNo = 987647652;
            //assign data to the property 
            AllManufacturers.ThisManufacturer = TestManufacturer;
            //test to see that the two values are the same 
            Assert.AreEqual(AllManufacturers.ThisManufacturer, TestManufacturer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instane of the class we want to create 
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create some test data to asisgn to the property 
            //in this case the data needs to be a list of obkets 
            List<clsManufacturer> TestList = new List<clsManufacturer>();
            //add an item to the list 
            //ceate the item of the test data 
            clsManufacturer TestItem = new clsManufacturer();
            //set its properties 
            TestItem.Available = true;
            TestItem.ManufacturerID = 456;
            TestItem.BatchProductionNo = 4;
            TestItem.YearMade = DateTime.Now.Date;
            TestItem.CarModel = "a31";
            TestItem.ChairMan = "zack";
            TestItem.Email = "zack@gmail.com";
            TestItem.PhoneNo = 987647652;
            //assign data to the property 
            //add item to tes list 
            TestList.Add(TestItem);
            AllManufacturers.ManufacturerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllManufacturers.Count, TestList.Count);
        }


        [TestMethod]

        public void AddMethodOK()
        {
            //creatte an instanc of the class we want to create 
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create he item of test data 
            clsManufacturer TestItem = new clsManufacturer();
            // var to stoe the pri,ary key 
            Int32 PrimaryKey = 0;
            // set its properties 
            TestItem.Available = true;
            TestItem.ManufacturerID = 456;
            TestItem.BatchProductionNo = 4;
            TestItem.YearMade = DateTime.Now.Date;
            TestItem.CarModel = "a31";
            TestItem.ChairMan = "zack";
            TestItem.Email = "zack@gmail.com";
            TestItem.PhoneNo = 987647652;
            //set ThisCar to the test data
            AllManufacturers.ThisManufacturer = TestItem;
            //set this manufacturer to the test data 
            PrimaryKey = AllManufacturers.Add();
            //set primary key 
            TestItem.ManufacturerID = PrimaryKey;
            //find te record 
            AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //test to see that the two values are the sme 
            Assert.AreEqual(AllManufacturers.ThisManufacturer, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create the item of test data 
            clsManufacturer TestItem = new clsManufacturer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            // set its properties 
            TestItem.Available = true;
            TestItem.ManufacturerID = 456;
            TestItem.BatchProductionNo = 4;
            TestItem.YearMade = DateTime.Now.Date;
            TestItem.CarModel = "a31";
            TestItem.ChairMan = "zack";
            TestItem.Email = "zack@gmail.com";
            TestItem.PhoneNo = 987647652;
            //set ThisCar to the test data
            AllManufacturers.ThisManufacturer = TestItem;
            //set this manufacturer to the test data 
            PrimaryKey = AllManufacturers.Add();
            //set primary key 
            TestItem.ManufacturerID = PrimaryKey;
            //find te record 
            AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //delte record 
            AllManufacturers.DeleteManufacturer();
            //now to find the record 
            Boolean Found = AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we wnat to create 
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create the item of test data 
            clsManufacturer TestItem = new clsManufacturer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            // set its properties 
            TestItem.Available = true;
            TestItem.ManufacturerID = 456;
            TestItem.BatchProductionNo = 4;
            TestItem.YearMade = DateTime.Now.Date;
            TestItem.CarModel = "a31";
            TestItem.ChairMan = "zack";
            TestItem.Email = "zack@gmail.com";
            TestItem.PhoneNo = 987647652;
            //set ThisCar to the test data
            AllManufacturers.ThisManufacturer = TestItem;
            //set this manufacturer to the test data 
            PrimaryKey = AllManufacturers.Add();
            //set primary key 
            TestItem.ManufacturerID = PrimaryKey;
            //modify the test data 
            TestItem.Available = true;
            TestItem.ManufacturerID = 456;
            TestItem.BatchProductionNo = 4;
            TestItem.YearMade = DateTime.Now.Date;
            TestItem.CarModel = "a31";
            TestItem.ChairMan = "dan";
            TestItem.Email = "dan@gmail.com";
            TestItem.PhoneNo = 987647652;
            //set the record based on the new test data 
            AllManufacturers.ThisManufacturer = TestItem;
            //update the record 
            AllManufacturers.Update();
            //find the record 
            AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //test to see thismanufacture matches the test data 
            Assert.AreEqual(AllManufacturers.ThisManufacturer, TestItem);


        }

        [TestMethod]
        public void ReportByEmailMethodOK()
        {
            //create an instance of the c;;ass cotaining unfiltiered results 
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //create an instance of the filtered data 
            clsManufacturerCollection FilteredManufacturers = new clsManufacturerCollection();
            // apply a blank string should return all records 
            FilteredManufacturers.ReportByEmail("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllManufacturers.Count, FilteredManufacturers.Count);
        }

        [TestMethod]

        public void ReportByEmailNoneFound()
        {
            //create an instance of the class 
            clsManufacturerCollection FilteredManufacturers = new clsManufacturerCollection();

            //apply a email that doesnt exist 
            FilteredManufacturers.ReportByEmail("xxx xxx");
            //test to see that there aree no records 
            Assert.AreEqual(0, FilteredManufacturers.Count);
        }

        [TestMethod]
        public void ReportByMethodTestDataFound()
        {
            //create an instance of the filtered data
            clsManufacturerCollection FilteredManufacturers = new clsManufacturerCollection();
            //var to store outcomes
            Boolean OK = false;
            //apply a model that doesn't exist
            FilteredManufacturers.ReportByEmail("xxxxxxxxxx");
            //check that the correct number of records are found
            if (FilteredManufacturers.Count == 2)
            {
                //check that the first record is ID 4
                if (FilteredManufacturers.ManufacturerList[0].ManufacturerID != 9)
                {
                    OK = false;
                }
                //check that the first record is ID 1
                if (FilteredManufacturers.ManufacturerList[1].ManufacturerID != 10)
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

