using System;
 
namespace Class_Library
{
    public class clsCar
    {
        //private data member for the car id property
        private int mCarID;
        //private data member for the colour no property
        private int mColourNo;
        //private data member for the Car Name property
        private string mCarName;
        //private data member for the model property
        private string mModel;
        //private data member for the Body type property
        private string mBodyType;
        //private data member for the price property
        private decimal mPrice;
        //private data member for the stock property
        private int mStock;
        //private data member for the fuel property 
        private Boolean mFuel;
        //private data member for the yearmade property
        private DateTime mYearMade;

        //public property for the CarID
        public int CarID
        {
            get
            {
                //return the private data
                return mCarID;
            }
            set
            {
                //set value of the private data member
                mCarID = value;
            }
        }
        //public roperty for the ColourNo
        public int ColourNo
        {
            get
            {
                //return the private data
                return mColourNo;
            }
            set
            {
                //set the private data
                mColourNo = value;
            }
        }
        //public roperty for the CarName
        public string CarName
        {
            get
            {
                //return the private data
                return mCarName;
            }
            set
            {
                //set the private data
                mCarName = value;
            }
        }
        //public roperty for the Model
        public string Model
        {
            get
            {
                //return the private data
                return mModel;
            }
            set
            {
                //set the private data
                mModel = value;
            }
        }
        //public roperty for the BodyType
        public string BodyType
        {
            get
            {
                //return the private data
                return mBodyType;
            }
            set
            {
                //set the private data
                mBodyType = value;
            }
        }
        //public roperty for the Price
        public decimal Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }
        //public roperty for the Stock
        public int Stock
        {
            get
            {
                //return the private data
                return mStock;
            }
            set
            {
                //set the private data
                mStock = value;
            }
        }
        //public roperty for the fuel
        public bool Fuel
        {
            get
            {
                //return the private data
                return mFuel;
            }
            set
            {
                //set the private data
                mFuel = value;
            }
        }
        //public roperty for the YearMade
        public DateTime YearMade
        {
            get
            {
                //return the private data
                return mYearMade;
            }
            set
            {
                //set the private data
                mYearMade = value;
            }
        }
        public bool Find(int CarID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the adress no to search for
            DB.AddParameter("@CarID", CarID);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_FilterByCarID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                mCarName = Convert.ToString(DB.DataTable.Rows[0]["CarName"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["Model"]);
                mBodyType = Convert.ToString(DB.DataTable.Rows[0]["BodyType"]);
                mColourNo = Convert.ToInt32(DB.DataTable.Rows[0]["ColourNo"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mStock = Convert.ToInt32(DB.DataTable.Rows[0]["Stock"]);
                mYearMade = Convert.ToDateTime(DB.DataTable.Rows[0]["YearMade"]);
                mFuel = Convert.ToBoolean(DB.DataTable.Rows[0]["Fuel"]);
                //return that everything is ok
                return true;
            }
            //if no record of found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string carName, string model, string bodyType, string yearMade)
        {
            //create a string variable to store the erroe
            String Error = "";
            //create a temporary ariable to store date values
            DateTime DateTemp;
            //if the CarName is blank
            if (carName.Length == 0)
            {
                //record the error
                Error = Error + "The Car Name may not be blank : ";
            }
            //if the car name is greater than 10 characters
            if (carName.Length > 10)
            {
                //record the error
                Error = Error + "The car name must be less than 10 characters : ";
            }
            try
            {
                //copy the yearMade value to the DateTemp variable
                DateTemp = Convert.ToDateTime(yearMade);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date :";
            }
            //is the model blank
            if (model.Length == 0)
            {
                //record the error
                Error = Error + "The model may not be blank : ";
            }
            //if model is too long
            if (model.Length > 25)
            {
                //record the error
                Error = Error + "The model must be less than 25 characters : ";
            }
            //is the bodyType blank
            if (bodyType.Length == 0)
            {
                //record the error
                Error = Error + "The body type may not be blank : ";
            }
            //if bodyType is too long
            if (bodyType.Length > 20)
            {
                //record the error
                Error = Error + "The body type must be less than 20 characters : ";
            }
            //return any error messages
            return Error;
        }

    }
}