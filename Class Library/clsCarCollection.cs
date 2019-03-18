using System.Collections.Generic;

namespace Class_Library
{
    public class clsCarCollection
    {
        //private data member for the list
        List<clsCar> mCarList = new List<clsCar>();

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
        public clsCar ThisCar { get; set; }

    }
}