using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsColour
    {
        //private data member for the colour no property
        private int mColourNo;
        //private data member for the Colour Name property
        private string mColourName;

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
        public string ColourName
        {
            get
            {
                //return the private data
                return mColourName;
            }
            set
            {
                //set the private data
                mColourName = value;
            }
        }

        public string Valid(string someColourName)
        {
            //sttring variable to store the error message
            string Error = "";
            //if the name of the colour is more than 16
            if (someColourName.Length > 50)
            {
                //return an error message
                Error = "the colour name cannot be more than 16 characters";
            }
            if (someColourName.Length == 0)
            {
                //return an error message
                Error = "the colour name may not be blank!";
            }
            return Error;
        }

        public bool Find(int colourNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the colour no to search for
            DB.AddParameter("@ColourNo", ColourNo);
            //execute the store procedure
            DB.Execute("sproc_tblColour_FilterByColourNo");
            //if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mColourNo = Convert.ToInt32(DB.DataTable.Rows[0]["ColourNo"]);
                mColourName = Convert.ToString(DB.DataTable.Rows[0]["ColourName"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}