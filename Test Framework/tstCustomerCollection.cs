using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see if it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties 
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "John";
            TestItem.Surname = "Smith";
            TestItem.Email = "a@hotmail.com";
            TestItem.Street = "Leicester Road";
            TestItem.PostCode = "LE3 0GH";
            TestItem.HouseNo = "11A";
            TestItem.PhoneNo = "07476182329";
            TestItem.DateSold = DateTime.Now.Date;
            TestItem.Town = "Leicester";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //Set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.CustomerNo = 1;
            TestCustomer.FirstName = "John";
            TestCustomer.Surname = "Smith";
            TestCustomer.Email = "a@hotmail.com";
            TestCustomer.Street = "Leicester Road";
            TestCustomer.PostCode = "LE3 0GH";
            TestCustomer.HouseNo = "11A";
            TestCustomer.PhoneNo = "07476182329";
            TestCustomer.DateSold = DateTime.Now.Date;
            TestCustomer.Town = "Leicester";
            //asssign the sata to the porperty 
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add new item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "John";
            TestItem.Surname = "Smith";
            TestItem.Email = "a@hotmail.com";
            TestItem.Street = "Leicester Road";
            TestItem.PostCode = "LE3 0GH";
            TestItem.HouseNo = "11A";
            TestItem.PhoneNo = "07476182329";
            TestItem.DateSold = DateTime.Now.Date;
            TestItem.Town = "Leicester";
            //add the item to the test list
            TestList.Add(TestItem);
            //asssign the sata to the porperty 
            AllCustomers.CustomerList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item of test data 
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "John";
            TestItem.Surname = "Smith";
            TestItem.Email = "a@hotmail.com";
            TestItem.Street = "Leicester Road";
            TestItem.PostCode = "LE3 0GH";
            TestItem.HouseNo = "11A";
            TestItem.PhoneNo = "07476182329";
            TestItem.DateSold = DateTime.Now.Date;
            TestItem.Town = "Leicester";
            //set This Customer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key to the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item of test data 
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "John";
            TestItem.Surname = "Smith";
            TestItem.Email = "a@hotmail.com";
            TestItem.Street = "Leicester Road";
            TestItem.PostCode = "LE3 0GH";
            TestItem.HouseNo = "11A";
            TestItem.PhoneNo = "07476182329";
            TestItem.DateSold = DateTime.Now.Date;
            TestItem.Town = "Leicester";
            //set This Customer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key to the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item of test data 
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "John";
            TestItem.Surname = "Smith";
            TestItem.Email = "a@hotmail.com";
            TestItem.Street = "Leicester Road";
            TestItem.PostCode = "LE3 0GH";
            TestItem.HouseNo = "11A";
            TestItem.PhoneNo = "07476182329";
            TestItem.DateSold = DateTime.Now.Date;
            TestItem.Town = "Leicester";
            //set This Customer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key to the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.CustomerNo = 2;
            TestItem.FirstName = "James";
            TestItem.Surname = "Dean";
            TestItem.Email = "aa@hotmail.com";
            TestItem.Street = "Bedford Road";
            TestItem.PostCode = "LE3 1GH";
            TestItem.HouseNo = "11B";
            TestItem.PhoneNo = "07776182329";
            TestItem.DateSold = DateTime.Now.Date;
            TestItem.Town = "Bedford";
            //set The record based on the new data
            AllCustomers.ThisCustomer = TestItem;
            //update the new record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByPhoneNoMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (Should return all records)
            FilteredCustomers.ReportByPhoneNo("");
            //test to see the two vales are the same
            Assert.AreNotEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPhoneNoNoneFound()
        {
        
            //create an instance of filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (Should return all records)
            FilteredCustomers.ReportByPhoneNo("12345678910");
            //test to see there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByPhoneNo(string PhoneNo)
        {

            //filters the records based on full or partial phone no
            clsDataConnection DB = new clsDataConnection();
            //send the phone no parameter to the database
            DB.AddParameter("@PhoneNo", PhoneNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByPhoneNo");
            
        }
        [TestMethod]
        public void ReportByPhoneNoTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a phone no tha doesnt exist
            FilteredCustomers.ReportByPhoneNo("yyyyyyyyyyy");
            //check that the correct number of records are found 
            if (FilteredCustomers.Count == 2)
            {
                //check to see the first record id 4
                if (FilteredCustomers.CustomerList[0].CustomerNo != 4)
                {
                    OK = false;
                }
                //check that the first recors ID is 5
                if (FilteredCustomers.CustomerList[1].CustomerNo != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
