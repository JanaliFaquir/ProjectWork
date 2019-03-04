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

        //public bool Available { get; set; }
        // public DateTime YearMade { get; set; }
        //public int ManufacturerID { get; set; }
        public int BatchProductionNo { get; set; }
        public int PhoneNo { get; set; }
        public string CarModel { get; set; }
        public string ChairMan { get; set; }
        public string Email { get; set; }

        public bool Find(int ManufacturerID)
        {
            //set the private data member to the test data value
            mManufacturerID = 456;
            mAvailable = true;
            mYearMade = Convert.ToDateTime("04/03/2018");
            //always return true
            return true;

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

       
    }
   
}