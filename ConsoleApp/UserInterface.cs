using System;
using System.Collections.Generic;
using System.IO;
using EmployeeInformation;
using FileOperation;
using DatabaseOperation;

namespace ConsoleApp
{
    public class UserInterface
    {
        private HealthDatabase myHealthRecord;
        private FormatValidator formatvalidator = new FormatValidator();
        public UserInterface()
        {
            myHealthRecord = new HealthDatabase();
        }

        public void Run()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please type your next step: Import file/Enter/Modify/Delete/PrintAll/PrintAbnormal/Save/Exit");
                Console.ResetColor();
                string nextStep = Console.ReadLine().ToLower();
                switch (nextStep)
                {
                    case "enter":
                        EnterFromConsole();
                        break;
                    case "delete":
                        DeletePersonFromConsole();
                        break;
                    case "modify":
                        ModifyPersonFromConsole();
                        break;
                    case "printall":
                        Print.PrintAll(myHealthRecord);
                        break;
                    case "printabnormal":
                        Print.PrintAbnormal(myHealthRecord);
                        break;
                    case "import file":
                        InputFromFile();
                        break;
                    case "save":
                        SaveFile();
                        break;
                    case "exit":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The Health Record Program is terminated.");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input of Next Step! Please Enter Again.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        public void EnterFromConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the following health information, separated by commas without spaces.");
            Console.WriteLine("GinNumber,Name,Visit Hubei Recently(True/False),Has Abnormal Symptom(True/False),Temperature.(ex. 2003,Shishi Zhang,True,False,36.7)");
            Console.ResetColor();
            string myInput = Console.ReadLine();
            string errorMessage = formatvalidator.CheckFormatError_InputString(myInput);
            if (errorMessage == "")
            {
                Person newPerson = AddPersonHelperMethods.AddNewPerson_ThroughValidString(myInput);
                if (myHealthRecord.AddNewPerson(newPerson))
                {
                    Console.WriteLine("Input Success!");
                }
                else
                {
                    Console.WriteLine("The Gin Number you enetered already exists!");
                }
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }

        public void DeletePersonFromConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please Enter the Gin Number of the Person You Want To Remove From SLB Health Record.");
            Console.ResetColor();
            string myGinNumberString = Console.ReadLine();
            if (formatvalidator.HasFormatError_GinNumber(myGinNumberString) == false)
            {
                int myGinNumber = Int32.Parse(myGinNumberString);
                bool sucessDelete = myHealthRecord.DeletePerson(myGinNumber);
                if (sucessDelete == true)
                {
                    Console.WriteLine("Delete Success!");
                }
                else
                {
                    Console.WriteLine("Delete Failed! Unable to find the Gin Number you entered!");
                }
            }
            else
            {
                Console.WriteLine("The Gin Number must be a valid nonnegative integer!");
            }
        }

        public void ModifyPersonFromConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please Enter the Gin Number of the Person You Want To Modify.");
            Console.ResetColor();
            string myGinNumberString = Console.ReadLine();
            if (formatvalidator.HasFormatError_GinNumber(myGinNumberString) == true)
            {
                Console.WriteLine("The Gin Number must be a valid nonnegative integer!");
                return;
            }

            int myGinNumber = Int32.Parse(myGinNumberString);
            if (!myHealthRecord.HealthRecord.ContainsKey(myGinNumber))
            {
                Console.WriteLine("Unable to find the Gin Number you entered!");
                return;
            }
            while (true)
            {
                Print.PrintPerson(myHealthRecord, myGinNumber);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter the field needed To be modified: Gin Number/Name/Visit Hubei Recently/Has Abnormal Symptom/Temperature");
                Console.ResetColor();

                string fieldNeedToRevise = Console.ReadLine().ToLower();
                ModifyMemberOfPerson(myGinNumber, fieldNeedToRevise);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Revise Aother Field? Press 'Y' to Start Revise Another Field. Press Any Ohter Key to Exit Revise Process.");
                Console.ResetColor();
                if (Console.ReadLine().ToLower() != "y")
                {
                    return;
                }
            }
        }
        public void ModifyMemberOfPerson(int myGinNumber, string fieldNeedToRevise)
        {
            FormatValidator formatvalidator = new FormatValidator();
            switch (fieldNeedToRevise)
            {
                case "gin number":
                    Console.WriteLine("Please Enter the New Gin Number.");
                    string newGinNumberString = Console.ReadLine();
                    ModifyHelperMethod.ModifyGinNumberThroughConsole(myHealthRecord, myGinNumber, newGinNumberString);
                    break;

                case "name":
                    Console.WriteLine("Please Enter the New Name.");
                    string newNameString = Console.ReadLine();
                    ModifyHelperMethod.ModifyNameThroughConsole(myHealthRecord, myGinNumber, newNameString);
                    break;

                case "visit hubei recently":
                    Console.WriteLine("Please Enter the New Visit Hubei or Not (True/False).");
                    string newVisitHubeiString = Console.ReadLine();
                    ModifyHelperMethod.ModifyVisitHubeiThroughConsole(myHealthRecord, myGinNumber, newVisitHubeiString);
                    break;

                case "has abnormal symptom":
                    Console.WriteLine("Please Enter the New Has Abnormal Symptom (True/False).");
                    string newAbnormalSymptomString = Console.ReadLine();
                    ModifyHelperMethod.ModifyHasAbnormalSymptomThroughConsole(myHealthRecord, myGinNumber, newAbnormalSymptomString);
                    break;
                case "temperature":
                    Console.WriteLine("Please Enter the Temperature.");
                    string newTemperatureString = Console.ReadLine();
                    ModifyHelperMethod.ModifyTemperatureThroughConsole(myHealthRecord, myGinNumber, newTemperatureString);
                    break;
                default:
                    Console.WriteLine("Invalid Input! Please Enter Again.");
                    break;
            }
        }

        public void InputFromFile()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the file path:");
            Console.ResetColor();
            string fileName = Console.ReadLine();
            Console.WriteLine(DataFileOperation.InputFromCSVFile(ref myHealthRecord, fileName));
        }

        public void SaveFile()
        {
            Console.WriteLine("Enter the file path:");
            string fileName = Console.ReadLine();
            Console.WriteLine(DataFileOperation.SaveAsCSV(ref myHealthRecord, fileName));
        }
    }
}