using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstColour
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class clsCar
            clsColour AColour = new clsColour();
            //check to see that the class is not null
            Assert.IsNotNull(AColour);
        }

        [TestMethod]
        public void ColourNoPropertyOK()
        {
            //create an instance f the class we want to create
            clsColour AColour = new clsColour();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AColour.ColourNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AColour.ColourNo, TestData);
        }

        [TestMethod]
        public void ColourNamePropertyOK()
        {
            //create an instance f the class we want to create
            clsColour AColour = new clsColour();
            //create some test data to assign to the property
            string SomeColourName = "Red";
            //assign the data to the property
            AColour.ColourName = SomeColourName;
            //test to see that the two values are the same
            Assert.AreEqual(AColour.ColourName, SomeColourName);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsColour AColour = new clsColour();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string SomeColourName = "Red";
            //invoke th method
            Error = AColour.Valid(SomeColourName);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsColour AColour = new clsColour();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to assign to the property
            Int32 ColourNo = 1;
            //invoke th method
            Found = AColour.Find(ColourNo);
            //test to see that the result is correct
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ColourNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsColour AColour = new clsColour();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeColourName = ""; //this hould trigger an error
            //invoke the method
            Error = AColour.Valid(SomeColourName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsColour AColour = new clsColour();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeColourName = "aaa"; //this should be ok
            //invoke the method
            Error = AColour.Valid(SomeColourName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsColour AColour = new clsColour();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeColourName = "aaaa"; //this should be ok
            //invoke the method
            Error = AColour.Valid(SomeColourName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsColour AColour = new clsColour();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeColourName = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AColour.Valid(SomeColourName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ColourNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsColour AColour = new clsColour();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeColourName = "aaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AColour.Valid(SomeColourName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsColour AColour = new clsColour();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeColourName = "aaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AColour.Valid(SomeColourName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourNameMid()
        {
            //create an instance of the class we want to create
            clsColour AColour = new clsColour();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeColourName = "aaaaaaaa"; //this should be ok
            //invoke the method
            Error = AColour.Valid(SomeColourName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsColour AColour = new clsColour();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeColourName = "";
            SomeColourName = SomeColourName.PadRight(50, 'a'); //this should fail
            //invoke the method
            Error = AColour.Valid(SomeColourName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
