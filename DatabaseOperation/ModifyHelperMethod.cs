using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOperation;
using EmployeeInformation;

namespace DatabaseOperation
{
    public class ModifyHelperMethod
    { 
        public static bool ModifyGinNumberInPerson(HealthDatabase myHealthRecord, int myGinNumber, int newGinNumber)
        {
            Person myPerson = myHealthRecord.OneDayHealthRecord[myGinNumber];
            myPerson.GinNumber = newGinNumber;
            if (myHealthRecord.DeletePerson(myGinNumber) == true && myHealthRecord.AddNewPerson(myPerson) == true)
            {
                return true;
            }
            return false;
        }
        public static void  ModifyNameInPerson(HealthDatabase myHealthRecord, int myGinNumber, string myNewName)
        {
            myHealthRecord.OneDayHealthRecord[myGinNumber].Name = myNewName;
        }
        public static void ModifyVisitHubeiInPerson(HealthDatabase myHealthRecord, int myGinNumber, bool myNewVisit)
        {
            myHealthRecord.OneDayHealthRecord[myGinNumber].VisitHubei = myNewVisit;
        }
        public static void ModifyHasAbnormalSymptomInPerson(HealthDatabase myHealthRecord, int myGinNumber, bool myNewAbnormalSymptom)
        {
            myHealthRecord.OneDayHealthRecord[myGinNumber].HasAbnormalSymptom = myNewAbnormalSymptom;
        }
        public static void ModifyTemperatureInPerson(HealthDatabase myHealthRecord, int myGinNumber, double myNewTemperature)
        {
            myHealthRecord.OneDayHealthRecord[myGinNumber].Temperature = myNewTemperature;
        }

        public static void ModifyGinNumberThroughConsole(HealthDatabase myHealthRecord, int myGinNumber, string newGinNumberString)
        {
            FormatValidator formatvalidator = new FormatValidator();
            if (formatvalidator.HasFormatError_GinNumber(newGinNumberString))
            {
                Console.WriteLine("The Gin Number must be a valid nonnegative integer!");
            }
            else
            {
                int myNewGinNumber = Int32.Parse(newGinNumberString);
                if (ModifyHelperMethod.ModifyGinNumberInPerson(myHealthRecord, myGinNumber, myNewGinNumber) == false)
                {
                    Console.WriteLine("The new Gin Number you entered already exists.");
                }
            }
        }

        public static void ModifyNameThroughConsole(HealthDatabase myHealthRecord, int myGinNumber, string newNameString)
        {
            FormatValidator formatvalidator = new FormatValidator();
            if (formatvalidator.HasFormatError_Name(newNameString))
            {
                Console.WriteLine("The Name cannot be empty!");
            }
            else
            {
                ModifyHelperMethod.ModifyNameInPerson(myHealthRecord, myGinNumber, newNameString);
            }
        }

        public static void ModifyVisitHubeiThroughConsole(HealthDatabase myHealthRecord, int myGinNumber, string newVisitHubeiString)
        {
            FormatValidator formatvalidator = new FormatValidator();
            if (formatvalidator.HasFormatError_VisitHubei(newVisitHubeiString))
            {
                Console.WriteLine("Invalid Input! The input must be True/False");
            }
            else
            {
                bool myNewVisit = bool.Parse(newVisitHubeiString);
                ModifyHelperMethod.ModifyVisitHubeiInPerson(myHealthRecord, myGinNumber, myNewVisit);
            }
        }

        public static void ModifyHasAbnormalSymptomThroughConsole(HealthDatabase myHealthRecord, int myGinNumber, string newAbnormalSymptomString)
        {
            FormatValidator formatvalidator = new FormatValidator();
            if (formatvalidator.HasFormatError_HasAbnormalSymptom(newAbnormalSymptomString))
            {
                Console.WriteLine("Invalid Input! The input must be True/False");
            }
            else
            {
                bool myNewAbnormalSymptom = bool.Parse(newAbnormalSymptomString);
                ModifyHelperMethod.ModifyHasAbnormalSymptomInPerson(myHealthRecord, myGinNumber, myNewAbnormalSymptom);
            }
        }

        public static void ModifyTemperatureThroughConsole(HealthDatabase myHealthRecord, int myGinNumber, string newTemperatureString)
        {
            FormatValidator formatvalidator = new FormatValidator();
            if (formatvalidator.HasFormatError_Temperature(newTemperatureString))
            {
                Console.WriteLine("Invalid Temperature!");
            }
            else
            {
                double myNewTemperature = double.Parse(newTemperatureString);
                ModifyHelperMethod.ModifyTemperatureInPerson(myHealthRecord, myGinNumber, myNewTemperature);
            }
        }
    }

}
