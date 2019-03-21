using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsCarCollection
    {
        //private data member for the list
        List<clsCar> mCarList = new List<clsCar>();
        //private data member thisCar
        clsCar mThisCar = new clsCar();

        //public property for the car list
        public List<clsCar> CarList
        {
            get
            {
                //return the private data
                return mCarList;
            }
            set
            {
                //set the private data
                mCarList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCarList.Count;
            }
            set
            {
                //we shall worry about this latter
            }
        }

        //public property for ThisCar
        public clsCar ThisCar
        {
            get
            {
                //return the private data
                return mThisCar;
            }
            set
            {
                //set the private data
                mThisCar = value;
            }
        }

        //constructor for the class
        public clsCarCollection()
        {
            //object for the data Connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCar_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a new record to the database based on the values of mThisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarName", mThisCar.CarName);
            DB.AddParameter("@Model", mThisCar.Model);
            DB.AddParameter("@BodyType", mThisCar.BodyType);
            DB.AddParameter("@ColourNo", mThisCar.ColourNo);
            DB.AddParameter("@Price", mThisCar.Price);
            DB.AddParameter("@Stock", mThisCar.Stock);
            DB.AddParameter("@Fuel", mThisCar.Fuel);
            DB.AddParameter("@YearMade", mThisCar.YearMade);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCar_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("CarID", mThisCar.CarID);
            //execute the store procedure
            DB.Execute("sproc_tblCar_Delete");
        }

        public void Update()
        {
            //Update a existing record to the database based on the values of thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarID", mThisCar.CarID);
            DB.AddParameter("@CarName", mThisCar.CarName);
            DB.AddParameter("@Model", mThisCar.Model);
            DB.AddParameter("@BodyType", mThisCar.BodyType);
            DB.AddParameter("@ColourNo", mThisCar.ColourNo);
            DB.AddParameter("@Price", mThisCar.Price);
            DB.AddParameter("@Stock", mThisCar.Stock);
            DB.AddParameter("@Fuel", mThisCar.Fuel);
            DB.AddParameter("@YearMade", mThisCar.YearMade);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_Update");
        }

        public void ReportByModel(string Model)
        {
            //filters the records based on a full or partial model
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the model parameter to the database
            DB.AddParameter("@Model", Model);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_FilterByModel");
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
            mCarList = new List<clsCar>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank car
                clsCar ACar = new clsCar();
                //read in the field from the current record
                ACar.Fuel = Convert.ToBoolean(DB.DataTable.Rows[Index]["Fuel"]);
                ACar.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                ACar.ColourNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ColourNo"]);
                ACar.CarName = Convert.ToString(DB.DataTable.Rows[Index]["CarName"]);
                ACar.Model = Convert.ToString(DB.DataTable.Rows[Index]["Model"]);
                ACar.BodyType = Convert.ToString(DB.DataTable.Rows[Index]["BodyType"]);
                ACar.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                ACar.Stock = Convert.ToInt32(DB.DataTable.Rows[Index]["Stock"]);
                ACar.YearMade = Convert.ToDateTime(DB.DataTable.Rows[Index]["YearMade"]);
                mCarList.Add(ACar);
                //point at the next record
                Index++;
            }
        }

    }
}