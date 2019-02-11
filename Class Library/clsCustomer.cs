using System;

namespace Class_Library
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerNo { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public string HouseNo { get; set; }
        public string PhoneNo { get; set; }
        public bool Town { get; set; }
        public DateTime DateSold { get; set; }

        public bool Find(int CustomerNo)
        {
            //always return true
            return true;
        }
    }
}