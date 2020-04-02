using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeInformation
{
    public class SLBHealthRecord
    {
        private SortedDictionary<int, Person> healthRecord = new SortedDictionary<int, Person>();
        private SortedDictionary<int, Person> suspectedRecord = new SortedDictionary<int, Person>();
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

        public SortedDictionary<int, Person> SuspectedRecord
        {
            get
            {
                return suspectedRecord;
            }
            set
            {
                suspectedRecord = value;
            }
        }

        public bool Add(Person newPerson)
        {

            if (!healthRecord.ContainsKey(newPerson.GinNumber) && newPerson != null)
            {
                healthRecord.Add(newPerson.GinNumber, newPerson);
                if (newPerson.IsPersonSuspected() == true)
                {
                    suspectedRecord.Add(newPerson.GinNumber, newPerson);
                }
                return true;
            }
            return false;
        }

        public bool Remove(int GinNumber)
        {
            if (healthRecord.ContainsKey(GinNumber))
            {
                healthRecord.Remove(GinNumber);
                if (suspectedRecord.ContainsKey(GinNumber))
                {
                    suspectedRecord.Remove(GinNumber);
                }
                return true;
            }
            return false;
        }

        public void SynchronizeSuspectedRecord(int myGinNumber)
        {
            Person myPerson = healthRecord[myGinNumber];
            bool personSuspected = myPerson.IsPersonSuspected();
            if (personSuspected == true)
            {
                if (suspectedRecord.ContainsKey(myGinNumber))
                {
                    suspectedRecord[myGinNumber] = myPerson;
                }
                else
                {
                    suspectedRecord.Add(myPerson.GinNumber, myPerson);
                }
            }
            else
            {
                if (suspectedRecord.ContainsKey(myGinNumber))
                {
                    suspectedRecord.Remove(myGinNumber);
                }
            }
        }

    }
}