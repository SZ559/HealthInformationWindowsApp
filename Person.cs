using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeInformation
{
    public class Person
    {
        public int GinNumber
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public bool VisitHubei
        {
            get; set;
        }

        public bool HasAbnormalSymptom
        {
            get; set;
        }

        public double Temperature
        {
            get; set;
        }

        public Person(int myGin, string myName, bool myVisit, bool myAbnormalSymptom, double myTemperature)
        {
            GinNumber = myGin;
            Name = myName;
            VisitHubei = myVisit;
            HasAbnormalSymptom = myAbnormalSymptom;
            Temperature = myTemperature;
        }

        public bool IsPersonSuspected()
        {
            if (Temperature > 37.3 || HasAbnormalSymptom == true || VisitHubei == true)
            {
                return true;
            }
            return false;
        }
    }
}