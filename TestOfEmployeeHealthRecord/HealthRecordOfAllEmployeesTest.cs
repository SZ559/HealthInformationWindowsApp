using EmployeeHealthRecord;
using System;
using System.Collections.Generic;
using System.Data;
using Xunit;

namespace HealthRecordOfAllEmployeesTest
{
    public class ContainsPerson
    {
        private HealthRecordsOfAllEmployees actualEmployeeRecords = new HealthRecordsOfAllEmployees();
        private void InitializeEmployeeRecords()
        {
            int ginNumber1 = 2003;
            string firstName = "shishi";
            string lastName = "zhang";
            Person person1 = new Person(ginNumber1, firstName, lastName);
            HealthRecordOfOneEmployee healthRecords = new HealthRecordOfOneEmployee(person1);

            actualEmployeeRecords.HealthRecords.Add(ginNumber1, healthRecords);
        }

        [Fact]
        public void InputExistedGinNumberAndName_ReturnTrue()
        {
            int ginNumber1 = 2003;
            string firstName = "shishi";
            string lastName = "zhang";
            Person person1 = new Person(ginNumber1, firstName, lastName);

            InitializeEmployeeRecords();
            var actual = actualEmployeeRecords.ContainsPerson(person1);
            Assert.True(actual);
        }

        [Theory]
        [InlineData("tony", "zhang")]
        [InlineData("shishi", "trump")]
        public void InputExistedGinNumberAndANameThatDoesNotMatchRecords_ReturnFalse(string firstName, string lastName)
        {
            int ginNumber1 = 2003;
            Person person1 = new Person(ginNumber1, firstName, lastName);

            InitializeEmployeeRecords();
            var actual = actualEmployeeRecords.ContainsPerson(person1);
            Assert.False(actual);
        }

        [Fact]
        public void InputNotExistedGinNumber_ReturnFalse()
        {
            int ginNumber1 = 2000;
            string firstName = "shishi";
            string lastName = "zhang";
            Person person1 = new Person(ginNumber1, firstName, lastName);

            InitializeEmployeeRecords();
            var actual = actualEmployeeRecords.ContainsPerson(person1);
            Assert.False(actual);
        }
    }

    public class ContainsRecord
    {
        private HealthRecordsOfAllEmployees actualEmployeeRecords = new HealthRecordsOfAllEmployees();
        private void InitializeEmployeeRecords()
        {
            int ginNumber1 = 2003;
            string firstName = "shishi";
            string lastName = "zhang";
            Person person1 = new Person(ginNumber1, firstName, lastName);
            HealthRecordOfOneEmployee healthRecord1 = new HealthRecordOfOneEmployee(person1);

            var date = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(date, myVisit, myAbnormalSymptom, myTemperature);
            healthRecord1.Records.Add(date, myHealthInformation);
            actualEmployeeRecords.HealthRecords.Add(ginNumber1, healthRecord1);
        }

        [Fact]
        public void InputExistedPersonAndDate_ReturnTrue()
        {
            int ginNumber1 = 2003;
            string firstName = "shishi";
            string lastName = "zhang";
            Person person1 = new Person(ginNumber1, firstName, lastName);
            var date1 = new DateTime(2010, 02, 01);
            InitializeEmployeeRecords();
            var actual = actualEmployeeRecords.ContainsRecord(person1, date1);
            Assert.True(actual);
        }

        [Fact]
        public void InputExistedPersonAndNonExistedDate_ReturnFalse()
        {
            int ginNumber1 = 2003;
            string firstName = "shishi";
            string lastName = "zhang";
            Person person1 = new Person(ginNumber1, firstName, lastName);
            var date = new DateTime(2010, 08, 01);
            InitializeEmployeeRecords();

            var actual = actualEmployeeRecords.ContainsRecord(person1, date);
            Assert.False(actual);
        }

        [Theory]
        [InlineData(2003, "tony", "zhang")]
        [InlineData(2003, "shishi", "trump")]
        [InlineData(2000, "shishi", "zhang")]
        public void InputNonExistedPerson_ReturnFalse(int ginNumber, string firstName, string lastName)
        {
            Person person1 = new Person(ginNumber, firstName, lastName);
            var date1 = new DateTime(2010, 02, 01);
            InitializeEmployeeRecords();
            var actual = actualEmployeeRecords.ContainsRecord(person1, date1);
            Assert.False(actual);
        }
    }

    public class RemoveEmptyPerson
    {
        private HealthRecordsOfAllEmployees actualEmployeeRecords = new HealthRecordsOfAllEmployees();
        private HealthRecordsOfAllEmployees expectedEmployeeRecords = new HealthRecordsOfAllEmployees();

        [Fact]
        public void TheEmployeeHasZeorHealthRecord_RemoveTheEmployee()
        {
            Person person = new Person(2003, "shishi", "zhang");
            HealthRecordOfOneEmployee actualHealthRecord = new HealthRecordOfOneEmployee(person);
            actualEmployeeRecords.HealthRecords.Add(2003, actualHealthRecord);

            actualEmployeeRecords.RemoveEmptyPerson(person);
            var actual = actualEmployeeRecords.HealthRecords.Count;
            var expected = 0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TheEmployeeHasMoreThanZeroHealthRecord_DoNotRemoveTheEmployee()
        {
            Person person = new Person(2003, "shishi", "zhang");
            HealthRecordOfOneEmployee helathInformation1 = new HealthRecordOfOneEmployee(person);
            var date1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation1 = new HealthInformation(date1, myVisit, myAbnormalSymptom, myTemperature);

            helathInformation1.Records.Add(date1, myHealthInformation1);

            actualEmployeeRecords.HealthRecords.Add(2003, helathInformation1);
            expectedEmployeeRecords.HealthRecords.Add(2003, helathInformation1);

            actualEmployeeRecords.RemoveEmptyPerson(person);
            Assert.Equal(actualEmployeeRecords.HealthRecords, expectedEmployeeRecords.HealthRecords);
        }
    }

    public class AddHealthRecord
    {
        private Person personExistedAfterInitialization;
        private HealthInformation healthInformationExistedAfterInitialization;
        private HealthRecordsOfAllEmployees actualEmployeeHealthRecords = new HealthRecordsOfAllEmployees();
        private HealthRecordsOfAllEmployees expectedEmployeeHealthRecords = new HealthRecordsOfAllEmployees();
        private void InitializeEmployeeRecords()
        {
            int ginNumber1 = 2003;
            string firstName1 = "shishi";
            string lastName1 = "zhang";
            personExistedAfterInitialization = new Person(ginNumber1, firstName1, lastName1);
            HealthRecordOfOneEmployee actualHealthRecord = new HealthRecordOfOneEmployee(personExistedAfterInitialization);
            HealthRecordOfOneEmployee expectedHealthRecord = new HealthRecordOfOneEmployee(personExistedAfterInitialization);

            var date1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;

            healthInformationExistedAfterInitialization = new HealthInformation(date1, myVisit, myAbnormalSymptom, myTemperature);
            actualHealthRecord.Records.Add(date1, healthInformationExistedAfterInitialization);
            actualEmployeeHealthRecords.HealthRecords.Add(ginNumber1, actualHealthRecord);

            expectedHealthRecord.Records.Add(date1, healthInformationExistedAfterInitialization);
            expectedEmployeeHealthRecords.HealthRecords.Add(ginNumber1, expectedHealthRecord);
        }

        [Fact]
        public void InputExistedPersonAndNewHealthRecordOfThePerson_ReturnTrue()
        {
            InitializeEmployeeRecords();

            var newDate = new DateTime(2010, 03, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var newHealthInformation = new HealthInformation(newDate, myVisit, myAbnormalSymptom, myTemperature);

            var actual = actualEmployeeHealthRecords.AddHealthRecord(personExistedAfterInitialization, newHealthInformation);
            Assert.True(actual);
        }
        
        [Fact]
        public void InputNewPerson_ReturnTrue()
        {
            int newGinNumber = 2002;
            string firstName = "shishi";
            string lastName = "zhang";
            Person newPerson = new Person(newGinNumber, firstName, lastName);

            var date = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(date, myVisit, myAbnormalSymptom, myTemperature);

            var actual = actualEmployeeHealthRecords.AddHealthRecord(newPerson, myHealthInformation);
            Assert.True(actual);
        }

        [Fact]
        public void InputExistedPersonAndExistedHealthRecord_ReturnFalse()
        {
            InitializeEmployeeRecords();
            var actual = actualEmployeeHealthRecords.AddHealthRecord(personExistedAfterInitialization, healthInformationExistedAfterInitialization);
            Assert.False(actual);
        }

        [Theory]
        [InlineData("shishi", "tony")]
        [InlineData("ben", "zhang")]
        public void InputPersonWithGinNumberAndNameNotMatchTheRecords_ReturnFalse(string firstName, string lastName)
        {
            InitializeEmployeeRecords();
            Person person2 = new Person(personExistedAfterInitialization.GinNumber, firstName, lastName);
            var newDate = new DateTime(2010, 03, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var newHealthInformation = new HealthInformation(newDate, myVisit, myAbnormalSymptom, myTemperature);

            var actual = actualEmployeeHealthRecords.AddHealthRecord(person2, newHealthInformation);
            Assert.False(actual);
        }


        [Fact]
        public void InputExistedPersonAndNewHealthRecord_UpdateHealthRecord()
        {
            InitializeEmployeeRecords();

            var newDate = new DateTime(2010, 03, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var newHealthInformation = new HealthInformation(newDate, myVisit, myAbnormalSymptom, myTemperature);

            expectedEmployeeHealthRecords.HealthRecords[personExistedAfterInitialization.GinNumber].Records.Add(newDate, newHealthInformation);
            actualEmployeeHealthRecords.AddHealthRecord(personExistedAfterInitialization, newHealthInformation);

            var actual = HelperMethod.IsEqual(actualEmployeeHealthRecords, expectedEmployeeHealthRecords);
            Assert.True(actual);
        }

        [Fact]
        public void InputNewPerson_UpdateRecords()
        {
            int newGinNumber = 2002;
            string firstName = "shishi";
            string lastName = "zhang";
            Person newPerson = new Person(newGinNumber, firstName, lastName);
            HealthRecordOfOneEmployee healthRecord = new HealthRecordOfOneEmployee(newPerson);

            var date = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(date, myVisit, myAbnormalSymptom, myTemperature);
            healthRecord.Records.Add(date, myHealthInformation);

            actualEmployeeHealthRecords.AddHealthRecord(newPerson, myHealthInformation);
            expectedEmployeeHealthRecords.HealthRecords.Add(newGinNumber, healthRecord);

            var actual = HelperMethod.IsEqual(actualEmployeeHealthRecords, expectedEmployeeHealthRecords);
            Assert.True(actual);
        }

        [Fact]
        public void InputExistedPersonAndExistedHealthRecord_RecordUnchanged()
        {
            InitializeEmployeeRecords();
            actualEmployeeHealthRecords.AddHealthRecord(personExistedAfterInitialization, healthInformationExistedAfterInitialization);
            var actual = HelperMethod.IsEqual(actualEmployeeHealthRecords, expectedEmployeeHealthRecords);
            Assert.True(actual);
        }

        [Theory]
        [InlineData("shishi", "tony")]
        [InlineData("ben", "zhang")]
        public void InputPersonWithGinNumberAndNameNotMatchTheRecords_RecordUnchanged(string firstName, string lastName)
        {
            InitializeEmployeeRecords();
            Person person2 = new Person(personExistedAfterInitialization.GinNumber, firstName, lastName);
            var newDate = new DateTime(2010, 03, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var newHealthInformation = new HealthInformation(newDate, myVisit, myAbnormalSymptom, myTemperature);

            actualEmployeeHealthRecords.AddHealthRecord(person2, newHealthInformation);
            var actual = HelperMethod.IsEqual(actualEmployeeHealthRecords, expectedEmployeeHealthRecords);
            Assert.True(actual);
        }
    }

    public class DeletePerson
    {
        private Person personExistedAfterInitialization;
        private HealthInformation healthInformationExistedAfterInitialization;
        private HealthRecordsOfAllEmployees actualEmployeeHealthRecords = new HealthRecordsOfAllEmployees();
        private HealthRecordsOfAllEmployees expectedEmployeeHealthRecords = new HealthRecordsOfAllEmployees();
        private void InitializeEmployeeRecords()
        {
            int ginNumber1 = 2003;
            string firstName1 = "shishi";
            string lastName1 = "zhang";
            personExistedAfterInitialization = new Person(ginNumber1, firstName1, lastName1);
            HealthRecordOfOneEmployee actualHealthRecord = new HealthRecordOfOneEmployee(personExistedAfterInitialization);

            var date1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;

            healthInformationExistedAfterInitialization = new HealthInformation(date1, myVisit, myAbnormalSymptom, myTemperature);
            actualHealthRecord.Records.Add(date1, healthInformationExistedAfterInitialization);
            actualEmployeeHealthRecords.HealthRecords.Add(ginNumber1, actualHealthRecord);
        }

        [Fact]
        public void InputExisitedPerson_ReturnTrue()
        {
            InitializeEmployeeRecords();
            var actual = actualEmployeeHealthRecords.DeletePerson(personExistedAfterInitialization);
            Assert.True(actual);
        }

        [Fact]
        public void InputNonExisitedPerson_ReturnFalse()
        {
            InitializeEmployeeRecords();
            Person nonExistedPerson = new Person(2004, "shishi", "zhang");
            var actual = actualEmployeeHealthRecords.DeletePerson(nonExistedPerson);
            Assert.False(actual);
        }

        [Fact]
        public void InputExisitedPerson_UpdateRecords()
        {
            InitializeEmployeeRecords();
            actualEmployeeHealthRecords.DeletePerson(personExistedAfterInitialization);
            var actual = HelperMethod.IsEqual(actualEmployeeHealthRecords, expectedEmployeeHealthRecords);
            Assert.True(actual);
        }

        [Fact]
        public void InputNonExisitedPerson_RecordUnchanged()
        {
            InitializeEmployeeRecords();
            HealthRecordOfOneEmployee expectedHealthRecord = new HealthRecordOfOneEmployee(personExistedAfterInitialization);
            expectedHealthRecord.Records.Add(healthInformationExistedAfterInitialization.Date, healthInformationExistedAfterInitialization);
            expectedEmployeeHealthRecords.HealthRecords.Add(personExistedAfterInitialization.GinNumber, expectedHealthRecord);

            Person nonExistedPerson = new Person(2004, "shishi", "zhang");

            actualEmployeeHealthRecords.DeletePerson(nonExistedPerson);
            var actual = HelperMethod.IsEqual(actualEmployeeHealthRecords, expectedEmployeeHealthRecords);
            Assert.True(actual);
        }
    }

    public class DeleteHealthRecord
    {
        private Person personExistedAfterInitialization;
        private HealthInformation healthInformationExistedAfterInitialization;
        private HealthRecordsOfAllEmployees actualEmployeeHealthRecords = new HealthRecordsOfAllEmployees();
        private HealthRecordsOfAllEmployees expectedEmployeeHealthRecords = new HealthRecordsOfAllEmployees();
        private void InitializeEmployeeRecords()
        {
            int ginNumber1 = 2003;
            string firstName1 = "shishi";
            string lastName1 = "zhang";
            personExistedAfterInitialization = new Person(ginNumber1, firstName1, lastName1);
            HealthRecordOfOneEmployee actualHealthRecord = new HealthRecordOfOneEmployee(personExistedAfterInitialization);
            HealthRecordOfOneEmployee expectedHealthRecord = new HealthRecordOfOneEmployee(personExistedAfterInitialization);

            var date1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;

            healthInformationExistedAfterInitialization = new HealthInformation(date1, myVisit, myAbnormalSymptom, myTemperature);

            actualHealthRecord.Records.Add(date1, healthInformationExistedAfterInitialization);
            expectedHealthRecord.Records.Add(date1, healthInformationExistedAfterInitialization);

            actualEmployeeHealthRecords.HealthRecords.Add(ginNumber1, actualHealthRecord);
            expectedEmployeeHealthRecords.HealthRecords.Add(ginNumber1, expectedHealthRecord);
        }

        [Theory]
        [InlineData(2002, "shishi", "zhang")]
        [InlineData(2003, "shishi", "tony")]
        [InlineData(2003, "tony", "trump")]
        public void InputNonExistedPerson_ReturnFalse(int ginNumber, string firstName, string lastName)
        {
            InitializeEmployeeRecords();
            Person personNotExsited = new Person(ginNumber, firstName, lastName);
            var date = new DateTime(2010, 02, 01);
            var actual = actualEmployeeHealthRecords.DeleteHealthRecord(personNotExsited, date);
            Assert.False(actual);
        }

        [Fact]
        public void InputExistedPersonAndNonExistedHealthRecord_ReturnFalse()
        {
            InitializeEmployeeRecords();
            var newDate = new DateTime(2010, 04, 01);
            var actual = actualEmployeeHealthRecords.DeleteHealthRecord(personExistedAfterInitialization, newDate);
            Assert.False(actual);
        }

        [Fact]
        public void InputExistedPersonAndExistedHealthRecord_ReturnTrue()
        {
            InitializeEmployeeRecords();
            var actual = actualEmployeeHealthRecords.DeleteHealthRecord(personExistedAfterInitialization, healthInformationExistedAfterInitialization.Date);
            Assert.True(actual);
        }

        [Theory]
        [InlineData(2002, "shishi", "zhang")]
        [InlineData(2003, "shishi", "tony")]
        [InlineData(2003, "tony", "trump")]
        public void InputNonExistedPerson_RecordsUnchanged(int ginNumber, string firstName, string lastName)
        {
            InitializeEmployeeRecords();
            Person person = new Person(ginNumber, firstName, lastName);
            var date = new DateTime(2010, 02, 01);
            actualEmployeeHealthRecords.DeleteHealthRecord(person, date);
            var actual = HelperMethod.IsEqual(actualEmployeeHealthRecords, expectedEmployeeHealthRecords);
            Assert.True(actual);
        }

        [Fact]
        public void InputExistedPersonAndNonExistedHealthRecord_RecordsUnchanged()
        {
            InitializeEmployeeRecords();
            var newDate = new DateTime(2010, 04, 01);
            actualEmployeeHealthRecords.DeleteHealthRecord(personExistedAfterInitialization, newDate);
            var actual = HelperMethod.IsEqual(actualEmployeeHealthRecords, expectedEmployeeHealthRecords);
            Assert.True(actual);
        }

        [Fact]
        public void InputExisitedPersonAndExistedHealthRecord_UpdateRecord()
        {
            InitializeEmployeeRecords();
            actualEmployeeHealthRecords.DeleteHealthRecord(personExistedAfterInitialization, healthInformationExistedAfterInitialization.Date);
            expectedEmployeeHealthRecords.HealthRecords.Remove(personExistedAfterInitialization.GinNumber);
            var actual = HelperMethod.IsEqual(actualEmployeeHealthRecords, expectedEmployeeHealthRecords);
            Assert.True(actual);
        }
    }
    
    public class HealthRecordsDataTable
    {
        private HealthRecordsOfAllEmployees employeeHealthRecords = new HealthRecordsOfAllEmployees();
        private void InitializeEmployeeHealthRecords()
        {
            int ginNumber1 = 2003;
            string firstName = "shishi";
            string lastName = "zhang";
            Person person1 = new Person(ginNumber1, firstName, lastName);
            HealthRecordOfOneEmployee helathInformation1 = new HealthRecordOfOneEmployee(person1);

            var date1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation1 = new HealthInformation(date1, myVisit, myAbnormalSymptom, myTemperature);
            helathInformation1.Records.Add(date1, myHealthInformation1);

            employeeHealthRecords.HealthRecords.Add(ginNumber1, helathInformation1);
        }

        [Fact]
        public void GetHealthRecordsDataTable_ReturnHealthRecordsDataTable()
        {
            InitializeEmployeeHealthRecords();
            String actual = $"{employeeHealthRecords.HealthRecordsDataTable.Rows[0]["GinNumber"].ToString()},{employeeHealthRecords.HealthRecordsDataTable.Rows[0]["LastName"].ToString()},{employeeHealthRecords.HealthRecordsDataTable.Rows[0]["FirstName"].ToString()},{employeeHealthRecords.HealthRecordsDataTable.Rows[0]["Date"].ToString()},{employeeHealthRecords.HealthRecordsDataTable.Rows[0]["VisitHubei"].ToString()},{employeeHealthRecords.HealthRecordsDataTable.Rows[0]["HasAbnormalSymptom"].ToString()},{employeeHealthRecords.HealthRecordsDataTable.Rows[0]["Temperature"].ToString()}";

            String expected = $"2003,zhang,shishi,2/1/2010 12:00:00 AM,True,False,37";
            Assert.Equal(expected, actual);
        }
    }

    //Validate updated result if neccessary
    public class EditHealthRecord
    {
        private HealthRecordsOfAllEmployees actualEmployeeHealthRecords = new HealthRecordsOfAllEmployees();

        private Person person1 = new Person(2003, "shishi", "zhang");
        private Person person2 = new Person(2004, "shishi", "zhang");
        private Person newPerson = new Person(2002, "shishi", "zhang");
        private Person person1WithDifferentName = new Person(2003, "tony", "zhang");
        private Person person2WithDifferentName = new Person(2004, "zhang", "zhang");

        private HealthInformation healthInformation1 = new HealthInformation(new DateTime(2010, 02, 01), true, false, 37);
        private HealthInformation healthInformation2 = new HealthInformation(new DateTime(2010, 03, 01), true, false, 37);
        private HealthInformation healthInformation3 = new HealthInformation(new DateTime(2010, 04, 01), true, false, 37);
        private HealthInformation newHealthInformation = new HealthInformation(new DateTime(2011, 02, 01), true, false, 37);

        private void InitializeEmployeeHealthRecords()
        {
            HealthRecordOfOneEmployee healthRecord = new HealthRecordOfOneEmployee(person1);
            healthRecord.Records.Add(healthInformation1.Date, healthInformation1);
            healthRecord.Records.Add(healthInformation2.Date, healthInformation2);

            HealthRecordOfOneEmployee healthRecord2 = new HealthRecordOfOneEmployee(person2);
            healthRecord2.Records.Add(healthInformation3.Date, healthInformation3);

            actualEmployeeHealthRecords.HealthRecords.Add(person1.GinNumber, healthRecord);
            actualEmployeeHealthRecords.HealthRecords.Add(person2.GinNumber, healthRecord2);
        }

        [Fact]
        public void InputExistedPersonAndExistedDate_AndNewHealthInformationOfTheSamePerson_ReturnTrue()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecord(person1, healthInformation1.Date, person1, newHealthInformation);
            Assert.True(actual);
        }

        [Fact]
        public void InputExistedPersonAndExistedDate_AndHealthInformationOfSamePersonWithDateUnchanged_ReturnTrue()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecord(person1, healthInformation1.Date, person1, healthInformation1);
            Assert.True(actual);
        }

        [Fact]
        public void InputExistedPersonAndExistedDate_AndNewHealthInformationOfNewPerson_ReturnTrue()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecord(person1, healthInformation1.Date, newPerson, newHealthInformation);
            Assert.True(actual);
        }


        [Fact]
        public void InputExistedPersonAndExistedDate_AndHealthInformationOfThePersonWithSameGinNumberAndNameNotMatchHealthRecords_ReturnFalse()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecord(person1, healthInformation1.Date, person1WithDifferentName, newHealthInformation);
            Assert.False(actual);
        }

        [Fact]
        public void InputExistedPersonAndExistedDate_AndHealthInformationOfThePersonWithAnotherExistedGinNumberAndNameNotMatchHealthRecords_ReturnFalse()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecord(person1, healthInformation1.Date, person2WithDifferentName, newHealthInformation);
            Assert.False(actual);
        }

        [Fact]
        public void InputExistedPersonAndExistedDate_AndNewHealthInformationOfAnotherExistedPerson_ReturnTrue()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecord(person1, healthInformation1.Date, person2, newHealthInformation);
            Assert.True(actual);
        }

        [Fact]
        public void InputExistedPersonAndExistedDate_AndExistedHealthInformationOfAnotherExistedPerson_ReturnFalse()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecord(person1, healthInformation1.Date, person2WithDifferentName, newHealthInformation);
            Assert.False(actual);
        }

        [Fact]
        public void InputNonExistedPerson_ReturnFalse()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecord(newPerson, healthInformation1.Date, person2WithDifferentName, newHealthInformation);
            Assert.False(actual);
        }

        [Fact]
        public void InputExistedPersonAndNonExistedDate_ReturnFalse()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecord(person1, healthInformation3.Date, person2WithDifferentName, newHealthInformation);
            Assert.False(actual);
        }
    }

    //Validate updated result if neccessary
    public class EditHealthRecordOfChosenPerson
    {
        private HealthRecordsOfAllEmployees actualEmployeeHealthRecords = new HealthRecordsOfAllEmployees();

        private Person person1 = new Person(2003, "shishi", "zhang");
        private Person person2 = new Person(2004, "shishi", "zhang");
        private Person newPerson = new Person(2002, "shishi", "zhang");
        private Person person1WithDifferentName = new Person(2003, "tony", "zhang");
        private Person person2WithDifferentName = new Person(2004, "zhang", "zhang");

        private HealthInformation healthInformation1 = new HealthInformation(new DateTime(2010, 02, 01), true, false, 37);
        private HealthInformation updatedHealthInformation1_DateUnchanged = new HealthInformation(new DateTime(2010, 02, 01), false, false, 38);

        private HealthInformation healthInformation2 = new HealthInformation(new DateTime(2010, 03, 01), true, false, 37);
        private HealthInformation healthInformation3 = new HealthInformation(new DateTime(2010, 04, 01), true, false, 37);
        private HealthInformation newHealthInformation = new HealthInformation(new DateTime(2011, 02, 01), true, false, 37);
        private void InitializeEmployeeHealthRecords()
        {
            HealthRecordOfOneEmployee healthRecord1 = new HealthRecordOfOneEmployee(person1);
            healthRecord1.Records.Add(healthInformation1.Date, healthInformation1);
            healthRecord1.Records.Add(healthInformation2.Date, healthInformation2);

            HealthRecordOfOneEmployee healthRecord2 = new HealthRecordOfOneEmployee(person2);
            healthRecord2.Records.Add(healthInformation3.Date, healthInformation3);

            actualEmployeeHealthRecords.HealthRecords.Add(person1.GinNumber, healthRecord1);
            actualEmployeeHealthRecords.HealthRecords.Add(person2.GinNumber, healthRecord2);
        }

        [Fact]
        public void InputNonExistedPerson_ReturnFalse()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecordOfChosenPerson(newPerson, healthInformation1.Date, newHealthInformation);
            Assert.False(actual);
        }

        [Fact]
        public void InputPersonWithExistedGinNumberButNameNotMatchEmployeeHealthRecords_ReturnFalse()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecordOfChosenPerson(person1WithDifferentName, healthInformation1.Date, newHealthInformation);
            Assert.False(actual);
        }

        [Fact]
        public void InputExistedPersonExistedDateAndNewHealthInformation_ReturnTrue()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecordOfChosenPerson(person1, healthInformation1.Date, newHealthInformation);
            Assert.True(actual);
        }

        [Fact]
        public void InputExistedPersonAndExistedDateAndHealthInformationWithDateUnchanged_ReturnTrue()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecordOfChosenPerson(person1, healthInformation1.Date, updatedHealthInformation1_DateUnchanged);
            Assert.True(actual);
        }

        [Fact]
        public void InputExistedPersonAndNonExistedDate_ReturnFalse()
        {
            InitializeEmployeeHealthRecords();
            var actual = actualEmployeeHealthRecords.EditHealthRecordOfChosenPerson(person1, newHealthInformation.Date, healthInformation1);
            Assert.False(actual);
        }
    }

    //Validate updated result if neccessary
    public class UpdatePerson
    {
        private HealthRecordsOfAllEmployees actualEmployeeHealthInformation = new HealthRecordsOfAllEmployees();
        private HealthInformation healthInformation1 = new HealthInformation(new DateTime(2010, 02, 01), true, false, 37);
        private HealthInformation healthInformation2 = new HealthInformation(new DateTime(2010, 03, 01), true, false, 37);

        private Person person1 = new Person(2003, "shishi", "zhang");
        private Person newPerson = new Person(2002, "shishi", "zhang");
        private Person person1WithDifferentName = new Person(2003, "tony", "zhang");
        private Person person2 = new Person(2004, "shishi", "zhang");
        private Person person2WithDifferentName = new Person(2004, "zhang", "zhang");

        private void InitializeEmployeeHealthRecords()
        {
            HealthRecordOfOneEmployee healthRecord1 = new HealthRecordOfOneEmployee(person1);
            healthRecord1.Records.Add(healthInformation1.Date, healthInformation1);
            healthRecord1.Records.Add(healthInformation2.Date, healthInformation2);

            HealthRecordOfOneEmployee healthRecord2 = new HealthRecordOfOneEmployee(person2);
            healthRecord2.Records.Add(healthInformation2.Date, healthInformation2);

            actualEmployeeHealthInformation.HealthRecords.Add(person1.GinNumber, healthRecord1);
            actualEmployeeHealthInformation.HealthRecords.Add(person2.GinNumber, healthRecord2);
        }

        private bool IsListArrayEqual(List<HealthInformation>[] listArray, List<HealthInformation>[] listArray2)
        {
            if (listArray[0].Count != listArray2[0].Count)
            {
                return false;
            }

            for (int i = 0; i < listArray[0].Count; i = i + 1)
            {
                if (listArray[0][i] != listArray2[0][i])
                {
                    return false;
                }
                if (listArray[1][i] != listArray2[1][i])
                {
                    return false;
                }
            }
            return true;
        }

        [Fact]
        public void InputNonExistedPersonToBeEdited_ReturnNull()
        {
            InitializeEmployeeHealthRecords();
            List<HealthInformation>[] actual = actualEmployeeHealthInformation.UpdatePerson(newPerson, person1);
            List<HealthInformation>[] expected = null;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputExistedPersonToBeEditedAndNewPerson_ReturnEmptyOverlappedListArray()
        {
            InitializeEmployeeHealthRecords();
            List<HealthInformation>[] actual = actualEmployeeHealthInformation.UpdatePerson(person1, newPerson);
            var expected = new List<HealthInformation>[] { new List<HealthInformation>(), new List<HealthInformation>() };
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void InputExistedPersonToBeEditedAndPersonWithSameGinNumberAndDifferentName_ReturnEmptyOverlappedListArray()
        {
            InitializeEmployeeHealthRecords();
            List<HealthInformation>[] actual = actualEmployeeHealthInformation.UpdatePerson(person1, person1WithDifferentName);
            var expected = new List<HealthInformation>[] { new List<HealthInformation>(), new List<HealthInformation>() };
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void InputExistedPersonToBeEditedAndAnotherExistedPerson_ReturnOverlappedListArray()
        {
            InitializeEmployeeHealthRecords();
            List<HealthInformation>[] actual = actualEmployeeHealthInformation.UpdatePerson(person1, person2);
            List<HealthInformation> overlappedHealthInformation_PersonToBeEdited = new List<HealthInformation>();
            List<HealthInformation> overlappedHealthInformation_PersonAfterEdit = new List<HealthInformation>();

            overlappedHealthInformation_PersonToBeEdited.Add(healthInformation2);
            overlappedHealthInformation_PersonAfterEdit.Add(healthInformation2);

            var expected = new List<HealthInformation>[] { overlappedHealthInformation_PersonToBeEdited, overlappedHealthInformation_PersonAfterEdit };

            bool compareResult = IsListArrayEqual(expected, actual);
            Assert.True(compareResult);
        }

        [Fact]
        public void InputExistedPersonToBeEditedAndPersonWithExistedGinNumberAndNameNotMatchHealthRecords_ReturnNull()
        {
            InitializeEmployeeHealthRecords();
            List<HealthInformation>[] actual = actualEmployeeHealthInformation.UpdatePerson(person1, person2WithDifferentName);
            List<HealthInformation>[] expected = null;
            Assert.Equal(expected, actual);
        }
    }
  
    public class HelperMethod
    {
        //Test helpher method or override Equals methods in data model later (Is it neccessary to override the Equals method since the equal method will not be used other than used in test.).
        public static bool IsEqual(HealthRecordsOfAllEmployees actualEmployeeHealthRecords, HealthRecordsOfAllEmployees expectedEmployeeHealthRecords)
        {
            if (actualEmployeeHealthRecords.HealthRecords.Count != expectedEmployeeHealthRecords.HealthRecords.Count)
            {
                return false;
            }

            foreach (var ginNumber in actualEmployeeHealthRecords.HealthRecords.Keys)
            {
                if (!expectedEmployeeHealthRecords.HealthRecords.ContainsKey(ginNumber))
                {
                    return false;
                }
                else
                {
                    HealthRecordOfOneEmployee healthRecordExpected = expectedEmployeeHealthRecords.HealthRecords[ginNumber];
                    HealthRecordOfOneEmployee healthRecordActual = actualEmployeeHealthRecords.HealthRecords[ginNumber];
                    if (healthRecordExpected.Person.GinNumber != healthRecordActual.Person.GinNumber || healthRecordExpected.Person.FirstName != healthRecordActual.Person.FirstName || healthRecordExpected.Person.LastName != healthRecordActual.Person.LastName)
                    {
                        return false;
                    }
                    else if (healthRecordExpected.Records.Count != healthRecordActual.Records.Count)
                    {
                        return false;
                    }
                    else
                    {
                        foreach (var date in healthRecordActual.Records.Keys)
                        {
                            if (!healthRecordExpected.Records.ContainsKey(date))
                            {
                                return false;
                            }

                            if (healthRecordExpected.Records[date].Date != healthRecordActual.Records[date].Date || healthRecordExpected.Records[date].VisitHubei != healthRecordActual.Records[date].VisitHubei || healthRecordExpected.Records[date].HasAbnormalSymptom != healthRecordActual.Records[date].HasAbnormalSymptom || healthRecordExpected.Records[date].BodyTemperature != healthRecordActual.Records[date].BodyTemperature)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
