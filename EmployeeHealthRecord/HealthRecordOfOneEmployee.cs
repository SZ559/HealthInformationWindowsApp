using System;
using System.Collections.Generic;


namespace EmployeeHealthRecord
{
    public class HealthRecordOfOneEmployee
    {
        public Person Person{ get; set; }

        public SortedDictionary<DateTime, HealthInformation> EmployeeHealthRecords{ get; set; }

        public HealthRecordOfOneEmployee(Person person)
        {
            Person = person;
            EmployeeHealthRecords = new SortedDictionary<DateTime, HealthInformation>();
        }

        public bool ContainsHealthInformation(DateTime date)
        {
            return EmployeeHealthRecords.ContainsKey(date);
        }

        public bool IsEmpty()
        {
            return EmployeeHealthRecords.Count == 0;
        }

        public bool AddHealthInformation(HealthInformation healthInformation)
        {
            if (!ContainsHealthInformation(healthInformation.Date))
            {
                EmployeeHealthRecords.Add(healthInformation.Date, healthInformation);
                return true;
            }
            return false;
        }
        public bool DeleteHealthInformation(HealthInformation healthInformation)
        {
            if (ContainsHealthInformation(healthInformation.Date))
            {
                EmployeeHealthRecords.Remove(healthInformation.Date);
                return true;
            }
            return false;
        }
        public bool ModifyHealthInformation(HealthInformation healthInformation, HealthInformation updatedHealthInformation)
        {
            if (healthInformation.Date == updatedHealthInformation.Date)
            {
                EmployeeHealthRecords[healthInformation.Date] = updatedHealthInformation;
                return true;
            }
            else
            {
                if (AddHealthInformation(updatedHealthInformation))
                {
                    EmployeeHealthRecords.Remove(healthInformation.Date);
                    return true;
                }
            }
            return false;
        }
    }
}