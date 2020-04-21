using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInformation;

namespace WindowsApp
{
    public partial class OverlapedHealthInformationForm : Form
    {
        Person originalPerson;
        Person updatedPerson;
        List<HealthInformation> repeatedHealthInformation;
        List<HealthInformation> healthInformationOfUpdatedPerson;
        HealthInformation selectedOriginalHealthInformaton = null;
        HealthInformation selectedUpdatedHealthInformaton = null;
        internal event ReplaceHealthInformation replaceHealthInformation;
        internal event EventHandler statusBarUpdate_SubFormClosed;
        public OverlapedHealthInformationForm(Person originalPerson, List<HealthInformation> repeatedHealthInformation, Person updatedPerson, List<HealthInformation> updatedHealthInformation)
        {
            InitializeComponent();
            this.originalPerson = originalPerson;
            this.updatedPerson = updatedPerson;
            this.repeatedHealthInformation = repeatedHealthInformation;
            this.healthInformationOfUpdatedPerson = updatedHealthInformation;
            updatedPersonDataGridView.Scroll += new ScrollEventHandler(originalPersonDataGridView2_Scroll);
            DataGridViewDisplay();
        }
        private void DataGridViewDisplay()
        {
            originalPersonDataGridView2.Rows.Clear();
            originalPersonDataGridView2.Refresh();
            updatedPersonDataGridView.Rows.Clear();
            updatedPersonDataGridView.Refresh();
            for(int i = 0; i < repeatedHealthInformation.Count; i = i + 1)
            {
                HealthInformation updatedHealthInformation = healthInformationOfUpdatedPerson[i];
                updatedPersonDataGridView.Rows.Add(updatedPerson.GinNumber, updatedPerson.LastName, updatedPerson.FirstName, updatedHealthInformation.Date.ToShortDateString(), updatedHealthInformation.VisitHubei, updatedHealthInformation.HasAbnormalSymptom, updatedHealthInformation.Temperature);

                HealthInformation originalHealthInformation = repeatedHealthInformation[i];

                originalPersonDataGridView2.Rows.Add(originalPerson.GinNumber, originalPerson.LastName, originalPerson.FirstName, originalHealthInformation.Date.ToShortDateString(), originalHealthInformation.VisitHubei, originalHealthInformation.HasAbnormalSymptom, originalHealthInformation.Temperature);
            }
        }

        private void originalPersonDataGridView2_Scroll(object sender, ScrollEventArgs e)
        {
            updatedPersonDataGridView.FirstDisplayedScrollingRowIndex = originalPersonDataGridView2.FirstDisplayedScrollingRowIndex;
        }

        private void originalPersonDataGridView2_SelectionChanged(object sender, EventArgs e)
        {

            selectedOriginalHealthInformaton = null;
            selectedUpdatedHealthInformaton = null;
            if (originalPersonDataGridView2.RowCount > 0)
            {

                var currentRow = originalPersonDataGridView2.CurrentRow;
                var selectedDate = DateTime.Parse((string) currentRow.Cells["date"].Value);

                bool visitHubei = (bool)currentRow.Cells[4].Value;
                bool hasAbnormalSymptom = (bool)currentRow.Cells["hasAbnormalSymptom"].Value;
                double temperature = (double)currentRow.Cells["temperature"].Value;
                selectedOriginalHealthInformaton = new HealthInformation(selectedDate, visitHubei, hasAbnormalSymptom, temperature);

                int index = originalPersonDataGridView2.CurrentRow.Index;
                updatedPersonDataGridView.ClearSelection();
                updatedPersonDataGridView.Rows[index].Selected = true;
                var currentRow2 = updatedPersonDataGridView.Rows[index];
                var selectedDate2 = DateTime.Parse((string)currentRow2.Cells["date2"].Value);
                bool visitHubei2 = (bool)currentRow2.Cells["visitedHubei2"].Value;
                bool hasAbnormalSymptom2 = (bool)currentRow2.Cells["hasAbnormalSymptom2"].Value;
                double temperature2 = (double)currentRow2.Cells["temperature2"].Value;
                selectedUpdatedHealthInformaton = new HealthInformation(selectedDate2, visitHubei2, hasAbnormalSymptom2, temperature2);
            }

        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            replaceHealthInformation(updatedPerson, selectedUpdatedHealthInformaton, originalPerson, selectedOriginalHealthInformaton);
            repeatedHealthInformation.RemoveAt(originalPersonDataGridView2.CurrentRow.Index);
            healthInformationOfUpdatedPerson.RemoveAt(originalPersonDataGridView2.CurrentRow.Index);
            DataGridViewDisplay();
            if (healthInformationOfUpdatedPerson.Count == 0)
            {
                Close();
            }
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            repeatedHealthInformation.RemoveAt(originalPersonDataGridView2.CurrentRow.Index);
            healthInformationOfUpdatedPerson.RemoveAt(originalPersonDataGridView2.CurrentRow.Index);
            DataGridViewDisplay();
            if (healthInformationOfUpdatedPerson.Count == 0)
            {
                Close();
            }
        }

        private void ReplaceAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < repeatedHealthInformation.Count; i = i + 1)
            {
                replaceHealthInformation(updatedPerson, healthInformationOfUpdatedPerson[i], originalPerson, repeatedHealthInformation[i]);
            }
            MessageBox.Show("All repeated health informations have been replaced.", "Confirm", MessageBoxButtons.OK);
            Close();
        }

        private void skipAllButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The gin number and name of repeated health record is unchanged.", "Confirm", MessageBoxButtons.OK);
            Close();
        }
    }
}
