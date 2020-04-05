using System;
using System.Collections.Generic;
using System.IO;
using EmployeeInformation;
using DatabaseOperation;
namespace FileOperation
{
    public class DataFileOperation
    {
        public static string InputFromCSVFile(ref HealthDatabase myHealthRecord, string filePath)
        {
            FormatValidator formatValidator = new FormatValidator();
            try
            {
                HealthDatabase newHealthRecord = new HealthDatabase();
                using (StreamReader myStreamReader = new StreamReader(filePath))
                {
                    string newPerson;
                    while (!myStreamReader.EndOfStream)
                    {
                        newPerson = myStreamReader.ReadLine();
                        if (formatValidator.CheckFormatError_InputString(newPerson) == "")
                        {
                            Console.WriteLine("I am here");
                            Person person = AddPersonHelperMethods.AddNewPerson_ThroughValidString(newPerson);
                            newHealthRecord.AddNewPerson(person);
                        }
                        else
                        {
                            //return ;
                            //formatValidator.CheckFormatError_InputString(newPerson)
                            return "Import Failed! Format error occrus!";
                        }
                    }
                }
                myHealthRecord = newHealthRecord;
                return "Import Success!";

            }
            catch (Exception)
            {
                return "Import Failed!";
            }
        }

        public static string SaveAsCSV(ref HealthDatabase myHealthRecord, string filePath)
        {
            try
            {
                using (StreamWriter myStreamSaver = new StreamWriter(filePath))
                {
                    foreach (Person myPerson in myHealthRecord.HealthRecord.Values)
                    {

                        myStreamSaver.WriteLine(myPerson.ToString());
                    }
                }
                return "Save Success!";
            }
            catch (Exception)
            {
                return "Save Failed!";
            }
        }
    }

}