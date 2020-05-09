
using System.Collections;

namespace EmployeeHealthRecord
{
    public class Person
    {
        public int GinNumber{ get; set; }

        public string FirstName{ get; set; }

        public string LastName{ get; set; }

        public Person(int myGinNumber, string myFirstName, string myLastName)
        {
            GinNumber = myGinNumber;
            FirstName = myFirstName;
            LastName = myLastName;
        }

        public bool HasSameName(Person person)
        {
            if (person == null)
            {
                return false;
            }
            return this.FirstName == person.FirstName && this.LastName == person.LastName;
        }

        public override string ToString()
        {
            return GinNumber.ToString() + "," + FirstName + "," +  LastName;
        }

        public string ToString_InDefaultNameFormat()
        { 
            return GinNumber.ToString() + "," + FirstName + " " + LastName;
        }
    }
}
