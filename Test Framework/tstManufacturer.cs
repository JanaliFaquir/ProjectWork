using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstManufacturer
    {
        //good test data
        // create some test data to pass to the method 
        string CarModel = "a31";
        string ChairMan = "zack";
        string Email = "zack@gmail.com";
        string YearMade = DateTime.Now.Date.ToString();

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
            Int32 TestData = 123;
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
            Int32 TestData = 123;
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
            Int32 ManufacturerID = 123;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // test to see that the result is correct 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestManufacturerIDFound()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            // boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 ManufacturerID = 123;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // check the manufacturer id
            if (AnManufacturer.ManufacturerID != 123)
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
            Int32 ManufacturerID = 123;
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
            Int32 ManufacturerID = 123;
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


        [TestMethod]
        public void TestBatchProductionNoFound()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            // boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 ManufacturerID = 123;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // check the property
            if (AnManufacturer.BatchProductionNo != 3)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneFound()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            // boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 ManufacturerID = 123;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // check the property
            if (AnManufacturer.PhoneNo != 987647652)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarModelFound()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            // boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 ManufacturerID = 123;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // check the property
            if (AnManufacturer.CarModel != "a31")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestChairManFound()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            // boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 ManufacturerID = 123;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // check the property
            if (AnManufacturer.ChairMan != "zack")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            // boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 ManufacturerID = 123;
            // invoke the method 
            Found = AnManufacturer.Find(ManufacturerID);
            // check the property
            if (AnManufacturer.Email != "zack@gmail.com")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void VaidMethodOK()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //invoke the method
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMinLessOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should fail
            string CarModel = "";
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CarModelMin()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass 
            string CarModel = "a"; // this should be ok 
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass
            string CarModel = "aa"; // this should be ok 
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass 
            string CarModel = "aaaaaaaaaaaaaaaaaaaaaaaa";
            CarModel = CarModel.PadRight(24, 'a');
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMax()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass
            string CarModel = "aaaaaaaaaaaaaaaaaaaaaaaaa"; // this should be ok 
            CarModel = CarModel.PadRight(25, 'a');
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should fail
            string CarModel = "aaaaaaaaaaaaaaaaaaaaaaaa";

            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMid()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should fail 
            string CarModel = "aaaaaaaaaaaaa";
            CarModel = CarModel.PadRight(13, 'a');
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ChairManMinLessOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should fail
            string ChairMan = "";
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ChairManMin()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass 
            string ChairMan = "a"; // this should be ok 
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ChairManMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass
            string ChairMan = "aa"; // this should be ok 
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ChairManMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass 
            string ChairMan = "";
            ChairMan = ChairMan.PadRight(34, 'a');
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ChairManMax()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass
            string ChairMan = ""; // this should be ok 
            ChairMan = ChairMan.PadRight(35, 'a');
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ChairManMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should fail
            string ChairMan = "";
            ChairMan = ChairMan.PadRight(36, 'a');
           //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ChairManMid()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should fail 
            string ChairMan = "";
            ChairMan = ChairMan.PadRight(18, 'a');
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should fail
            string Email = "";
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass 
            string Email = "a"; // this should be ok 
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailPlusOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass
            string Email = "aa"; // this should be ok 
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass 
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should pass
            string Email = ""; // this should be ok 
            Email = Email.PadRight(50, 'a');
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should fail
            string Email = "";
            Email = Email.PadRight(51, 'a');

            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            string Error = "";
            //this should fail 
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            // test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void YearMadeExtremeMin()

        {

            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string YearMade = TestDate.ToString();
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void YearMadeMinLessOne()

        {

            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
           //change the date to whatever the date is less 1 day 
            TestDate = TestDate.AddDays(-1);
         //convert the date variable to a string variable 
            string YearMade = TestDate.ToString();
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void YearMadeMin()

        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            String Error = "";
           //create a variable to store the test date data 
           DateTime TestDate;
           //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string YearMade = TestDate.ToString();
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        public void YearMadeMinPlusOne()

        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day 
            TestDate = TestDate.AddDays(1); 
            //convert the date variable to a string variable 
            string YearMade = TestDate.ToString();
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        public void YearMadeExtrmeMax()

        {
            //create an instance of the class we want to create 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day 
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            string YearMade = TestDate.ToString();
            //invoke the method 
            Error = AnManufacturer.Valid(CarModel, ChairMan, Email, YearMade);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }


    
        


    }
} 

