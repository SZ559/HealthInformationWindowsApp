using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeHealthRecord;

namespace WindowsApp
{
    public partial class OverlappedHealthInformationForm : Form
    {
        Person personToBeOverwritten;
        List<HealthInformation> healthRecordsToBeOverwritten;
        Person person;
        List<HealthInformation> healthRecords;
        internal event OverwriteHealthRecord overwriteHealthRecord;
        internal event EventHandler statusBarUpdate_SubFormClosed;

        public OverlappedHealthInformationForm(Person personToBeOverwritten, List<HealthInformation> healthRecordsToBeOverwritten, Person person, List<HealthInformation> healthRecord)
        {
            InitializeComponent();         
            this.person = person;
            this.healthRecords = healthRecord;
            this.personToBeOverwritten = personToBeOverwritten;
            this.healthRecordsToBeOverwritten = healthRecordsToBeOverwritten;
            dataGridViewOfHealthRecordsToBeOverwritten.Scroll += new ScrollEventHandler(DataGridViewOfhealthRecordsToBeOverwritten_Scroll);
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridViewOfHealthRecords.Rows.Clear();
            dataGridViewOfHealthRecordsToBeOverwritten.Rows.Clear();
            for(int i = 0; i < healthRecords.Count; i = i + 1)
            {
                HealthInformation healthInformationToBeOverWritten = healthRecordsToBeOverwritten[i];
                dataGridViewOfHealthRecordsToBeOverwritten.Rows.Add(personToBeOverwritten.GinNumber, personToBeOverwritten.LastName, personToBeOverwritten.FirstName, healthInformationToBeOverWritten.Date.ToShortDateString(), healthInformationToBeOverWritten.VisitHubei, healthInformationToBeOverWritten.HasAbnormalSymptom, healthInformationToBeOverWritten.BodyTemperature);

                HealthInformation healthInformation = healthRecords[i];
                dataGridViewOfHealthRecords.Rows.Add(person.GinNumber, person.LastName, person.FirstName, healthInformation.Date.ToShortDateString(), healthInformation.VisitHubei, healthInformation.HasAbnormalSymptom, healthInformation.BodyTemperature);
            }
        }

        private void OverwriteButton_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridViewOfHealthRecords.CurrentRow;
            HealthInformation selectedHealthInformaton = ConvertCurrentRowToHealthInformation(currentRow);

            var rowOfHealthRecordToBeOverwritten = dataGridViewOfHealthRecordsToBeOverwritten.Rows[currentRow.Index];
            HealthInformation healthInformatonToBeOverwritten = ConvertCurrentRowToHealthInformation(currentRow);

            overwriteHealthRecord(personToBeOverwritten, healthInformatonToBeOverwritten, person, selectedHealthInformaton);
            healthRecords.RemoveAt(currentRow.Index);
            healthRecordsToBeOverwritten.RemoveAt(rowOfHealthRecordToBeOverwritten.Index);
            UpdateDataGridView();
            
            if (healthRecordsToBeOverwritten.Count == 0)
            {
                Close();
            }
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            healthRecords.RemoveAt(dataGridViewOfHealthRecords.CurrentRow.Index);
            healthRecordsToBeOverwritten.RemoveAt(dataGridViewOfHealthRecords.CurrentRow.Index);
            UpdateDataGridView();
            if (healthRecordsToBeOverwritten.Count == 0)
            {
                Close();
            }
        }

        private void OverwriteAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < healthRecords.Count; i = i + 1)
            {
                overwriteHealthRecord(personToBeOverwritten, healthRecordsToBeOverwritten[i], person, healthRecords[i]);
            }
            MessageBox.Show("All health records have been overwritten.");
            Close();
        }

        private void SkipAllButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All health records keep unchanged.");
            Close();
        }

        private void DataGridViewOfhealthRecordsToBeOverwritten_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridViewOfHealthRecordsToBeOverwritten.FirstDisplayedScrollingRowIndex = dataGridViewOfHealthRecords.FirstDisplayedScrollingRowIndex;
        }

        private void DataGridViewOfHealthRecords_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOfHealthRecords.CurrentRow != null)
            {
                dataGridViewOfHealthRecordsToBeOverwritten.ClearSelection();
                int currentIndex = dataGridViewOfHealthRecords.CurrentRow.Index;
                dataGridViewOfHealthRecordsToBeOverwritten.Rows[currentIndex].Selected = true;
            }
        }

        private HealthInformation ConvertCurrentRowToHealthInformation(DataGridViewRow currentRow)
        {
            var selectedDate = DateTime.Parse((string)currentRow.Cells[3].Value);
            bool visitHubei = (bool)currentRow.Cells[4].Value;
            bool hasAbnormalSymptom = (bool)currentRow.Cells[5].Value;
            double bodyTemperature = (double)currentRow.Cells[6].Value;
            return new HealthInformation(selectedDate, visitHubei, hasAbnormalSymptom, bodyTemperature);
        }

        private void FormForAddAndEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            statusBarUpdate_SubFormClosed?.Invoke(sender, FormClosedEventArgs.Empty);
        }
    }
}
