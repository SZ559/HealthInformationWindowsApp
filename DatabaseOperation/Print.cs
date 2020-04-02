
using System;
using System.Collections.Generic;
using System.IO;
using EmployeeInformation;

namespace DatabaseOperation
{
    public class Print
    {
        public static void PrintAll(SLBHealthRecord myHealthRecord)
        {
            Console.WriteLine("SLB Health Record");
            Console.WriteLine(@"Gin Number /Name /Visit Hubei Recently /Has Abnormal Symptom /Temperature");
            foreach (Person myPerson in myHealthRecord.HealthRecord.Values)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", myPerson.GinNumber, myPerson.Name, myPerson.VisitHubei, myPerson.HasAbnormalSymptom, myPerson.Temperature);
            }
        }

        public static void PrintAbnormal(SLBHealthRecord myHealthRecord)
        {
            Console.WriteLine("SLB Suspected Case Record");
            Console.WriteLine(@"Gin Number /Name /Visit Hubei Recently /Has Abnormal Symptom /Temperature");
            foreach (Person myPerson in myHealthRecord.SuspectedRecord.Values)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", myPerson.GinNumber, myPerson.Name, myPerson.VisitHubei, myPerson.HasAbnormalSymptom, myPerson.Temperature);
            }
        }

        public static void PrintPerson(SLBHealthRecord myHealthRecord, int myGinNumber)
        {
            Person myPerson = myHealthRecord.HealthRecord[myGinNumber];
            Console.WriteLine("Gin Number /Name /Visit Hubei Recently /Has Abnormal Symptom /Temperature");
            Console.WriteLine(@"{0}, {1}, {2}, {3}, {4}", myPerson.GinNumber, myPerson.Name, myPerson.VisitHubei, myPerson.HasAbnormalSymptom, myPerson.Temperature);
        }

    }
}