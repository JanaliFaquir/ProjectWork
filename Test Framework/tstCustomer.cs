using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer

    {
        //good test data
        //create some test data to pass the test

        string FirstName = "John";
        string Surname = "Smith";
        string Street = "Leicester Road";
        string PostCode = "LE3 0GH";
        string Email = "a@hotmail.com";
        string HouseNo = "11A";
        string PhoneNo = "0746182329";
        string DateSold = DateTime.Now.Date.ToString();



        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //check to see that the class is not null
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }
        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "John";
            //assign the data to the property
            ACustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }
        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Smith";
            //assign the data to the property
            ACustomer.Surname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Surname, TestData);
        }
        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Leicester Road";
            //assign the data to the property
            ACustomer.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Street, TestData);
        }
        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE3 0GH";
            //assign the data to the property
            ACustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "a@hotmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "11A";
            //assign the data to the property
            ACustomer.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.HouseNo, TestData);
        }
        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07476182329";
            //assign the data to the property
            ACustomer.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }
        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Leicester";
            //assign the data to the property
            ACustomer.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Town, TestData);
        }
        [TestMethod]
        public void DateSoldPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateSold = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateSold, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //test to see the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.CustomerNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer 
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateSoldFound()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.DateSold != Convert.ToDateTime("01/01/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.FirstName != "John")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.Surname != "Smith")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.Street != "Leicester Road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.PostCode != "LE3 0GH")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.Town != "Leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestHouseNoFound()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.HouseNo != "11A")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the new class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.PhoneNo != "07476182329")
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
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string FirstName = ""; //this should trigger an error
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string FirstName = "a"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string FirstName = "aa"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fai
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void PostCodeMinLessOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should fail
            string PostCode = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void PostCodeMin()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should Pass
            string PostCode = "a";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PostCodeMinPlusOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should pass
            string PostCode = "aa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PostCodeMaxLessOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should pass
            string PostCode = "aaaaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PostCodeMax()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should Pass
            string PostCode = "aaaaaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PostCodeMaxPlusOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should fail
            string PostCode = "aaaaaaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void PostCodeMid()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should Pass
            string PostCode = "aaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void StreetMinLessOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should fail
            string Street = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void StreetMin()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should pass
            string Street = "a";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void StreetMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should pass
            string Street = "aa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should pass
            string Street = "";
            Street = Street.PadRight(49, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void StreetMax()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should pass
            string Street = "";
            Street = Street.PadRight(50, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void StreetMaxPlussOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should fail
            string Street = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void StreetMid()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "aa";
            //This should pass
            string Street = "";
            Street = Street.PadRight(25, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Surname = ""; //this should trigger an error
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Surname = "a"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Surname = "aa"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Surname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Surname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Surname = "aaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Surname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fai
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Surname = "";
            Surname = Surname.PadRight(500, 'a');
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Email = ""; //this should trigger an error
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Email = "a"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Email = "aa"; //this should be ok
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            ///this should pass
            string Email = "";
            //create some test data to pass the method
            Email = Email.PadRight(49, 'a');
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //this should pass
            string Email = "";
            //create some test data to pass the method
            Email = Email.PadRight(50, 'a');
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //this should pass
            string Email = "";
            //create some test data to pass the method
            Email = Email.PadRight(25, 'a');
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fai
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //String variable to store the results of the vailidation
            String Error = "";
            //create some test data to pass the method
            string Email = "";
            Email = Email.PadRight(500, 'a');
            //Invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void DateSoldExtremeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string DateSold = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateSoldMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string DateSold = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateSoldMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateSold = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateSoldMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to what the date is plus one
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string DateSold = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateSoldExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            string DateSold = TestDate.ToString();
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateSoldInvalidData()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //set the date added to a non date value
            string DateSold = "This is not a date!";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should fail
            string PhoneNo = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void PhoneNoMin()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should Pass
            string PhoneNo = "0";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PhoneNoMinPlusOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should pass
            string PhoneNo = "07";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PhoneNoMaxLessOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should pass
            string PhoneNo = "0747618232";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PhoneNoMax()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should Pass
            string PhoneNo = "07476182329";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void PhoneNoMaxPlusOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should fail
            string PhoneNo = "074761823299";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void PhoneNoMid()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should Pass
            string PhoneNo = "07476";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void HouseNoMinLessOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should fail
            string HouseNo = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void HouseNoMin()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should Pass
            string HouseNo = "1";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void HouseNoMinPlusOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should pass
            string HouseNo = "12";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void HouseNoMaxLessOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should pass
            string HouseNo = "12345";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void HouseNoMax()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should Pass
            string HouseNo = "123456";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void HouseNoMaxPlusOne()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should fail
            string HouseNo = "1234567";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void HouseNoMid()

        {

            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //This should Pass
            string HouseNo = "12345";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Surname, Street, PostCode, Email, HouseNo, PhoneNo, DateSold);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
    }

}




