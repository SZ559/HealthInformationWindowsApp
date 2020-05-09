using System;
using Xunit;
using EmployeeHealthRecord;

namespace HealthRecordOfOneEmployeeTest
{
    public class AddHealthInformation
    {
        private HealthRecordOfOneEmployee expectedEmployeeHealthInforation = new HealthRecordOfOneEmployee(new Person(2003, "shishi", "zhang"));
        private HealthRecordOfOneEmployee actualEmployeeHealthInformation = new HealthRecordOfOneEmployee(new Person(2003, "shishi", "zhang"));

        [Fact]
        public void InputExistedHealthInformation_ReturnFalse()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);

            actualEmployeeHealthInformation.Records.Add(myDate, myHealthInformation);

            bool actual = actualEmployeeHealthInformation.AddHealthInformation(myHealthInformation);
            Assert.False(actual);
        }

        [Fact]
        public void InputNewHealthInformation_ReturnTrue()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);

            var myDate2 = new DateTime(2012, 02, 01);
            var newHealthInformation = new HealthInformation(myDate2, myVisit, myAbnormalSymptom, myTemperature);

            bool actual = actualEmployeeHealthInformation.AddHealthInformation(newHealthInformation);
            Assert.True(actual);
        }

        [Fact]
        public void InputNewHealthInformation_UpdatedHealthRecord()
        {
            var date = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(date, myVisit, myAbnormalSymptom, myTemperature);
            expectedEmployeeHealthInforation.Records.Add(date, myHealthInformation);
            actualEmployeeHealthInformation.Records.Add(date, myHealthInformation);

            var myDate2 = new DateTime(2012, 02, 01);
            var myHealthInformation2 = new HealthInformation(myDate2, myVisit, myAbnormalSymptom, myTemperature);
            expectedEmployeeHealthInforation.Records.Add(myDate2, myHealthInformation2);
            actualEmployeeHealthInformation.AddHealthInformation(myHealthInformation2);

            Assert.Equal(expectedEmployeeHealthInforation.Records, actualEmployeeHealthInformation.Records);
        }
    }

    public class DeleteHealthInformation
    { 
        private HealthRecordOfOneEmployee expectedEmployeeHealthInforation = new HealthRecordOfOneEmployee(new Person(2003, "shishi", "zhang"));
        private HealthRecordOfOneEmployee actualEmployeeHealthInformation = new HealthRecordOfOneEmployee(new Person(2003, "shishi", "zhang"));

        [Fact]
        public void InputNonExistedDate_ReturnFalse()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);

            bool actual = actualEmployeeHealthInformation.DeleteHealthInformation(myHealthInformation.Date); ;
            Assert.False(actual);
        }

        [Fact]
        public void InputExistedDate_ReturnTrue()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(myDate, myHealthInformation);
            bool actual = actualEmployeeHealthInformation.DeleteHealthInformation(myHealthInformation.Date);
            Assert.True(actual);
        }

        [Fact]
        public void InputExistedDate_UpdatedHealthRecord()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            
            var myDate2 = new DateTime(2010, 03, 01);
            var myHealthInformation2 = new HealthInformation(myDate2, myVisit, myAbnormalSymptom, myTemperature);

            actualEmployeeHealthInformation.Records.Add(myDate, myHealthInformation);
            expectedEmployeeHealthInforation.Records.Add(myDate, myHealthInformation);
            actualEmployeeHealthInformation.Records.Add(myDate2, myHealthInformation2);

            bool actual = actualEmployeeHealthInformation.DeleteHealthInformation(myHealthInformation2.Date);
            Assert.Equal(expectedEmployeeHealthInforation.Records, actualEmployeeHealthInformation.Records);
        }

        [Fact]
        public void InputNotExistedDate_NotUpdatedHealthRecord()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);

            var myDate2 = new DateTime(2010, 03, 01);
            var myHealthInformation2 = new HealthInformation(myDate2, myVisit, myAbnormalSymptom, myTemperature);

            actualEmployeeHealthInformation.Records.Add(myDate, myHealthInformation);
            expectedEmployeeHealthInforation.Records.Add(myDate, myHealthInformation);

            bool actual = actualEmployeeHealthInformation.DeleteHealthInformation(myHealthInformation2.Date);
            Assert.Equal(expectedEmployeeHealthInforation.Records, actualEmployeeHealthInformation.Records);
        }
    }

    public class ModifyHealthInformation
    {
        private HealthRecordOfOneEmployee expectedEmployeeHealthInforation = new HealthRecordOfOneEmployee(new Person(2003, "shishi", "zhang"));
        private HealthRecordOfOneEmployee actualEmployeeHealthInformation = new HealthRecordOfOneEmployee(new Person(2003, "shishi", "zhang"));

        [Fact]
        public void InputNotExistedDate_ReturnFalse()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(myDate, myHealthInformation);

            var notExistedDate = new DateTime(2010, 03, 01);
            double updatedTemperature = 38;
            var updatedHealthInformation = new HealthInformation(notExistedDate, myVisit, myAbnormalSymptom, updatedTemperature);

            bool actual = actualEmployeeHealthInformation.ModifyHealthInformation(notExistedDate, updatedHealthInformation);;
            Assert.False(actual);
        }

        [Fact]
        public void InputExistedDateAndExistedUpdatedHealthInformationWithDifferentDate_ReturnFalse()
        {
            var existedDate1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var existedHealthInformation1 = new HealthInformation(existedDate1, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(existedDate1, existedHealthInformation1);

            var existedDate2 = new DateTime(2010, 03, 01);
            var existedHealthInformation2 = new HealthInformation(existedDate2, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(existedDate2, existedHealthInformation2);

            bool actual = actualEmployeeHealthInformation.ModifyHealthInformation(existedHealthInformation2.Date, existedHealthInformation1); ;
            Assert.False(actual);
        }

        [Fact]
        public void InputExistedDateAndUpdatedHealthInformationWithSameDate_ReturnTrue()
        {
            var existedDate1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var existedHealthInformation1 = new HealthInformation(existedDate1, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(existedDate1, existedHealthInformation1);

            var myVisitUpdated = false;
            var updatedHealthInformation = new HealthInformation(existedDate1, myVisitUpdated, myAbnormalSymptom, myTemperature);

            bool actual = actualEmployeeHealthInformation.ModifyHealthInformation(existedHealthInformation1.Date, updatedHealthInformation); ;

            Assert.True(actual);
        }

        [Fact]
        public void InputExistedDateAndNewUpdatedHealthInformation_ReturnTrue()
        {
            var existedDate1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var existedHealthInformation1 = new HealthInformation(existedDate1, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(existedDate1, existedHealthInformation1);

            var newDate = new DateTime(2010, 03, 01);
            var myVisitUpdated = false;
            var updatedHealthInformation = new HealthInformation(newDate, myVisitUpdated, myAbnormalSymptom, myTemperature);

            bool actual = actualEmployeeHealthInformation.ModifyHealthInformation(existedDate1, updatedHealthInformation); 
            Assert.True(actual);
        }

        [Fact]
        public void InputNotExistedDate_NotUpdateRecords()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(myDate, myHealthInformation);
            expectedEmployeeHealthInforation.Records.Add(myDate, myHealthInformation);

            var dateNotExisted = new DateTime(2010, 03, 01);
            double updatedTemperature = 38;
            var updatedHealthInformation = new HealthInformation(dateNotExisted, myVisit, myAbnormalSymptom, updatedTemperature);

            actualEmployeeHealthInformation.ModifyHealthInformation(dateNotExisted, updatedHealthInformation); ;
            Assert.Equal(expectedEmployeeHealthInforation.Records, actualEmployeeHealthInformation.Records);
        }

        [Fact]
        public void InputExistedDateAndExistedUpdatedHealthInformationWithDifferentDate_NotUpdateRecords()
        {
            var existedDate1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var existedHealthInformation1 = new HealthInformation(existedDate1, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(existedDate1, existedHealthInformation1);
            expectedEmployeeHealthInforation.Records.Add(existedDate1, existedHealthInformation1);

            var existedDate2 = new DateTime(2010, 03, 01);
            var existedHealthInformation2 = new HealthInformation(existedDate2, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(existedDate2, existedHealthInformation2);
            expectedEmployeeHealthInforation.Records.Add(existedDate2, existedHealthInformation2);

            bool actual = actualEmployeeHealthInformation.ModifyHealthInformation(existedHealthInformation2.Date, existedHealthInformation1); ;
            Assert.Equal(expectedEmployeeHealthInforation.Records, actualEmployeeHealthInformation.Records);
        }

        [Fact]
        public void InputExistedDateAndUpdatedHealthInformationWithSameDate_UpdatedRecords()
        {
            var existedDate1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var existedHealthInformation1 = new HealthInformation(existedDate1, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(existedDate1, existedHealthInformation1);

            var myVisitUpdated = false;
            var existedHealthInformation2 = new HealthInformation(existedDate1, myVisitUpdated, myAbnormalSymptom, myTemperature);
            expectedEmployeeHealthInforation.Records.Add(existedDate1, existedHealthInformation2);
            actualEmployeeHealthInformation.ModifyHealthInformation(existedHealthInformation1.Date, existedHealthInformation2); ;

            Assert.Equal(expectedEmployeeHealthInforation.Records, actualEmployeeHealthInformation.Records);
        }

        [Fact]
        public void InputExistedDateAndNewUpdatedHealthInformation_UpdateRecords()
        {
            var existedDate1 = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var existedHealthInformation1 = new HealthInformation(existedDate1, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(existedDate1, existedHealthInformation1);

            var newDate = new DateTime(2010, 03, 01);
            var myVisitUpdated = false;
            var updatedHealthInformation = new HealthInformation(newDate, myVisitUpdated, myAbnormalSymptom, myTemperature);
            expectedEmployeeHealthInforation.Records.Add(newDate, updatedHealthInformation);
            actualEmployeeHealthInformation.ModifyHealthInformation(existedDate1, updatedHealthInformation);

            Assert.Equal(expectedEmployeeHealthInforation.Records, actualEmployeeHealthInformation.Records);
        }
    }

    public class IsEmpty
    {
        private HealthRecordOfOneEmployee actualEmployeeHealthInformation = new HealthRecordOfOneEmployee(new Person(2003, "shishi", "zhang"));

        [Fact]
        public void EmployeeHealthRecordHasZeroRecord_ReturnTrue()
        {
            var actual = actualEmployeeHealthInformation.IsEmpty();
            Assert.True(actual);
        }

        [Fact]
        public void EmployeeHealthRecordHasMoreThanZeroRecord_ReturnFalse()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(myDate, myHealthInformation);
            var actual = actualEmployeeHealthInformation.IsEmpty();
            Assert.False(actual);
        }
    }

    public class ContainsHealthInformation
    {
        private HealthRecordOfOneEmployee actualEmployeeHealthInformation = new HealthRecordOfOneEmployee(new Person(2003, "shishi", "zhang"));

        [Fact]
        public void InputExistedDate_ReturnTrue()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(myDate, myHealthInformation);

            var actual = actualEmployeeHealthInformation.ContainsHealthInformation(myDate);
            Assert.True(actual);
        }

        [Fact]
        public void InputNotExistedDate_ReturnFalse()
        {
            var myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            actualEmployeeHealthInformation.Records.Add(myDate, myHealthInformation);

            var date2 = new DateTime(2010, 03, 01);
            var actual = actualEmployeeHealthInformation.ContainsHealthInformation(date2);
            Assert.False(actual);
        }
    }
}
