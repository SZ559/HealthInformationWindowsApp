using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EmployeeHealthRecord
{
    public class HealthRecordsOfAllEmployees
    {
        private SortedDictionary<int, HealthRecordOfOneEmployee> healthRecords;

        public SortedDictionary<int, HealthRecordOfOneEmployee> HealthRecords
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
                    foreach (var healthInformation in employeeHealthRecord.Records.Values)
                    {
                        healthRecordDataTable.Rows.Add(new object[] { person.GinNumber, person.LastName, person.FirstName, healthInformation.Date, healthInformation.VisitHubei, healthInformation.HasAbnormalSymptom, healthInformation.BodyTemperature });
                    }
                }
                return healthRecordDataTable;
            }
        }

        public HealthRecordsOfAllEmployees()
        {
            healthRecords = new SortedDictionary<int, HealthRecordOfOneEmployee>();
        }

        public bool ContainsPerson(Person person)
        {
            return healthRecords.ContainsKey(person.GinNumber) && person.HasSameName(healthRecords[person.GinNumber].Person);
        }

        public bool ContainsRecord(Person person, DateTime date)
        {
            return ContainsPerson(person) && healthRecords[person.GinNumber].ContainsHealthInformation(date);
        }
        
        public void RemoveEmptyPerson(Person person)
        {
            if (healthRecords[person.GinNumber].IsEmpty())
            {
                healthRecords.Remove(person.GinNumber);
            }
        }

        public bool AddHealthRecord(Person person, HealthInformation newHealthInformation)
        {
            if (!healthRecords.ContainsKey(person.GinNumber))
            {
                healthRecords.Add(person.GinNumber, new HealthRecordOfOneEmployee(person));
            }
            else if (!healthRecords[person.GinNumber].Person.HasSameName(person))
            {
                return false;
            }
            return healthRecords[person.GinNumber].AddHealthInformation(newHealthInformation);
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

        public bool DeleteHealthRecord(Person person, DateTime date)
        {
            if (ContainsPerson(person))
            {
                bool deleteResult = healthRecords[person.GinNumber].DeleteHealthInformation(date);
                RemoveEmptyPerson(person);
                return deleteResult;
            }
            return false;
        }

        public bool EditHealthRecord(Person personToBeEdited, DateTime dateToBeEdited, Person personAfterEdit, HealthInformation healthInformationAfterEdit)
        {
            if (ContainsPerson(personToBeEdited))
            {
                if (personToBeEdited.GinNumber == personAfterEdit.GinNumber)
                {
                    if (personToBeEdited.HasSameName(personAfterEdit))
                    {
                        return healthRecords[personToBeEdited.GinNumber].ModifyHealthInformation(dateToBeEdited, healthInformationAfterEdit);
                    }
                }
                else if (AddHealthRecord(personAfterEdit, healthInformationAfterEdit))
                {
                    healthRecords[personToBeEdited.GinNumber].DeleteHealthInformation(dateToBeEdited);
                    RemoveEmptyPerson(personToBeEdited);
                    return true;
                }
            }
            return false;
        }

        public bool EditHealthRecordOfChosenPerson(Person personToBeEdited, DateTime dateToBeEdited, HealthInformation newHealthInformation)
        {
            if (ContainsPerson(personToBeEdited))
            {
                return healthRecords[personToBeEdited.GinNumber].ModifyHealthInformation(dateToBeEdited, newHealthInformation);
            }
            return false;
        }

        public List<HealthInformation>[] UpdatePerson(Person personToBeEdited, Person personAfterEdit)
        {
            if (!ContainsPerson(personToBeEdited))
            {
                return null;
            }
            if (personToBeEdited.GinNumber == personAfterEdit.GinNumber)
            {
                healthRecords[personToBeEdited.GinNumber].Person = personAfterEdit;
            }
            else if (healthRecords.ContainsKey(personAfterEdit.GinNumber))
            {
                return GetOverlappedHealthInformation(personToBeEdited, personAfterEdit);
            }
            else
            {
                HealthRecordOfOneEmployee records = healthRecords[personToBeEdited.GinNumber];
                records.Person = personAfterEdit;
                healthRecords.Add(records.Person.GinNumber, records);
                healthRecords.Remove(personToBeEdited.GinNumber);
            }
            return new List<HealthInformation>[] { new List<HealthInformation>(), new List<HealthInformation>() };
        }

        public List<HealthInformation>[] GetOverlappedHealthInformation(Person personToBeEdited, Person personAfterEdit)
        {
            List<HealthInformation> overlappedRecords_PersonToBeEdited = new List<HealthInformation>();
            List<HealthInformation> overlappedRecords_PersonAfterEdit = new List<HealthInformation>();

            if (!healthRecords[personAfterEdit.GinNumber].Person.HasSameName(personAfterEdit))
            {
                return null;
            }

            List<HealthInformation> healthInformationList = healthRecords[personToBeEdited.GinNumber].Records.Values.ToList();
            foreach (HealthInformation healthInformation in healthInformationList)
            {
                if (!healthRecords[personAfterEdit.GinNumber].AddHealthInformation(healthInformation))
                {
                    overlappedRecords_PersonToBeEdited.Add(healthInformation);
                    overlappedRecords_PersonAfterEdit.Add(healthRecords[personAfterEdit.GinNumber].Records[healthInformation.Date]);
                }
                else
                {
                    healthRecords[personToBeEdited.GinNumber].DeleteHealthInformation(healthInformation.Date);
                }
            }

            RemoveEmptyPerson(personToBeEdited);
            return new List<HealthInformation>[] { overlappedRecords_PersonToBeEdited, overlappedRecords_PersonAfterEdit };
        }
    }
}