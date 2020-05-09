using System;
using System.Collections.Generic;

namespace EmployeeHealthRecord
{
    public class HealthRecordOfOneEmployee
    {
        public Person Person{ get; set; }

        public SortedDictionary<DateTime, HealthInformation> Records{ get; set; }

        public HealthRecordOfOneEmployee(Person person)
        {
            Person = person;
            Records = new SortedDictionary<DateTime, HealthInformation>();
        }

        public bool ContainsHealthInformation(DateTime date)
        {
            return Records.ContainsKey(date);
        }

        public bool IsEmpty()
        {
            return Records.Count == 0;
        }

        public bool AddHealthInformation(HealthInformation healthInformation)
        {
            if (!ContainsHealthInformation(healthInformation.Date))
            {
                Records.Add(healthInformation.Date, healthInformation);
                return true;
            }
            return false;
        }

        public bool DeleteHealthInformation(DateTime date)
        {
            if (ContainsHealthInformation(date))
            {
                Records.Remove(date);
                return true;
            }
            return false;
        }

        public bool ModifyHealthInformation(DateTime date, HealthInformation updatedHealthInformation)
        {
            if (ContainsHealthInformation(date))
            {
                if (date == updatedHealthInformation.Date)
                {
                    Records[date] = updatedHealthInformation;
                    return true;
                }
                else
                {
                    if (AddHealthInformation(updatedHealthInformation))
                    {
                        Records.Remove(date);
                        return true;
                    }                    
                }
            }
            return false;
        }
    }
}