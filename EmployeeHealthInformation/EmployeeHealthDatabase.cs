using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public class EmployeeHealthDatabase
    {
        private SortedDictionary<int, EmployeeHealthRecord> healthRecords;
        public SortedDictionary<int, EmployeeHealthRecord> HealthRecords
        {
            get
            {
                return healthRecords;
            }
        }
        public DataTable HealthRecordsDataTable
        {
            get
            {
                DataTable healthRecordDataTable = new DataTable();
                healthRecordDataTable.Columns.Add("GinNumber", typeof(int));
                healthRecordDataTable.Columns.Add("LastName", typeof(string));
                healthRecordDataTable.Columns.Add("FirstName", typeof(string));
                healthRecordDataTable.Columns.Add("Date", typeof(DateTime));
                healthRecordDataTable.Columns.Add("VisitHubei", typeof(bool));
                healthRecordDataTable.Columns.Add("HasAbnormalSymptom", typeof(bool));
                healthRecordDataTable.Columns.Add("Temperature", typeof(double));
                foreach (var employeeHealthRecord in healthRecords.Values)
                {
                    Person person = employeeHealthRecord.Person;
                    foreach (var healthInformation in employeeHealthRecord.EmployeeHealthRecords.Values)
                    {
                        healthRecordDataTable.Rows.Add(new object[] { person.GinNumber, person.LastName, person.FirstName, healthInformation.Date, healthInformation.VisitHubei, healthInformation.HasAbnormalSymptom, healthInformation.Temperature });
                    }
                }
                return healthRecordDataTable;
            }
        }
        public EmployeeHealthDatabase()
        {
            healthRecords = new SortedDictionary<int, EmployeeHealthRecord>();
        }
        public bool ContainsPerson(Person person)
        {
            return healthRecords.ContainsKey(person.GinNumber) && person.HasSameName(healthRecords[person.GinNumber].Person);
        }
        public bool ContainsRecord(Person person, DateTime date)
        {
            return ContainsPerson(person) && healthRecords[person.GinNumber].ContainsHealthInformation(date);
        }
        public void AddNewPerson(EmployeeHealthRecord newEmployeeHealthRecords)
        {
            if (!healthRecords.ContainsKey(newEmployeeHealthRecords.Person.GinNumber))
            {
                healthRecords.Add(newEmployeeHealthRecords.Person.GinNumber, newEmployeeHealthRecords);
            }
        }
        public bool AddHealthRecord(Person person, HealthInformation newHealthInformation)
        {
            if (!healthRecords.ContainsKey(person.GinNumber))
            {
                healthRecords.Add(person.GinNumber, new EmployeeHealthRecord(person));
            }
            return person.HasSameName(healthRecords[person.GinNumber].Person) && healthRecords[person.GinNumber].AddHealthInformation(newHealthInformation);
        }
        public bool DeletePerson(Person personToBeDeleted)
        {
            if (ContainsPerson(personToBeDeleted))
            {
                healthRecords.Remove(personToBeDeleted.GinNumber);
                return true;
            }
            return false;
        }
        public bool DeleteHealthRecord(Person person, HealthInformation healthInformationToBeDeleted)
        {
            if (ContainsPerson(person))
            {
                bool deleteResult = healthRecords[person.GinNumber].DeleteHealthInformation(healthInformationToBeDeleted);
                RemoveEmptyPerson(person);
                return deleteResult;
            }
            return false;
        } 
        public List<HealthInformation>[] UpdatePerson(Person originalPerson, Person updatedPerson)
        {
            List<HealthInformation> overlapedInformation_Original = new List<HealthInformation>();
            List<HealthInformation> overlapedInformation_Updated = new List<HealthInformation>();
            if (originalPerson.GinNumber == updatedPerson.GinNumber)
            {
                healthRecords[originalPerson.GinNumber].Person = updatedPerson;
            }
            else if (ContainsPerson(updatedPerson))
            {
                List<HealthInformation> healthInformationList= healthRecords[originalPerson.GinNumber].EmployeeHealthRecords.Values.ToList();
                foreach (HealthInformation healthInformation in healthInformationList)
                {
                    if (!healthRecords[updatedPerson.GinNumber].AddHealthInformation(healthInformation))
                    {
                        overlapedInformation_Original.Add(healthInformation);
                        overlapedInformation_Updated.Add(GetHealthInformation(updatedPerson.GinNumber, healthInformation.Date));
                    }
                    else
                    {
                        healthRecords[originalPerson.GinNumber].DeleteHealthInformation(healthInformation);
                    }                
                }
                RemoveEmptyPerson(originalPerson);
            }
            else if (!healthRecords.ContainsKey(updatedPerson.GinNumber))
            {
                EmployeeHealthRecord origianlEmployeeHealthRecord = healthRecords[originalPerson.GinNumber];
                origianlEmployeeHealthRecord.Person = updatedPerson;
                AddNewPerson(origianlEmployeeHealthRecord);
                healthRecords.Remove(originalPerson.GinNumber);
            }
           
            return new List<HealthInformation>[] { overlapedInformation_Original, overlapedInformation_Updated };
        }

        public bool ModifyOneHealthRecord(Person personToBeModified, HealthInformation healthInformationToBeModified, Person updatedPerson, HealthInformation updatedHealthInformation)
        {
            if (personToBeModified.GinNumber == updatedPerson.GinNumber)
            {
                if (personToBeModified.HasSameName(updatedPerson))
                {
                    return healthRecords[personToBeModified.GinNumber].ModifyHealthInformation(healthInformationToBeModified, updatedHealthInformation);
                }
                else if (healthRecords[personToBeModified.GinNumber].EmployeeHealthRecords.Count == 1)
                {
                    healthRecords[personToBeModified.GinNumber].Person = updatedPerson;
                    return healthRecords[personToBeModified.GinNumber].ModifyHealthInformation(healthInformationToBeModified, updatedHealthInformation);
                }    
            }
            else if (AddHealthRecord(updatedPerson, updatedHealthInformation))
            {
                DeleteHealthRecord(personToBeModified, healthInformationToBeModified);
                return true;
            }
            return false;
        }
        public bool ModifyHealthRecordOfChosenPerson(Person personToBeModified, HealthInformation healthInformationToBeModified, HealthInformation updatedHealthInformation)
        {
            if (ContainsPerson(personToBeModified))
            {
                return healthRecords[personToBeModified.GinNumber].ModifyHealthInformation(healthInformationToBeModified, updatedHealthInformation);
            }
            return false;
        }
        public void RemoveEmptyPerson(Person person)
        {
            if (healthRecords[person.GinNumber].IsEmpty())
            {
                healthRecords.Remove(person.GinNumber);
            }
        }
        public HealthInformation GetHealthInformation(int ginNumber, DateTime date)
        {
            if (GetHealthRecord(ginNumber) == null)
            {
                return null;
            }
            return healthRecords[ginNumber].EmployeeHealthRecords[date];
        }
        public Person GetPerson(int ginNumber)
        {
            if (!healthRecords.ContainsKey(ginNumber))
            {
                return null;
            }
            return healthRecords[ginNumber].Person;
        }
        public EmployeeHealthRecord GetHealthRecord(int ginNumber)
        {
            if (!healthRecords.ContainsKey(ginNumber))
            {
                return null;
            }
            return healthRecords[ginNumber];
        }
    }
}