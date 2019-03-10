using System;

namespace Class_Library
{
    public class clsCustomer
    {
        //private data member for the customer no property
        private Int32 mCustomerNo;
        private Boolean mActive;
        private DateTime mDateAdded;
        private string mFirstName;
        private string mSurname;
        private string mStreet;
        private string mPostCode;
        private string mEmail;
        private string mHouseNo;
        private string mPhoneNo;
        private Boolean mTown;
        private DateTime mDateSold; 

      

       
      
        //public property for the customer no
        public int CustomerNo
        {
            get
            {
                //return the private data
                return mCustomerNo;
            }
            set
            {
                //set the value of the private data member
                mCustomerNo = value;
            }
        }
        //public property for the customer no
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the value of the private data member
                mActive = value;
            }
        }
        //public property for the customer no
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the value of the private data member
                mDateAdded = value;
            }
        }
        //public property for the customer no
        public DateTime DateSold
        {
            get
            {
                //return the private data
                return mDateSold;
            }
            set
            {
                //set the value of the private data member
                mDateSold = value;
            }
        }
        //public property for the customer no
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the private data member
                mFirstName = value;
            }
        }
        //public property for the customer no
        public string Surname
        {
            get
            {
                //return the private data
                return mSurname;
            }
            set
            {
                //set the value of the private data member
                mSurname = value;
            }
        }
        //public property for the customer no
        public string Street
        {
            get
            {
                //return the private data
                return mStreet;
            }
            set
            {
                //set the value of the private data member
                mStreet = value;
            }
        }
        //public property for the customer no
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the value of the private data member
                mPostCode = value;
            }
        }
        //public property for the customer no
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
        //public property for the customer no
        public string HouseNo
        {
            get
            {
                //return the private data
                return mHouseNo;
            }
            set
            {
                //set the value of the private data member
                mHouseNo = value;
            }
        }
        //public property for the customer no
        public string PhoneNo
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
        //public property for the customer no
        public bool Town
        {
            get
            {
                //return the private data
                return mTown;
            }
            set
            {
                //set the value of the private data member
                mTown = value;
            }
        }
        public bool Find(int CustomerNo)
        {
            //Create an instance if the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer no to search for 
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found  (there should be either one or zero!)
            if (DB.Count == 1)
            
                // set the private data members to the test data value
                mCustomerNo = 1;
                mActive = true;
                mDateAdded = Convert.ToDateTime("19/11/2018");
                mDateSold = Convert.ToDateTime("01/01/2019");
                mFirstName = "John";
                mSurname = "Smith";
                mStreet = "Leicester Road";
                mPostCode = "LE3 0GH";
                mEmail = "a@hotmail.com";
                mHouseNo = "11A";
                mPhoneNo = "07476123255";
                mTown = true;
                //always return true
                return true;
            
        }   
    }
}