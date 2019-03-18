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
        }
    }
    
