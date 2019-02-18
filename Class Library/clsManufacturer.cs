using System;

namespace Class_Library
{
    public class clsManufacturer
    {
        public bool Active { get; set; }
        public bool Available { get; set; }
        public DateTime YearMade { get; set; }
        public int ManufacturerID { get; set; }
        public int BatchProductionNo { get; set; }
        public int PhoneNo { get; set; }
        public string CarModel { get; set; }
        public string ChairMan { get; set; }
        public string Email { get; set; }
        public bool Find(int ManufacturerID)
        { //always return true 
            return true;

        }
    }
   
}