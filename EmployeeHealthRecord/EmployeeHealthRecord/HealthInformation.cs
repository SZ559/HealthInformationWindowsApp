using System;

namespace EmployeeHealthRecord
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

        public bool VisitHubei{ get; set; }

        public bool HasAbnormalSymptom{ get; set; }

        public double BodyTemperature{ get; set; }

        public HealthInformation(DateTime date, bool myVisit, bool myAbnormalSymptom, double myTemperature)
        {
            this.date = date.Date;
            VisitHubei = myVisit;
            HasAbnormalSymptom = myAbnormalSymptom;
            BodyTemperature = myTemperature;
        }

        public bool IsSuspected()
        {
            if (BodyTemperature > 37.3 || HasAbnormalSymptom == true || VisitHubei == true)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return date.ToShortDateString() + "," + VisitHubei.ToString() + "," + HasAbnormalSymptom.ToString() + "," + BodyTemperature.ToString();
        }
    }
}
