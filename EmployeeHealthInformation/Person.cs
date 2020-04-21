using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public class Person
    {
        public int GinNumber
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public Person(int myGinNumber, string myFirstName, string myLastName)
        {
            GinNumber = myGinNumber;
            FirstName = myFirstName;
            LastName = myLastName;
        }
        public bool HasSameName(Person person)
        {
            return this.FirstName == person.FirstName && this.LastName == person.LastName;
        }
        public override string ToString()
        {
            return GinNumber.ToString() + "," + LastName + "," + FirstName;
        }

        public string ToString_DefualtNameFormat()
        { 
            return GinNumber.ToString() + "," + FirstName + " " + LastName;
        }

    }
}
