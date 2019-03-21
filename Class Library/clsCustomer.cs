using System;

namespace Class_Library
{
    public class clsCustomer
    {
        //private data member for the customer no property
        private Int32 mCustomerNo;
        private Boolean mActive;
        private string mFirstName;
        private string mSurname;
        private string mStreet;
        private string mPostCode;
        private string mEmail;
        private string mHouseNo;
        private string mPhoneNo;
        private string mTown;
        private DateTime mDateSold;
        private DateTime DateTemp;


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
        public string Town
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
            {
                //copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDateSold = Convert.ToDateTime(DB.DataTable.Rows[0]["DateSold"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                //return that everyhting worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }


        public string Valid(string firstName, string surname, string street, string postCode, string email, string houseNo, string phoneNo, string dateSold)
        {
            //create a string variable to store the error
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //if the FirstName is blank 
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "First Name may not be blank:";
            }
            //if the First name is greater than 50
            if (firstName.Length > 50)
            {
                //record the error 
                Error = Error + "The First Name must be less than 50 characters";
            }
            try
            {
                //copy the date added value to the Date temp variable
                DateTemp = Convert.ToDateTime(dateSold);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error message
                    Error = Error + "The date cannot be in the past:";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }
            //is the postcode blank
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + "The Post Code may not be blank :";
            }
            //if the postcode is too long
            if (postCode.Length > 9)
            {
                //record the error
                Error = Error + "The Post Code must be less than 9 characters :";
            }
            //is the Street blank
            if (street.Length == 0)
            {
                //record the error
                Error = Error + "The Street may not be blank :";
            }
            //if the Street is too long
            if (street.Length > 50)
            {
                //record the error
                Error = Error + "The Street must be less than 50 characters :";
            }
            //is the Email blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank :";
            }
            //if the Email is too long
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The Email must be less than 50 characters :";
            }
            //is the Email blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank :";
            }
            //if the Email is too long
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The Email must be less than 50 characters :";
            }
            //is the Surname blank
            if (surname.Length == 0)
            {
                //record the error
                Error = Error + "The Surname may not be blank :";
            }
            //if the Surname is too long
            if (surname.Length > 50)
            {
                //record the error
                Error = Error + "The Surname must be less than 50 characters :";
            }
            //is the PhoneNo blank
            if (phoneNo.Length == 0)
            {
                //record the error
                Error = Error + "The PhoneNo may not be blank :";
            }
            //if the postcode is too long
            if (phoneNo.Length > 11)
            {
                //record the error
                Error = Error + "The PhoneNo must be less than 11 characters :";
            }
            //is the postcode blank
            if (houseNo.Length == 0)
            {
                //record the error
                Error = Error + "The HouseNo may not be blank :";
            }
            //if the postcode is too long
            if (houseNo.Length > 6)
            {
                //record the error
                Error = Error + "The HouseNo must be less than 6 characters :";
            }

            //return any error message
            return Error;
        }
    }

}

