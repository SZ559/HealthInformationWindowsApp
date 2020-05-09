using System;
using Xunit;
using EmployeeHealthRecord;
namespace PersonTest
{
    public class Constructor
    {
        [Fact]
        public void InputParameters_UpdateGinNumber()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var actual = new Person(myGin, myFirstName, myLastName);
            Assert.Equal(myGin, actual.GinNumber);
        }

        [Fact]
        public void InputParameters_UpdateFirstName()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var actual = new Person(myGin, myFirstName, myLastName);
            Assert.Equal(myFirstName, actual.FirstName);
        }

        [Fact]
        public void InputParameters_UpdateLastName()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var actual = new Person(myGin, myFirstName, myLastName);
            Assert.Equal(myLastName, actual.LastName);
        }
    }

    public class GinNumberProperty
    {

        [Fact]
        public void GetGinNumber_ReturnGinNumber()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var myPerson = new Person(myGin, myFirstName, myLastName);
            var actual = myPerson.GinNumber;
            Assert.Equal(myGin, actual);
        }

        [Fact]
        public void SetGinNumber_UpdateGinNumber()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var myPerson = new Person(myGin, myFirstName, myLastName);

            var mynewGinNumber = 2004;
            myPerson.GinNumber = mynewGinNumber;
            var actual = myPerson.GinNumber;

            Assert.Equal(mynewGinNumber, actual);
        }
    }

    public class FirstNameProperty
    {
        [Fact]
        public void GetFirstName_ReturnFirstName()
        {

            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var myPerson = new Person(myGin, myFirstName, myLastName);
            var actual = myPerson.FirstName;
            Assert.Equal(myFirstName, actual);
        }

        [Fact]
        public void SetFirstName_UpdateFirstName()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var myPerson = new Person(myGin, myFirstName, myLastName);
            var myNewFirstName = "tony";
            myPerson.FirstName = myNewFirstName;
            var actual = myPerson.FirstName;

            Assert.Equal(myNewFirstName, actual);
        }
    }
    public class LastNameProperty
    {
        [Fact]
        public void GetLastName_ReturnLastName()
        {

            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var myPerson = new Person(myGin, myFirstName, myLastName);
            var actual = myPerson.FirstName;
            Assert.Equal(myFirstName, actual);
        }

        [Fact]
        public void SetLastName_UpdateLastName()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var myPerson = new Person(myGin, myFirstName, myLastName);
            var myNewLastName = "Smith";
            myPerson.LastName = myNewLastName;
            var actual = myPerson.LastName;
            Assert.Equal(myNewLastName, actual);
        }
    }

    public class ToString
    {
        [Fact]
        public void InputPerson_ReturnStringOfPerson()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var myPerson = new Person(myGin, myFirstName, myLastName);
            var expected = "2003,shishi,Zhang";
            var actual = myPerson.ToString();
            Assert.Equal(expected, actual);
        }
    }

    public class HasSameName
    {
        [Fact]
        public void InputPersonHasSameFirstNameAndLastName_ReturnTrue()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var myPerson = new Person(myGin, myFirstName, myLastName);
            Person person = new Person(204, "shishi", "Zhang");
            bool actual = myPerson.HasSameName(person);
            Assert.True(actual);
        }

        [Fact]
        public void InputPersonHasDifferentFirstName_ReturnFalse()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var myPerson = new Person(myGin, myFirstName, myLastName);
            Person person = new Person(204, "tony", "Zhang");
            bool actual = myPerson.HasSameName(person);
            Assert.False(actual);
        }


        [Fact]
        public void InputPersonHasDifferentLastName_ReturnFalse()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "tom";
            var myPerson = new Person(myGin, myFirstName, myLastName);
            Person person = new Person(204, "shishi", "Zhang");
            bool actual = myPerson.HasSameName(person);
            Assert.False(actual);
        }

        [Fact]
        public void InputNull_ReturnFalse()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "tom";
            Person myPerson = new Person(myGin, myFirstName, myLastName);
            bool actual = myPerson.HasSameName(null);
            Assert.False(actual);
        }
    }
    public class ToString_InDefaultNameFormat
    {
        [Fact]
        public void InputPerson_ReturnStringOfPersonInDefualtNameFormat()
        {
            var myGin = 2003;
            var myFirstName = "shishi";
            var myLastName = "Zhang";
            var myPerson = new Person(myGin, myFirstName, myLastName);
            var expected = "2003,shishi Zhang";
            var actual = myPerson.ToString_InDefaultNameFormat();
            Assert.Equal(expected, actual);
        }
    }
}

