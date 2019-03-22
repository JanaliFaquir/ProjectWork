using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic; 

namespace Test_Framework
{
    [TestClass]
    public class tstBatchProductionCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsBatchProductionCollection AllBatchProductions = new clsBatchProductionCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllBatchProductions); 
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an istance of the class we want to create 
            clsBatchProductionCollection AllBatchProductions = new clsBatchProductionCollection();
            //create some test data to assign to the property 
            Int32 SomeCount = 25;
            //assign the data to the property 
            AllBatchProductions.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllBatchProductions.Count, SomeCount); 
        }

        [TestMethod]
        public void AllBatchProductionsOK()
        {
            //create an instance of the class we want to create 
            clsBatchProductionCollection BatchProductions = new clsBatchProductionCollection();
            //create some test data to assign to the property 
            // in this case the data needs to be a list of objects 
            List<clsBatchProduction> TestList = new List<clsBatchProduction>();
            //add an item to the list 
            //create the item of test data 
            clsBatchProduction TestItem = new clsBatchProduction();
            //set its properties 
            TestItem.BatchProductionNo = 1;
            TestItem.BatchProduction = "One";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            BatchProductions.AllBatchProductions = TestList;
            // test to see hat the two values are the same 
            Assert.AreEqual(BatchProductions.AllBatchProductions, TestList); 
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instace of the clas we want to create 
            clsBatchProductionCollection BatchProductions = new clsBatchProductionCollection();
            //create some test data to assign to the property 
            //in this case the dat aneeds to be a list of objects 
            List<clsBatchProduction> TestList = new List<clsBatchProduction>();
            //add an item to the list 
            //create the item of test data
            clsBatchProduction TestItem = new clsBatchProduction();
            //set its properties 
            TestItem.BatchProductionNo = 1;
            TestItem.BatchProduction = "One";
            //add te item to the test list 
            TestList.Add(TestItem);
            //assignt he dat to hthe property 
            BatchProductions.AllBatchProductions = TestList;
            // test to see that the two values are the sAME 
            Assert.AreEqual(BatchProductions.Count, TestList.Count);
        }

 
}
}
