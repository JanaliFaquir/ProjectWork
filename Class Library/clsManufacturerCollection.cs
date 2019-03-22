using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsManufacturerCollection
    {

        List<clsManufacturer> mManufacturerList;
        //private data member thismanufacturer 
        clsManufacturer mThisManufacturer = new clsManufacturer();

        public List<clsManufacturer> ManufacturerList
        {
            get
            {
                //return the private data 
                return mManufacturerList;
            }
            set
            {
                //set the private data 
                mManufacturerList = value;
            }
        }

        //public property for count 
        public int Count
        {
            get
            {
                //return the count of the list 
                return mManufacturerList.Count;
            }
            set
            {
                //we shall worry about this later 
            }
        }

        public clsManufacturer ThisManufacturer
        {
            get
            {
                //return the private data 
                return mThisManufacturer;
            }
            set
            {
                //set the private data 
                mThisManufacturer = value;
            }
        }


        //constructor for the class
        public clsManufacturerCollection()
        {
            //object for the data Connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblManufacturer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    


        public int Add()
        {
            //adds a new record to the dtaabase based on the values of thisManufacturer 
            // connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //SET the paarameters for the stored procedure 
            DB.AddParameter("@YearMade", mThisManufacturer.YearMade);
            DB.AddParameter("@Email", mThisManufacturer.Email);
            DB.AddParameter("@Available", mThisManufacturer.Available);
            DB.AddParameter("@BatchProductionNo", mThisManufacturer.BatchProductionNo);
            DB.AddParameter("@ChairMan", mThisManufacturer.ChairMan);
            DB.AddParameter("@PhoneNo", mThisManufacturer.PhoneNo);
            DB.AddParameter("@CarModel", mThisManufacturer.CarModel);
            // execute query 
            return DB.Execute("sproc_tblManufacturer_Insert");
        }

        public void DeleteManufacturer()
        {
            //deletes the record pointed by thisManufacturer
            //connect to thedatabase 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@ManufacturerID", mThisManufacturer.ManufacturerID);
            //execute the stored procedure 
            DB.Execute("sproc_tblManufacturer_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thismanufacturer 
            //commect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@YearMade", mThisManufacturer.YearMade);
            DB.AddParameter("@Email", mThisManufacturer.Email);
            DB.AddParameter("@Available", mThisManufacturer.Available);
            DB.AddParameter("@BatchProductionNo", mThisManufacturer.BatchProductionNo);
            DB.AddParameter("@ChairMan", mThisManufacturer.ChairMan);
            DB.AddParameter("@PhoneNo", mThisManufacturer.PhoneNo);
            DB.AddParameter("@CarModel", mThisManufacturer.CarModel);
            DB.AddParameter("@ManufacturerID", mThisManufacturer.ManufacturerID);
            // execute query 
            DB.Execute("sproc_tblManufacturer_Update");
        }

        public void ReportByEmail(string Email)
        {
            //filters the records based on a full or partial model
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the model parameter to the database
            DB.AddParameter("@Email", Email);
            //execute the stored procedure
            DB.Execute("sproc_tblManufacturer_FilterByEmail");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mManufacturerList = new List<clsManufacturer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank manufacturer
                clsManufacturer AnManufacturer = new clsManufacturer();
                //read in the field from the current record
                AnManufacturer.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AnManufacturer.ManufacturerID = Convert.ToInt32(DB.DataTable.Rows[Index]["ManufacturerID"]);
                AnManufacturer.BatchProductionNo = Convert.ToInt32(DB.DataTable.Rows[Index]["BatchProductionNo"]);
                AnManufacturer.ChairMan = Convert.ToString(DB.DataTable.Rows[Index]["ChairMan"]);
                AnManufacturer.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                AnManufacturer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnManufacturer.PhoneNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneNo"]);
                AnManufacturer.YearMade = Convert.ToDateTime(DB.DataTable.Rows[Index]["YearMade"]);
                mManufacturerList.Add(AnManufacturer);
                //point at the next record
                Index++;
            }
        }
        
    }
}
