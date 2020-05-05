using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public class FilterOperationUseless
    {
        private string filter = "";
        public string Filter
        {
            get
            {
                return filter;
            }
            set
            {
                filter = value;
            }
        }
 
        public void AddFilter(string filterToBeAdded)
        {
            if (filter != "" && filterToBeAdded != "")
            {
                filter = filter + " AND ";
            }
            filter = filter + filterToBeAdded;
        }
        public void RemoveFilter(string filterToBeRemoved)
        {
            string logicOperator = " AND ";
            if (filterToBeRemoved == "" || filter.IndexOf(filterToBeRemoved) < 0)
            {
                return;
            }
            else if (filter == filterToBeRemoved)
            {
                filter = "";
            }
            else
            {
                string subStringToBeRemoved = logicOperator + filterToBeRemoved;
                int index = filter.IndexOf(subStringToBeRemoved);
                if (index < 0)
                {
                    subStringToBeRemoved = filterToBeRemoved + logicOperator;
                    index = filter.IndexOf(subStringToBeRemoved);
                }
                filter = filter.Remove(index, subStringToBeRemoved.Length);
            }
        }
        public string UpdateFilter_BasedOnCheckBox(CheckBox checkBox, string filterString)
        {
            if (checkBox.Checked)
            {
                AddFilter(filterString);
            }
            else
            {
                RemoveFilter(filterString);
            }
            return filter;
        }

        public string FilterDateTime_MonthAndYearFilter(DateTime myDateTimeMax, DateTime myDateTimeMin)
        {
            string filterString = String.Format("(Date <= '{0:MM/dd/yyyy}' AND Date >= '{1:MM/dd/yyyy}')", myDateTimeMax, myDateTimeMin);
            AddFilter(filterString);
            return filterString;
        }
        public string FilterDateTimeFilter(DateTime myDateTime)
        {
            string filterString = String.Format("(Date = '{0:MM/dd/yyyy}')", myDateTime);
            AddFilter(filterString);
            return filterString;
        }
    }
}
