using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace Class_Library
{
    public class clsManufacturer
    {
        //private data member for the Available property 
        private Boolean mAvailable;
        //private data member for the yearmade property
        private DateTime mYearMade;
        //private data member for the manufacturerid property
        private Int32 ManufacturerID;
       //private data member for the batchproductionno property
        private Int32 BatchProductionNo;
       //private data member for the phoneno property
        private Int32 PhoneNo;
       //private data member for the carmodel property
        private String CarModel;
        //private data member for the chairman property
        private String ChairMan;
        //private data member for the email property
         private String Email;
        public bool Find(int ManufacturerID)
        { //always return true 
            return true;

        }
    }
   
}