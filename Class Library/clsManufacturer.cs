using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsManufacturer
    {
        //private data member for the Available property 
        private Boolean mAvailable;
        //private data member for the yearmade property
        private DateTime mYearMade;
        //private data member for the manufacturerid property
        private Int32 mManufacturerID;
        //private data member for the batchproductionno property
        private Int32 mBatchProductionNo;
        //private data member for the phoneno property
        private Int32 mPhoneNo;
        //private data member for the carmodel property
        private String mCarModel;
        //private data member for the chairman property
        private String mChairMan;
        //private data member for the email property
        private String mEmail;
        private DateTime DateTemp;

        //public bool Available { get; set; }
        // public DateTime YearMade { get; set; }
        //public int ManufacturerID { get; set; }
        // public int BatchProductionNo { get; set; }
        //public int PhoneNo { get; set; }
        // public string CarModel { get; set; }
        //public string ChairMan { get; set; }
        // public string Email { get; set; }

        public bool Find(int manufacturerID)
        {
            // create an instance of the data connection

            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the manufacturer id to search for
            DB.AddParameter("@ManufacturerID", manufacturerID);
            // execute the stored procedure 
            DB.Execute("sproc_tblManufacturer_FilterByManufacturerID");
            // if one record is founnd (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data form the database to the privae data members 
                mManufacturerID = Convert.ToInt32(DB.DataTable.Rows[0]["ManufacturerID"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mYearMade = Convert.ToDateTime(DB.DataTable.Rows[0]["YearMade"]);
                mBatchProductionNo = Convert.ToInt32(DB.DataTable.Rows[0]["BatchProductionNo"]);
                mPhoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNo"]);
                mCarModel = Convert.ToString(DB.DataTable.Rows[0]["CarModel"]);
                mChairMan = Convert.ToString(DB.DataTable.Rows[0]["ChairMan"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                //return that everything worked ok 
                return true;
            }
            //if no record was found 
            else
            {
                //return alse indicating a problem 
                return false;
            }

        }

        // public property for the manufacturer id 
        public int ManufacturerID
        {
            get
            {
                //return the private data
                return mManufacturerID;
            }
            set
            {
                //set the value of the private data member
                mManufacturerID = value;
            }
        }

        // public property for the available
        public bool Available
        {
            get
            {
                //return the private data
                return mAvailable;
            }
            set
            {
                //set the value of the private data member
                mAvailable = value;
            }
        }

        // public property for the yearmade
        public DateTime YearMade
        {
            get
            {
                //return the private data
                return mYearMade;
            }
            set
            {
                //set the value of the private data member
                mYearMade = value;
            }
        }

        public int BatchProductionNo
        {
            get
            {
                //return the private data 
                return mBatchProductionNo;
            }
            set
            {
                //set the value of the private data member 
                mBatchProductionNo = value;
            }
        }

        public int PhoneNo
        {
            get
            {
                //return the private data 
                return mPhoneNo;
            }
            set
            {
                //set the value of the private data member 
                mPhoneNo = value;
            }
        }

        public string CarModel
        {
            get
            {
                //return the private data 
                return mCarModel;
            }
            set
            {
                //set the value of the private data member 
                mCarModel = value;
            }
        }

        public string ChairMan
        {
            get
            {
                //return the private data 
                return mChairMan;
            }
            set
            {
                //set the value of the private data member 
                mChairMan = value;
            }
        }

        public string Email
        {
            get
            {
                //return the private data 
                return mEmail;
            }
            set
            {
                //set the value of the private data member 
                mEmail = value;
            }
        }



        public string Valid(string carModel, string chairMan, string email, string yearMade)
        {
            //create a string variable to store the error 
            string Error = "";
            //if the CarModel is blank 
            if (carModel.Length == 0)
            {
                //record the error 
                Error = Error + "The car model may not be blank : ";
            }
            // if the carmodel is greater than 25 characters 
            if (carModel.Length > 25)
            {
                Error = Error + "The carModel must be less than 25 caharcters : ";
            }
            try
            {
                //copy the yearMade value to the datetemp variable 
                DateTemp = Convert.ToDateTime(yearMade);
                if (DateTemp < DateTime.Now.Date)
                {
                    // record the error 
                    Error = Error + "The date cannot be in the past";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    // record the error
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date was not a valid date:";
            }
            //is the chairman blank 
            if (chairMan.Length == 0)
            {
                //record the error 
                Error = Error + "The chairman may not be blank : ";
            }
            // if the chairman is greater than 35 characters 
            if (chairMan.Length > 35)
            {
                Error = Error + "The chairman must be less than 35 caharcters : ";
            }
            //is the email blank 
            if (email.Length == 0)
            {
                //record the error 
                Error = Error + "The email may not be blank : ";
            }
            // if the email is greater than 50 characters 
            if (email.Length > 50)
            {
                Error = Error + "The chairman must be less than 50 caharcters : ";
            }
            // return any error messages 
            return Error;


        }

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

        public List<clsManufacturer> mManufacturerList { get; private set; }


    }


}


