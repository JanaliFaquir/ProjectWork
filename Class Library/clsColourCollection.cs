using System;
using System.Collections.Generic;
namespace Class_Library
{
    public class clsColourCollection
    {
        //private data member for the allcolours list
        private List<clsColour> mAllColours = new List<clsColour>();

        //public property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllColours.Count;
            }
            set
            {
                //we will look at this in a moment!
            }
        }

        //public property for AllColours
        public List<clsColour> AllColours
        {
            //getter sends the data to requesting code
            get
            {
                //return the private data member
                return mAllColours;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllColours = value;
            }
        }

        //public constructor for the class
        public clsColourCollection()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure to get the list of data
            DB.Execute("sproc_tblColour_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create an instance of the colour clss to store a colour
                clsColour AColour = new clsColour();
                //get the colour name
                AColour.ColourName = DB.DataTable.Rows[Index]["ColourName"].ToString();
                //get the primary key
                AColour.ColourNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ColourNo"]);
                //add the second colour to the private list of colours
                mAllColours.Add(AColour);
                //increment the index
                Index++;
            }
        }
    }
}