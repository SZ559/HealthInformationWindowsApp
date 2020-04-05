using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformation;

namespace DatabaseOperation
{
    public class AddPersonHelperMethods
    {
        public static Person AddNewPerson_ThroughValidString(string myInputString)
        {
            string[] newPersonArray = myInputString.Split(',');
            int ginNumber = Int32.Parse(newPersonArray[0]);
            string name = newPersonArray[1];
            bool visitedHubei = bool.Parse(newPersonArray[2]);
            bool hasAbnormalSymptom = bool.Parse(newPersonArray[3]);
            double temperature = double.Parse(newPersonArray[4]);
            return new Person(ginNumber, name, visitedHubei, hasAbnormalSymptom, temperature);
        }
    }
}
