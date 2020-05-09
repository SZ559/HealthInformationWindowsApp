using System;
using Xunit;
using EmployeeHealthRecord;

namespace HealthInformationTest
{
    public class DateProperty
    {
        [Fact]
        public void GetDate_ReturnDate()
        {
            DateTime myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            Assert.Equal(myDate, myHealthInformation.Date);
        }

        [Fact]
        public void SetDate_UpdateDate()
        {
            DateTime myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            DateTime expectedDate = new DateTime(2011, 02, 01);
            myHealthInformation.Date = expectedDate;
            Assert.Equal(expectedDate, myHealthInformation.Date);
        }
    }

    public class IsSuspected
    {
        [Theory]
        [InlineData(true, false, 37)]
        [InlineData(true, false, 40)]
        [InlineData(true, true, 37)]
        [InlineData(true, true, 40)]
        public void InputPersonVisitHubeRecently_ReturnSuspectedCaseIsTrue(bool myVisit, bool myAbnormalSymptom, double myTemperature)
        {
            DateTime myDate = new DateTime(2010, 02, 01);
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);

            var actual = myHealthInformation.IsSuspected();

            Assert.True(actual);
        }

        [Theory]
        [InlineData(true, true, 37)]
        [InlineData(true, true, 40)]
        [InlineData(false, true, 37)]
        [InlineData(false, true, 40)]
        public void InputPersonHasAbnormalSymptom_ReturnSuspectedCaseIsTrue(bool myVisit, bool myAbnormalSymptom, double myTemperature)
        {
            DateTime myDate = new DateTime(2010, 02, 01);
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            var actual = myHealthInformation.IsSuspected();

            Assert.True(actual);
        }

        [Theory]
        [InlineData(true, true, 37.4)]
        [InlineData(true, false, 37.5)]
        [InlineData(false, true, 40)]
        [InlineData(false, false, 37.8)]
        public void InputPersonWithBodyTemperatureMoreThanThirtySevenPointThreeDegree_ReturnSuspectedCaseIsTrue(bool myVisit, bool myAbnormalSymptom, double myTemperature)
        {
            DateTime myDate = new DateTime(2010, 02, 01);
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            var actual = myHealthInformation.IsSuspected();
            Assert.True(actual);
        }

        [Theory]
        [InlineData(false, false, 37.3)]
        [InlineData(false, false, 37)]
        public void InputPersonHasNotVisitedHubeiRecentlyAndHasNoAbnormalSymptomAndHasBodyTemperatureSmallerAndEqualToThirtySevenPointThreeDegree_ReturnSuspectedCaseIsFalse(bool myVisit, bool myAbnormalSymptom, double myTemperature)
        {
            DateTime myDate = new DateTime(2010, 02, 01);
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            var actual = myHealthInformation.IsSuspected();

            Assert.False(actual);
        }
    }
    public class ToString
    {
        [Fact]
        public void InputHealthInformation_ReturnStringOfHealthInformation()
        {
            DateTime myDate = new DateTime(2010, 02, 01);
            var myVisit = true;
            var myAbnormalSymptom = false;
            double myTemperature = 37;
            var myHealthInformation = new HealthInformation(myDate, myVisit, myAbnormalSymptom, myTemperature);
            var expected = "2/1/2010,True,False,37";
            var actual = myHealthInformation.ToString();
            Assert.Equal(expected, actual);
        }
    }
}

