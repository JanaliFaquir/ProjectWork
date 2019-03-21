using System;

namespace Class_Library
{
    public class clsTown
    {
        public clsTown()
        {
        }

        public string Town { get; set; }
        public int TownNo { get; set; }

        public string Valid(string someTown)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the townia more than 50 characters
            if (someTown.Length> 50)
            {
                //return a error message
                Error = "The town cannot ha e more than 50 characters";
            }
            if (someTown.Length ==0)
            {
                // return an error message
                Error = "The town name may not be blank!";
            }
            return Error;
        }
    }

}