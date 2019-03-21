using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstBatchProductionNo
    {
        //good test data
        // create some test data to pass to the method 
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of our class clsManufacturer
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            // check to see that the class is not null
            Assert.IsNotNull(ABatchProduction);
        }

        [TestMethod]
        public void BatchProductionPropertyOK()
        {
            //create an instance of the class we want to create 
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            // create some testdata to assign to the property 
            string SomeBatchProduction = "One";
            // assign data to proerty 
            ABatchProduction.BatchProduction = SomeBatchProduction;
            //TEST TO SEE that the two values are the same 
            Assert.AreEqual(ABatchProduction.BatchProduction, SomeBatchProduction);
        }

        [TestMethod]
        public void SomeBatchProductionNoPropertyOK()
        {
            //create an instance of the class we want to creat e
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            //create some test data to assign to the property 
            Int32 BatchProductionNo = 1;
            //asisgn the data to the property 
            ABatchProduction.BatchProductionNo = BatchProductionNo;
            //test to see that the two values are the same 
            Assert.AreEqual(ABatchProduction.BatchProductionNo, BatchProductionNo); 
        }

        [TestMethod]

        public void MethodOK()
        {
            //create an instance of the class we want to create 
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            //CREATE A STRN VARIABLE to store the result of the validation 
            string Error = "";
            //create some test data to test themethod 
            string SomeBatchProduction = "One";
            //invoke the method 
            Error = ABatchProduction.Valid(SomeBatchProduction);
            //test to see that the result is ok ie there were no error message returned 
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]

        public void BatchProductionMinLessOne()
        {
            //create an instance of the class we want to create 
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            //create a strng variable to stor ethe result of the valoidation 
            string Error = "";
            //create some tets data to test the method 
            string SomeBatchProduction = "";
            //invoke the method 
            Error = ABatchProduction.Valid(SomeBatchProduction);
            // test to se ethat the result is not ok ie there should be an error msg 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BatchProductionMinBoundary()
        {
            //create an instance of the class we want to create 
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            //CREATE A STRING variable to store the result of tj evaidatio mn
            string Error = "";
            // cretae some test data to test the method 
            string SomeBatchProduction = "a";
            // invoke the method 
            Error = ABatchProduction.Valid(SomeBatchProduction);
            //test to see that he result is ok there was no error 
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void BatchProductionMinPlusOne()
        {
            // create an instance of the class we want to crete 
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            //create a string variable to store the result of the validation 
            String Error = "";
            // cretae some test dat to test the metod 
            string SomeBatchProduction = "aa";
            //invoke the method 
            Error = ABatchProduction.Valid(SomeBatchProduction);
            // tets to see that the result is ok ie there wa sno error msg returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void BatchProductionMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            // create a string variable to store the reult of the valiation 
            String Error = "";
            // create some test data to test the method 
            string SomeBatchProduction = "hghyhfjkuilkujhyjhujhgyhgnbghvghyhgnsgyhduijhnh";
            // invoke the method 
            Error = ABatchProduction.Valid(SomeBatchProduction);
            //test to se ethat the result is ok ie there was no erro msg returned 
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]

        public void BatchProductionMaxBoundary()
        {
            //create an instance of he class we want to creat 
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            //create a string variable to store the results of the validation 
            String Error = "";
            //create some test data tp test the method 
            String SomeBatchProduction = "hghyhfjkuilkujhyjhujhgyhgnbghvghyhgnsgyhduijhnhd";
            //invoke the method 
            Error = ABatchProduction.Valid(SomeBatchProduction);
            //test to see that the result is ok ie there was no error msg eturned 
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]

        public void BatchProductionMaxPlusOne()
        {
            //create an instance if the class we want to create 
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            //create a string variable to store the result of the validation 
            String Error = "";
            //create some test data to test the method 
            String SomeBatchProduction = "hghyhfjkuilkujhyjhujhgyhgnbghvghyhgnsgyhduijhnhsd";
            //invoke the methd
            Error = ABatchProduction.Valid(SomeBatchProduction);
            //test to see that the result is nt ok ie there should be an error msg 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void BatchProductionMid()
        {
            //create an instance of the class we want to create 
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            //create a string variable to store he resut of the validation
            String Error = "";
            //create some test data to ttest the mehod 
            string SomeBatchProduction = "1234567890123456765434545"; 
            //invoke the method
            Error = ABatchProduction.Valid(SomeBatchProduction);
            //test to see that the result is ok ie there was no error message returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BatchProductionExtremeMax()
        {
            //create an instance of the class we want to create 
            clsBatchProduction ABatchProduction = new clsBatchProduction();
            //create a string variable to store the result of validation 
            String Error = "";
            //create some test data to test the method 
            string SomeBatchProduction = "";
            //pad the string with the characteres 
            SomeBatchProduction = SomeBatchProduction.PadRight(100, 'a');
            //invoke the method 
            Error = ABatchProduction.Valid(SomeBatchProduction);
            //test to see that the resut is not ok ie there should be an error msg 
            Assert.AreNotEqual(Error, ""); 
        }

    }
}
