using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsBatchProductionCollection
    {

        //create an instance 
        private List<clsBatchProduction> mAllBatchProductions = new List<clsBatchProduction>();


        //public property for count 
        public int Count
        {
            get
            {
                //return the count property f the privte list 
                return mAllBatchProductions.Count;
            }
            set
            {
                //we will look at tgius in a moment 
            }
        }

        // public for all countries 
        public List<clsBatchProduction> AllBatchProductions
        {
            //greate sends data to requesting code 
            get
            {
                //return the private data member 
                return mAllBatchProductions;
            }
            // setter accepts data from other objets 
            set
            {
                //assign th eincoming vlue to the private data meber 
                mAllBatchProductions = value;
            }
        }

        public clsBatchProductionCollection()
        {
            //create an instance of the batch production class to store a batch production 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored prodecure 
            DB.Execute("sproc_tblBatchProduction_SelectAll");
            //get the count of records 
            Int32 RecordCount = DB.Count;
            //setup index for loop 
            Int32 Index = 0;
            while (Index < RecordCount)
            {
                //create a new instance of the batch pro class 
                clsBatchProduction ABatchProduction = new clsBatchProduction();
                //get batch production name 
                ABatchProduction.BatchProduction = DB.DataTable.Rows[Index]["BatchProduction"].ToString(); 
                //get the batch produicton name 
                ABatchProduction.BatchProductionNo = Convert.ToInt32(DB.DataTable.Rows[Index]["BatchProductionNo"]);
                //add the batc production to the privat edta member 
                mAllBatchProductions.Add(ABatchProduction);
                //increment the index 
                Index++;
            }

        }
    }
} 