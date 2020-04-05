using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeInformation
{
    public class HealthDatabase
    {
        private SortedDictionary<int, Person> healthRecord = new SortedDictionary<int, Person>();
        public SortedDictionary<int, Person> HealthRecord
        {
            get
            {
                return healthRecord;
            }
            set
            {
                healthRecord = value;
            }
        }

        public bool AddNewPerson(Person newPerson)
        {
            if (!healthRecord.ContainsKey(newPerson.GinNumber) && newPerson != null)
            {
                healthRecord.Add(newPerson.GinNumber, newPerson);
                return true;
            }
            return false;
        }

        public bool DeletePerson(int myGinNumber)
        {
            if (healthRecord.ContainsKey(myGinNumber))
            {
                healthRecord.Remove(myGinNumber);
                return true;
            }
            return false;
        }

        public bool ModifyPerson(int myGinNumber, Person updatedPerson)
        {
            if (healthRecord.ContainsKey(myGinNumber))
            {
                if (myGinNumber == updatedPerson.GinNumber)
                {
                    healthRecord[myGinNumber] = updatedPerson;
                    return true;
                }
                else
                {
                    if (!healthRecord.ContainsKey(updatedPerson.GinNumber))
                    {
                        healthRecord.Remove(myGinNumber);
                        healthRecord.Add(updatedPerson.GinNumber, updatedPerson);
                        return true;
                    }
                }   
            }
            return false;
        }
    }
}