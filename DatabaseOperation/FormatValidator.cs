using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using EmployeeHealthRecord;

namespace DatabaseOperation
{
    public class FormatValidator
    {
        public bool HasFormatError_GinNumber(string myInput)
        {
            int test;
            return !(int.TryParse(myInput, out test) && test > 0);
        }
        public bool HasFormatError_Name(string myInput)
        {
            if (myInput != String.Empty)
            {
                return false;
            }
            return true;
        }
        public bool HasFormatError_Date(string myInput)
        {
            DateTime test;
            if (DateTime.TryParse(myInput, out test))
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
            return !bool.TryParse(myInput, out test);
        }
        public bool HasFormatError_HasAbnormalSymptom(string myInput)
        {
            //if (myInput.ToLower() == "y" || myInput.ToLower() == "n")
            bool test;
            return !bool.TryParse(myInput, out test);
        }
        public string CheckFormatError_InputString(string myInput)
        {
            string formatErrorMessage = "";
            if (!myInput.Contains(","))
            {
                return "Format Error";
            }
            string[] myInputArray = myInput.Split(',');

            if (myInputArray.Length != 7)
            {
                return "FormatError";
            }
            if (HasFormatError_GinNumber(myInputArray[0]))
            {
                formatErrorMessage = formatErrorMessage + "Invalid Gin Number! The Gin Number must be a valid positive Integer! ";
            }
            if (HasFormatError_Name(myInputArray[1]) && (HasFormatError_Name(myInputArray[2])))
            {
                formatErrorMessage = formatErrorMessage + "Invalid Name! The Name cannot be empty! ";
            }
            if (HasFormatError_Date(myInputArray[3]))
            {
                formatErrorMessage = formatErrorMessage + "Invalid Date! ";
            }
            if (HasFormatError_VisitHubei(myInputArray[4]))
            {
                formatErrorMessage = formatErrorMessage + "Invalid Visited Hubei Recently!";
            }   
            if (HasFormatError_HasAbnormalSymptom(myInputArray[5]))
            {
                formatErrorMessage = formatErrorMessage + "Invalid Has Abnormal Symptom!";
            }
            if (HasFormatError_Temperature(myInputArray[6]))
            {
                formatErrorMessage = formatErrorMessage + "Invalid Temperature!";
            }
            return formatErrorMessage;
        }
    }
}