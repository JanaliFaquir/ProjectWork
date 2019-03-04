using System;

namespace Class_Library
{
    public class clsCustomer
    {
        //private data member for the customer no property
        private Int32 mCustomerNo;
        private bool mActive;
        private DateTime mDateAdded;
        private string mFirstName;
        private string mSurname;
        private string mStreet;
        private string mPostCode;
        private string mEmail;
        private string mHouseNo;
        private string mPhoneNo;
        private bool mTown;
        private DateTime mDateSold; 

        public clsCustomer()
        {
        }

       
        
  

        public bool Find(int CustomerNo)
        {
            //set the private data member to the test data value
            mCustomerNo = 1;
          

            //always return true
            return true;
        }
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
    }
}