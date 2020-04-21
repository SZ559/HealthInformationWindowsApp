using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public class HealthInformation
    {
        private DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value.Date;
            }
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

        public HealthInformation(DateTime date, bool myVisit, bool myAbnormalSymptom, double myTemperature)
        {
            this.date = date.Date;
            VisitHubei = myVisit;
            HasAbnormalSymptom = myAbnormalSymptom;
            Temperature = myTemperature;
        }

        public bool IsSuspected()
        {
            if (Temperature > 37.3 || HasAbnormalSymptom == true || VisitHubei == true)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return date.ToShortDateString() + "," + VisitHubei.ToString() + "," + HasAbnormalSymptom.ToString() + "," + Temperature.ToString();
        }
    }
}
