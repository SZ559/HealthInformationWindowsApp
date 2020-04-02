using System;
using System.Collections.Generic;
using System.IO;
using EmployeeInformation;

namespace DatabaseOperation
{
    public class FormatValidator
    {
        public static int CheckGinNumber(string myInput)
        {
            try
            {
                int myGinNumber = Convert.ToInt32(myInput);
                return myGinNumber;
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Gin Number! The Gin Number must be a valid Integer.");
                throw new ArgumentException("Invalid Gin Number! The Gin Number must be a valid Integer.");
            }
        }

        public static string CheckName(string myInput)
        {

            string myName = myInput;
            if (myName == null)
            {
                Console.WriteLine("Invalid Name! The name cannot be empty.");
                throw new ArgumentException("Invalid Name! The name cannot be empty.");
            }
            return myName;
        }

        public static bool CheckVisitHubei(string myInput)
        {

            if (myInput.ToLower() == "y")
            {
                return true;
            }
            else if (myInput.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Input of Visit Hubei or Not. The Input Must Be Y or N.");
                throw new ArgumentException("Invalid Input of Visit Hubei or Not. The Input Must Be Y or N.");
            }
        }

        public static bool CheckAbnormalSymptom(string myInput)
        {
            if (myInput.ToLower() == "y")
            {
                return true;
            }
            else if (myInput.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Input of Abnormal Symptom. The Input Must Be Y or N.");
                throw new ArgumentException("Invalid Input of Abnormal Symptom. The Input Must Be Y or N.");
            }
        }

        public static double CheckTemperature(string myInput)
        {
            double myTemperature = Double.Parse(myInput);
            if (myTemperature > 42 || myTemperature < 35)
            {
                Console.WriteLine("Invalid Input of Temperature. Please Check Again.");
                throw new ArgumentException("Invalid Input of Temperature. Please Check Again.");
            }
            return myTemperature;
        }
    }

}