using System;
using System.Collections.Generic;
using System.IO;
using EmployeeInformation;

namespace DatabaseOperation
{
    public class Revise
    {
        public static void ReviseGinNumber(SLBHealthRecord myHealthRecord, int myGinNumber, int newGinNumber)
        {
            Person myPerson = myHealthRecord.HealthRecord[myGinNumber];
            myPerson.GinNumber = newGinNumber;
            myHealthRecord.Remove(myGinNumber);
            myHealthRecord.Add(myPerson);
        }
        public static void ReviseName(SLBHealthRecord myHealthRecord, int myGinNumber, string myNewName)
        {
            myHealthRecord.HealthRecord[myGinNumber].Name = myNewName;
            if (myHealthRecord.SuspectedRecord.ContainsKey(myGinNumber))
            {
                myHealthRecord.SuspectedRecord[myGinNumber].Name = myNewName;
            }
        }
        public static void ReviseVisitHubei(SLBHealthRecord myHealthRecord, int myGinNumber, bool myNewVisit)
        {
            myHealthRecord.HealthRecord[myGinNumber].VisitHubei = myNewVisit;
            myHealthRecord.SynchronizeSuspectedRecord(myGinNumber);
        }
        public static void ReviseAbnormalSymptom(SLBHealthRecord myHealthRecord, int myGinNumber, bool myNewAbnormalSymptom)
        {

            myHealthRecord.HealthRecord[myGinNumber].HasAbnormalSymptom = myNewAbnormalSymptom;
            myHealthRecord.SynchronizeSuspectedRecord(myGinNumber);
        }
        public static void ReviseTemperature(SLBHealthRecord myHealthRecord, int myGinNumber, double myNewTemperature)
        {
            myHealthRecord.HealthRecord[myGinNumber].Temperature = myNewTemperature;
            myHealthRecord.SynchronizeSuspectedRecord(myGinNumber);
        }
    }
}
