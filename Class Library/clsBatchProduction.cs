using System;

namespace Class_Library
{
    public class clsBatchProduction
    {
       

        public string BatchProduction { get; set; }
        public int BatchProductionNo { get; set; }

        public string Valid(string someBatchProduction)
        {
            //if the name of the batch production is not blank 
            String Error = ""; 
            // if the batch production name is mor ethan 50 characters 
            if (someBatchProduction.Length > 50)
            {
                //return a b;ank string 
                Error = "The Batch Production cannoy have more than 50 characters";
            }
            if (someBatchProduction.Length == 0)
            {
                //return an error msg 
                Error = "The Batch Production name cannot have more than 50 characters";

            }
            return Error;
        } 

    }
}