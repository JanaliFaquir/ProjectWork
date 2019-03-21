using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCar
    {
        //good test data
        //create some test data to pass to pass to the method
        string CarName = "Audi";
        string Model = "A6 Sedan C8";
        string BodyType = "SUV";
        string YearMade = DateTime.Now.Date.ToString();
        
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
            Int32 TestData = 8;
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
            Int32 TestData = 3;
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
            ACar.CarName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.CarName, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            //create an instance f the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "X5 E70";
            //assign the data to the property
            ACar.Model = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Model, TestData);
        }

        [TestMethod]
        public void BodyTypePropertyOK()
        {
            //create an instance f the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "SUV";
            //assign the data to the property
            ACar.BodyType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.BodyType, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance f the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            decimal TestData = 25690.00m;
            //assign the data to the property
            ACar.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Price, TestData);
        }

        [TestMethod]
        public void StockPropertyOK()
        {
            //create an instance f the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            ACar.Stock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Stock, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CarID = 8;
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
            Int32 CarID = 8;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the car ID
            if (ACar.CarID != 8)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarNameFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 CarID = 8;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the Car ID
            if (ACar.CarName != "BMW")
        {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestModelFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 CarID = 8;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the Car ID
            if (ACar.Model != "X5 E70")
        {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBodyTypeFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 CarID = 8;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the Car ID
            if (ACar.BodyType != "SUV")
        {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColourNoFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 CarID = 8;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the Car ID
            if (ACar.ColourNo != 3)
        {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 CarID = 8;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the Car ID
            if (ACar.Price != 25690.00m)
        {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 CarID = 8;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the Car ID
            if (ACar.Stock != 2)
        {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestYearMadeFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 CarID = 8;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the Car ID
            if (ACar.YearMade != Convert.ToDateTime("21/03/2008"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFuelFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 CarID = 8;
            //invoke the method
            Found = ACar.Find(CarID);
            //check the Car ID
            if (ACar.Fuel != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //invoke th method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = ""; //this hould trigger an error
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarNameMin()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "aaaa"; //this should be ok
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "aaaaa"; //this should be ok
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "aaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CarNameMax()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarNameMid()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "aaaaa"; //this should be ok
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "aaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CarName = "";
            CarName = CarName.PadRight(15, 'a'); //this should fail
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void YearMadeExtremeMin()
        {
            //create an instance of the class we want to create 
            clsCar ACar = new clsCar();
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
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void YearMadeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCar ACar = new clsCar();
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
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void YearMadeMin()
        {
            //create an instance of the class we want to create 
            clsCar ACar = new clsCar();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string YearMade = TestDate.ToString();
            //invoke the method 
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void YearMadeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCar ACar = new clsCar();
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
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void YearMadeExtrmeMax()
        {
            //create an instance of the class we want to create 
            clsCar ACar = new clsCar();
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
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void YearMadeInvalidDate()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string vriable to store any error message
            String Error = "";
            //set YearMade to a non date value
            string YearMade = "this is not a date";
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void ModelMinLessOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Model = "";
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMin()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Model = "a";
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Model = "aa";
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Model = "";
            Model = Model.PadRight(24, 'a');
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMax()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Model = "";
            Model = Model.PadRight(25, 'a');
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Model = "";
            Model = Model.PadRight(26, 'a');
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Model = "";
            Model = Model.PadRight(25, 'a'); //this should fail
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMid()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Model = "aaaaaaaaaaaaa";
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BodyTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BodyType = "";
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BodyTypeMin()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BodyType = "aaa";
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BodyTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BodyType = "aaaa";
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BodyTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BodyType = "";
            BodyType = BodyType.PadRight(19, 'a');
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BodyTypeMax()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BodyType = "";
            BodyType = BodyType.PadRight(20, 'a');
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BodyTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BodyType = "";
            BodyType = BodyType.PadRight(21, 'a');
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BodyTypeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BodyType = "";
            BodyType = BodyType.PadRight(20, 'a'); //this should fail
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BodyTypeMid()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BodyType = "";
            BodyType = BodyType.PadRight(10, 'a');
            //invoke the method
            Error = ACar.Valid(CarName, Model, BodyType, YearMade);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}