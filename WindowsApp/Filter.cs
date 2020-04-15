using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public class FilterOperation
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
            if (filter != "")
            {
                filter = filter + " AND ";
            }
            filter = filter + filterToBeAdded;
        }
        public void RemoveFilter(string filterToBeRemoved)
        {
            string logicOperator = " AND ";
            if (filter.IndexOf(filterToBeRemoved) < 0)
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
        public string UpdateFilter(CheckBox checkBox, string filterString)
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
    }
}
