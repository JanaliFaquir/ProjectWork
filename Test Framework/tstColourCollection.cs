using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstColourCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class clsCar
            clsColourCollection AllColours = new clsColourCollection();
            //check to see that the class is not null
            Assert.IsNotNull(AllColours);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of our class clsCar
            clsColourCollection AllColours = new clsColourCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 10;
            //assign the data to the property
            AllColours.Count = SomeCount;
            //check to see that the class is not null
            Assert.AreEqual(AllColours.Count, SomeCount);
        }

        [TestMethod]
        public void AllColoursOK()
        {
            //create an instance of the class we want to create
            clsColourCollection Colours = new clsColourCollection();
            //create some test data to assign to the property
            //in this case that data needs to be a list of objects
            List<clsColour> TestList = new List<clsColour>();
            //add an item to the list
            //create the item of test data
            clsColour TestItem = new clsColour();
            //set its properties
            TestItem.ColourNo = 1;
            TestItem.ColourName = "Red";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Colours.AllColours = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Colours.AllColours, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsColourCollection Colours = new clsColourCollection();
            //create some test data to assign to the property
            //in this case that data needs to be a list of objects
            List<clsColour> TestList = new List<clsColour>();
            //add an item to the list
            //create the item of test data
            clsColour TestItem = new clsColour();
            //set its properties
            TestItem.ColourNo = 1;
            TestItem.ColourName = "Red";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Colours.AllColours = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Colours.Count, TestList.Count);
        }

    }
}
