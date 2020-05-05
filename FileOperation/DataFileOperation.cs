using System;
using System.IO;
using EmployeeHealthRecord;
using FormatValidator;
namespace FileOperation
{
    public class DataFileOperation
    {
        public static string InputFromCSVFile(ref HealthRecordsOfAllEmployees myHealthRecord, string filePath)
        {
            FormatCheck formatValidator = new FormatCheck();
            try
            {
                HealthRecordsOfAllEmployees newHealthRecord = new HealthRecordsOfAllEmployees();
                using (StreamReader myStreamReader = new StreamReader(filePath))
                {
                    string newRecord;
                    while (!myStreamReader.EndOfStream)
                    {
                        newRecord = myStreamReader.ReadLine();
                        string formatErrorMessage = formatValidator.CheckFormatError_InputString(newRecord);
                        if (formatErrorMessage == "")
                        {
                            string[] newPersonArray = newRecord.Split(',');
                            int ginNumber = int.Parse(newPersonArray[0]);
                            string firstName = newPersonArray[1];
                            string lastName = newPersonArray[2];
                            DateTime date = DateTime.Parse(newPersonArray[3]);
                            bool visitedHubei = bool.Parse(newPersonArray[4]);
                            bool hasAbnormalSymptom = bool.Parse(newPersonArray[5]);
                            double bodyTemperature = double.Parse(newPersonArray[6]);
                            Person person = new Person(ginNumber, firstName, lastName);
                            HealthInformation healthInformation = new HealthInformation(date, visitedHubei, hasAbnormalSymptom, bodyTemperature);
                            if (!newHealthRecord.AddHealthRecord(person, healthInformation))
                            {
                                return $"Import Failed! Unable to load record: {newRecord}. Please check if the Gin Number and the Name match employee records or a duplicate health record with same Gin Number and Date already exists.";
                            }
                        }
                        else
                        {
                            return $"Import Failed! Unable to load record: {newRecord}. {formatErrorMessage}";
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

        public static string SaveAsCSV(ref HealthRecordsOfAllEmployees myHealthRecords, string filePath)
        {
            try
            {
                using (StreamWriter myStreamSaver = new StreamWriter(filePath))
                {
                    foreach (var employeeHealthRecord in myHealthRecords.HealthRecords.Values)
                    {
                        Person person = employeeHealthRecord.Person;
                        foreach (var healthInformation in employeeHealthRecord.Records.Values)
                        {
                            myStreamSaver.WriteLine(person.ToString() + healthInformation.ToString());
                        }
                    }
                }
                return "Save Success!";
            }
            catch (Exception e)
            {
                return $"Save Failed! {e.Message}";
            }
        }
    }

}