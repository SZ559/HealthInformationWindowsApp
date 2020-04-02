using System;
using System.Collections.Generic;
using System.IO;
using EmployeeInformation;

namespace DatabaseOperation
{
    public class Add
    {
        public static bool AddNewPersonToDataBase(SLBHealthRecord myHealRecord, string myInput)
        {
            try
            {
                string[] myInputArray = myInput.Split(',');
                int myGinNumber = FormatValidator.CheckGinNumber(myInputArray[0]);
                string myName = FormatValidator.CheckName(myInputArray[1]);
                bool myVisit = FormatValidator.CheckVisitHubei(myInputArray[2]);
                bool myAbnormalSymptom = FormatValidator.CheckAbnormalSymptom(myInputArray[3]);
                double myTemperature = FormatValidator.CheckTemperature(myInputArray[4]);
                Person myPerson = new Person(myGinNumber, myName, myVisit, myAbnormalSymptom, myTemperature);

                bool sucessAddToHealthRecord = myHealRecord.Add(myPerson);
                if (sucessAddToHealthRecord == false)
                {
                    Console.WriteLine("Insert Failed! Please Check Whether The Gin Number You Entered is Already in The Health Record.");
                }
                return sucessAddToHealthRecord;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please Check Your Input Information and Enter Again.");
                return false;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid Format! Please Check Your Input and Enter Again.");
                return false;
            }
        }
    }

}