using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstTownCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class clsCustomer
            clsTownCollection AllTowns = new clsTownCollection();
            //check to see that the class it exists
            Assert.IsNotNull(AllTowns);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of our class clsCustomer
            clsTownCollection AllTowns = new clsTownCollection();
            //create some test data
            Int32 SomeCount = 1;
            //assign the data
            AllTowns.Count = SomeCount;
            //check to see that the two values are the same
            Assert.AreEqual(AllTowns.Count, SomeCount);
        }

        [TestMethod]
        public void AllTownsOK()
        {
            //create an instance of our class clsCustomer
            clsTownCollection Towns = new clsTownCollection();
            //create some test data to assign the property
            //in this case the data needs to be a list of objects
            List<clsTown> TestList = new List<clsTown>();
            //add an item to the lsit
            //create the item of test data
            clsTown TestItem = new clsTown();
            //set its propeties
            TestItem.TownNo = 1;
            TestItem.Town = "Leicester";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Towns.AllTowns = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Towns.AllTowns, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of our class clsCustomer
            clsTownCollection Towns = new clsTownCollection();
            //create some test data to assign the property
            //in this case the data needs to be a list of objects
            List<clsTown> TestList = new List<clsTown>();
            //add an item to the lsit
            //create the item of test data
            clsTown TestItem = new clsTown();
            //set its propeties
            TestItem.TownNo = 1;
            TestItem.Town = "Leicester";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Towns.AllTowns = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Towns.AllTowns, TestList);
        }
    }
}

