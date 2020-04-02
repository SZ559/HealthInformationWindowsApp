using System;
using System.Collections.Generic;
using System.IO;
using EmployeeInformation;

namespace WindowsFormsApp6
{
    public class FormatValidator
    {
        public bool FindError_ID(string myInput)
        {
            int test;
            if (Int32.TryParse(myInput, out test))
            {
                return false;
            }
            return true;
        }

        public bool FindError_Name(string myInput)
        {
            if (myInput != String.Empty)
            {
                return false;
            }
            return true;
        }

        public bool FindError_Temperature(string myInput)
        {
            double test;
            if (Double.TryParse(myInput, out test))
            {
                double myTemperature = Double.Parse(myInput);
                if (myTemperature <= 42 && myTemperature >= 35)
                {
                    return false;
                }
            }
            return true;
        }
    }

}