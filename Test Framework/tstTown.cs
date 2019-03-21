using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstTown
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //Test to see it exists
            Assert.IsNotNull(ATown);
        }
        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //create some test data to assign the property
            string SomeTown = "Leicester";
            //assign the data of the property
            ATown.Town = SomeTown;
            //test to see the two values are the same
            Assert.AreEqual(ATown.Town, SomeTown);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //string variable to store any error message
            String Error = "";
            string SomeTown = "Leicester";
            //assign the data of the property
            Error = ATown.Valid(SomeTown);
            //test to see the results are ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMinLessOne()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string SomeTown = "";
            //this should trigger an error
            //Invoke the method
            Error = ATown.Valid(SomeTown);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMin()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string SomeTown = "a";
            //Invoke the method
            Error = ATown.Valid(SomeTown);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string SomeTown = "aa";
            //Invoke the method
            Error = ATown.Valid(SomeTown);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string SomeTown = "";
            //pad the string with characters
            SomeTown = SomeTown.PadRight(49, 'a');
            //Invoke the method
            Error = ATown.Valid(SomeTown);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMax()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string SomeTown = "";
            //pad the string with characters
            SomeTown = SomeTown.PadRight(50, 'a');
            //Invoke the method
            Error = ATown.Valid(SomeTown);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string SomeTown = "";
            SomeTown = SomeTown.PadRight(51, 'a');
            Error = ATown.Valid(SomeTown);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string SomeTown = "";
            //pad the string with characters
            SomeTown = SomeTown.PadRight(25, 'a');
            //Invoke the method
            Error = ATown.Valid(SomeTown);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownExtremeMax()
        {
            //create an instance of the class we want to create
            clsTown ATown = new clsTown();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string SomeTown = "";
            SomeTown = SomeTown.PadRight(500, 'a');
            Error = ATown.Valid(SomeTown);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}