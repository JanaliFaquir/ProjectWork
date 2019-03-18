using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Framework
{
    [TestClass]
    public class tstManufacturerCollection
    {
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

    }

}

