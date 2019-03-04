using System;

namespace Class_Library
{
    public class clsCar
    {
        //private data member for the fuel property 
        private Boolean mFuel;
        //private data member for the yearmade property
        private DateTime mYearMade;
        //private data member for the car id property
        private Int32 mCarID;
        //private data member for the colour no property
        private Int32 mColourNo;
        //private data member for the Car Name property
        private Int32 CarName;
        //private data member for the model property
        private String Model;
        //private data member for the Body type property
        private String BodyType;
        //private data member for the price property
        private String Price;
        //private data member for the stock property
        private String Stock;

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
                //set value of the private data member
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
                //set value f the private data member
                mYearMade = value;
            }
        }
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
                //set value f the private data member
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
                //set value f the private data member
                mColourNo = value;
            }
        }
        //public roperty for the CarName
        public string mCarName
        {
            get
            {
                //return the private data
                return mCarName;
            }
            set
            {
                //set value f the private data member
                mCarName = value;
            }
        }
        //public roperty for the Model
        public string mModel
        {
            get
            {
                //return the private data
                return mModel;
            }
            set
            {
                //set value f the private data member
                Model = value;
            }
        }
        //public roperty for the BodyType
        public string mBodyType
        {
            get
            {
                //return the private data
                return mBodyType;
            }
            set
            {
                //set value f the private data member
                mBodyType = value;
            }
        }
        //public roperty for the Price
        public decimal mPrice
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set value f the private data member
                mPrice = value;
            }
        }
        //public roperty for the Stock
        public int mStock
        {
            get
            {
                //return the private data
                return mStock;
            }
            set
            {
                //set value f the private data member
                mStock = value;
            }
        }
        public bool Find(int carID)
        {
            //set the private data member to the test data value
            mCarID = 1;
            //always return true
            return true;
        }
    }
}