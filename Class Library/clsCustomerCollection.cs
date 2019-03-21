using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsCustomerCollection
    {
        //private data member of the list
        private List<clsCustomer> mCustomerList;
        //Private data member for this address
        clsCustomer mThisCustomer = new clsCustomer();
        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data 
                mThisCustomer = value;
            }
        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count to the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }


        public int Add()
        {
            //add a new record to the database based on the values of ThisCustomer
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //aet the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@Surname", mThisCustomer.Surname);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@DateSold", mThisCustomer.DateSold);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //Delete the record pointed to by thisCustomer
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of this customer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedured
            DB.AddParameter("CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@Surname", mThisCustomer.Surname);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@DateSold", mThisCustomer.DateSold);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByPhoneNo(string PhoneNo)
        {
            //filters the records based on full or partial phone no
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the phone No parameter to the database
            DB.AddParameter("@PhoneNo", PhoneNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByPhoneNo");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        //constructor for the class
        public clsCustomerCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);

            {
                //var for the index
                Int32 Index = 0;
                //var to store the record count 
                Int32 RecordCount = 0;
                //get the count of records
                RecordCount = DB.Count;
                //while there are records to process
                while (Index < RecordCount)
                {
                    //create a blank customer record
                    clsCustomer ACustomer = new clsCustomer();
                    //read the fields from the current record
                    ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                    ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                    ACustomer.DateSold = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateSold"]);
                    ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                    ACustomer.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                    ACustomer.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                    ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                    ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                    ACustomer.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                    ACustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                    ACustomer.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                    //add the record to the private data member
                    mCustomerList.Add(ACustomer);
                    //point at the next record
                    Index++;
                }
            }
        }
        void PopulateArray(clsDataConnection DB)
        {
            //Populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var ti store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list 
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer record
                clsCustomer ACustomer = new clsCustomer();
                //read the fields from the current record
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.DateSold = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateSold"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                ACustomer.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                ACustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                ACustomer.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
    }
}
