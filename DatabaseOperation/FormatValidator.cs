using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using EmployeeInformation;

namespace DatabaseOperation
{
    public class FormatValidator
    {
        public bool HasFormatError_GinNumber(string myInput)
        {
            int test;
            if (Int32.TryParse(myInput, out test))
            {
                if (Int32.Parse(myInput) >= 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool HasFormatError_Name(string myInput)
        {
            if (myInput != String.Empty)
            {
                return false;
            }
            return true;
        }

        public bool HasFormatError_Temperature(string myInput)
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

        public bool HasFormatError_VisitHubei(string myInput)
        {
            //if (myInput.ToLower() == "y" || myInput.ToLower() == "n")
            bool test;
            if (bool.TryParse(myInput, out test))
            {
                return false;
            }
            return true;
        }

        public bool HasFormatError_HasAbnormalSymptom(string myInput)
        {
            //if (myInput.ToLower() == "y" || myInput.ToLower() == "n")
            bool test;
            if (bool.TryParse(myInput, out test))
            {
                return false;
            }
            return true;
        }

        public string CheckFormatError_InputString(string myInput)
        {
            string formatErrorMessage = "";
            if (!myInput.Contains(","))
            {
                return "Format Error";
            }
            string[] myInputArray = myInput.Split(',');

            if (myInputArray.Length != 5)
            {
                return "FormatError";
            }
            if (HasFormatError_GinNumber(myInputArray[0]) == true)
            {
                formatErrorMessage = formatErrorMessage + "Invalid Gin Number! The Gin Number must be a valid positive Integer! ";
            }
            if (HasFormatError_Name(myInputArray[1]) == true)
            {
                formatErrorMessage = formatErrorMessage + "Invalid Name! The Name cannot be empty! ";
            }

            if (HasFormatError_VisitHubei(myInputArray[2]) == true)
            {
                formatErrorMessage = formatErrorMessage + "Invalid Visited Hubei Recently!";
            }
            
            if (HasFormatError_HasAbnormalSymptom(myInputArray[3]) == true)
            {
                formatErrorMessage = formatErrorMessage + "Invalid Has Abnormal Symptom!";
            }
            if (HasFormatError_Temperature(myInputArray[4]) == true)
            {
                formatErrorMessage = formatErrorMessage + "Invalid Temperature!";
            }
            return formatErrorMessage;
        }
    }

}