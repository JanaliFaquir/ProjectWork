using System;
using System.Collections.Generic;

namespace Class_Library
{
    public class clsManufacturerCollection
    {
        private List<clsManufacturer> mManufacturerList;

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

        public clsManufacturer ThisManufacturer { get; set; }

    }
}