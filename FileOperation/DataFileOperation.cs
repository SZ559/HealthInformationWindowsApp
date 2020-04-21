using System;
using System.Collections.Generic;
using System.IO;
using EmployeeInformation;
using DatabaseOperation;
namespace FileOperation
{
    public class DataFileOperation
    {
        public static string InputFromCSVFile(ref EmployeeHealthDatabase myHealthRecord, string filePath)
        {
            FormatValidator formatValidator = new FormatValidator();
            try
            {
                EmployeeHealthDatabase newHealthRecord = new EmployeeHealthDatabase();
                using (StreamReader myStreamReader = new StreamReader(filePath))
                {
                    string newRecord;
                    while (!myStreamReader.EndOfStream)
                    {
                        newRecord = myStreamReader.ReadLine();
                        if (formatValidator.CheckFormatError_InputString(newRecord) == "")
                        {
                            string[] newPersonArray = newRecord.Split(',');
                            int ginNumber = int.Parse(newPersonArray[0]);
                            string lastName = newPersonArray[1];
                            string firstName = newPersonArray[2];
                            DateTime date = DateTime.Parse(newPersonArray[3]);
                            bool visitedHubei = bool.Parse(newPersonArray[4]);
                            bool hasAbnormalSymptom = bool.Parse(newPersonArray[5]);
                            double temperature = double.Parse(newPersonArray[6]);
                            Person person = new Person(ginNumber, firstName, lastName);
                            HealthInformation healthInformation = new HealthInformation(date, visitedHubei, hasAbnormalSymptom, temperature);
                            newHealthRecord.AddHealthRecord(person, healthInformation);
                        }
                        else
                        {
                            return "Import Failed! Format error occrus!";
                        }
                    }
                }
                myHealthRecord = newHealthRecord;
                return "Import Success!";
            }
            catch (Exception e)
            {
                return $"Import Failed! {e.Message}";
            }
        }

        public static string SaveAsCSV(ref EmployeeHealthDatabase myHealthRecords, string filePath)
        {
            try
            {
                using (StreamWriter myStreamSaver = new StreamWriter(filePath))
                {
                    foreach (var employeeHealthRecord in myHealthRecords.HealthRecords.Values)
                    {
                        Person person = employeeHealthRecord.Person;
                        foreach (var healthInformation in employeeHealthRecord.EmployeeHealthRecords.Values)
                        {
                            myStreamSaver.WriteLine(person.ToString() + healthInformation.ToString());
                        }
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