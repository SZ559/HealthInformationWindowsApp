using System;
using System.Windows.Forms;

namespace WindowsApp
{
    public class FilterOperation
    {
        private string visitedHubeiFilter;
        private string hasAbnormalSymptomFilter;
        private string suspectedCaseFilter;
        private string dateFilter;
        private string ginNumberFilter;
        private string treeviewDateFilter;
        private string treeviewNameFilter;
        private string filter;

        public string Filter
        {
            get
            {
                filter = "";
                AddFilter(visitedHubeiFilter);
                AddFilter(hasAbnormalSymptomFilter);
                AddFilter(suspectedCaseFilter);
                AddFilter(dateFilter);
                AddFilter(ginNumberFilter);
                AddFilter(treeviewDateFilter);
                AddFilter(treeviewNameFilter);
                return filter;
            }
        }

        public string GinNumberFilter
        {
            set
            {
                ginNumberFilter = value;
            }
        }

        public string TreeviewDateFilter
        {
            set
            {
                treeviewDateFilter = value;
            }
        }

        public string TreeviewNameFilter
        {
            set
            {
                treeviewNameFilter = value;
            }
        }

        public void AddFilter(string filterString)
        {
            if (filterString != "")
            {
                if (filter != "")
                {
                    filter = filter + " AND ";
                }
                filter = filter + filterString;
            }
        }
 
        public void ClearFilter()
        {
            visitedHubeiFilter = "";
            hasAbnormalSymptomFilter = "";
            suspectedCaseFilter = "";
            dateFilter = "";
            ginNumberFilter = "";
            treeviewDateFilter = "";
            treeviewNameFilter = "";
        }

        public void UpdateFilter_BasedOnCheckBox(CheckBox checkBox, string filterOption)
        {
            if (checkBox.Checked)
            {
                switch (filterOption)
                {
                    case "VisitedHubeiFilter":
                        visitedHubeiFilter = "VisitHubei = 'True'";
                        break;
                    case "HasAbnormalSymptomFilter":
                        hasAbnormalSymptomFilter = "HasAbnormalSymptom = 'True'";
                        break;
                    case "SuspectedCaseFilter":
                        suspectedCaseFilter = "(VisitHubei = 'True' OR HasAbnormalSymptom = 'True' OR Temperature > 37.3)";
                        break;
                }
            }
            else
            {
                switch (filterOption)
                {
                    case "VisitedHubeiFilter":
                        visitedHubeiFilter = "";
                        break;
                    case "HasAbnormalSymptomFilter":
                        hasAbnormalSymptomFilter = "";
                        break;
                    case "SuspectedCaseFilter":
                        suspectedCaseFilter = "";
                        break;
                }
            }
        }

        public void UpdateFilter_Date(DateTime myDateTime, bool applyFilter)
        {
            if (applyFilter)
            {
                dateFilter = String.Format("(Date = '{0:MM/dd/yyyy}')", myDateTime);
            }
            else
            {
                dateFilter = "";
            }    
        }

        public void UpdateFilter_TreeViewDateFilter_FilterYearOrMonth(DateTime myDateTimeMin, DateTime myDateTimeMax)
        {
            treeviewDateFilter = String.Format("(Date <= '{0:MM/dd/yyyy}' AND Date >= '{1:MM/dd/yyyy}')", myDateTimeMax, myDateTimeMin);
        }

        public void UpdateFilter_TreeViewDateFilter_FilterDate(DateTime myDateTime)
        {
            treeviewDateFilter = String.Format("(Date = '{0:MM/dd/yyyy}')", myDateTime);
        }
    }
}
