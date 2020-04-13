using System;
using System.Linq;
using System.Windows.Forms;
using FileOperation;
using EmployeeInformation;
using DatabaseOperation;
using System.Security.AccessControl;

namespace WindowsApp
{
    public partial class MainMenuForm : Form
    {
        private HealthDatabase myHealthRecord;
        private FormForAddAndEdit formForEnterAndEdit;
        private string filter = "";
        private int selectGinNumber;
        public MainMenuForm()
        {
            InitializeComponent();
            myHealthRecord = new HealthDatabase();
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
            healthDataGridView.DataSource = healthDatabaseBindingSource;
            InitializeColumnHeader(healthDataGridView);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((formForEnterAndEdit == null) || (formForEnterAndEdit.IsDisposed))
            {
                formForEnterAndEdit = new FormForAddAndEdit(this, "Add", null);
                formForEnterAndEdit.Show();
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            int ginNumber = CheckExistenceOfGinNumber(selectGinNumber);
            OpenEditForm(ginNumber);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int ginNumber = CheckExistenceOfGinNumber(selectGinNumber);
            if (ginNumber != -1)
            {
                DeletePerson(ginNumber);
            }
        }
        private void ImportFromFileButton_Click(object sender, EventArgs e)
        {
            if ((formForEnterAndEdit == null) || (formForEnterAndEdit.IsDisposed))
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string inputResult = DataFileOperation.InputFromCSVFile(ref myHealthRecord, filePath);
                    MessageBox.Show(inputResult);
                    healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
                }
            }
        }
        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            if ((formForEnterAndEdit == null) || (formForEnterAndEdit.IsDisposed))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string saveResult = DataFileOperation.SaveAsCSV(ref myHealthRecord, filePath);
                    MessageBox.Show(saveResult);
                }
            }
        }
        private void SearchToolStripTextBox_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ginNumber = CheckExistenceOfGinNumber(searchToolStripTextBox.Text);
                if (ginNumber == -1)
                {
                    SearchToolStripTextBox_MouseEnter(sender, e);
                    return;
                }
                OpenEditForm(ginNumber);
            }
        }
        private void SearchToolStripTextBox_MouseEnter(object sender, EventArgs e)
        {
            searchToolStripTextBox.Text = String.Empty;
            searchToolStripTextBox.ForeColor = System.Drawing.Color.Black;
        }
        private void SearchToolStripTextBox_MouseLeave(object sender, EventArgs e)
        {
            searchToolStripTextBox.Text = "Search By Gin Number (Ctrl+Q)";
            searchToolStripTextBox.ForeColor = System.Drawing.Color.DarkGray;
        }
        private void OpenEditForm(int ginNumber) 
        {
            if (ginNumber != -1)
            {
                if ((formForEnterAndEdit == null) || (formForEnterAndEdit.IsDisposed))
                {
                    Person personToBeDeletedOrModified = myHealthRecord.HealthRecord[ginNumber];
                    formForEnterAndEdit = new FormForAddAndEdit(this, "Edit", personToBeDeletedOrModified);
                    formForEnterAndEdit.Show();
                }
            }
        }
        private void ViewSuspectedCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (viewSuspectedCaseCheckBox.Checked)
            {
                AddFilter("(VisitHubei = 'True' OR HasAbnormalSymptom = 'True' OR Temperature > 37.3)");
            }
            else
            {
                RemoveFilter("(VisitHubei = 'True' OR HasAbnormalSymptom = 'True' OR Temperature > 37.3)");
            }
        }
        private void VisitHubeiFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (visitHubeiFilterCheckBox.Checked)
            {
                AddFilter("VisitHubei = 'True'");
            }
            else
            {
                RemoveFilter("VisitHubei = 'True'");
            }
        }
        private void HasAbnormalSymptomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasAbnormalSymptomFilterCheckBox.Checked)
            {
                AddFilter("HasAbnormalSymptom = 'True'");
            }
            else
            {
                RemoveFilter("HasAbnormalSymptom = 'True'");
            }
        }
        private void ViewEmployeeHealthDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = "";
            healthDatabaseBindingSource.Filter = filter;
            hasAbnormalSymptomFilterCheckBox.Checked = false;
            visitHubeiFilterCheckBox.Checked = false;
            viewSuspectedCaseCheckBox.Checked = false;
        }
        private void IntegerCheck(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            errorGinNumberLabel.Visible = e.Handled;
        }
        private void IntegerCheck_WithMessageBoxWarning(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled)
            {
                MessageBox.Show("The Gin Number must be an integer");
            }
        }
        private int CheckExistenceOfGinNumber(string ginNumberString)
        {
            if (ginNumberString != String.Empty)
            {
                int ginNumber = Int32.Parse(ginNumberString);
                if (myHealthRecord.HealthRecord.ContainsKey(ginNumber))
                {
                    return ginNumber;
                }
            }
            MessageBox.Show("Cannot find the Gin Number!");
            return -1;
        }
        private void AddFilter(string filterToBeAdded)
        {
            if (filter != "")
            {
                filter = filter + " AND ";
            }
            filter = filter + filterToBeAdded;
            healthDatabaseBindingSource.Filter = filter;
        }
        private void RemoveFilter(string filterToBeRemoved)
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
            healthDatabaseBindingSource.Filter = filter;
        }
        private void SelectRowChange(object sender, EventArgs e)
        {    
            if (healthDataGridView.RowCount > 0)
            {
                int index = healthDataGridView.CurrentRow.Index;
                selectGinNumber = (int) healthDataGridView.Rows[index].Cells["GinNumber"].Value;
                string ginNumberString = selectGinNumber.ToString();
                ginNumberTextBox.Text = ginNumberString;
                
            }
        }
        internal bool AddPerson(Person newPerson)
        {
            if (myHealthRecord.AddNewPerson(newPerson) == false)
            {
                MessageBox.Show("Add Failed! The Gin Number you entered already exists.");
                return false;
            }
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
            return true;
        }
        internal bool EditChosenPerson(int myGinNumber, Person updatedPerson)
        {
            if (myHealthRecord.ModifyPerson(myGinNumber, updatedPerson) == false)
            {
                MessageBox.Show("Modify Failed! The Gin Number you entered already exists.");
                return false;
            }
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
            return true;
        }
        internal bool DeletePerson(int ginNumber)
        {
            Person personToBeDeletedOrModified = myHealthRecord.HealthRecord[ginNumber];
            var confirmResult = MessageBox.Show("Are you sure to delete this person: " + personToBeDeletedOrModified.ToString(), "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                myHealthRecord.DeletePerson(ginNumber);
                healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
                return true;
            }
            return false;
        }
        private void InitializeColumnHeader(DataGridView datagridview)
        {
            datagridview.Columns[0].HeaderCell.Value = "Gin Number";
            datagridview.Columns[1].HeaderCell.Value = "Name";
            datagridview.Columns[2].HeaderCell.Value = "Visit Hubei Recently";
            datagridview.Columns[3].HeaderCell.Value = "Has Abnormal Symptom";
            datagridview.Columns[4].HeaderCell.Value = "Body Temperature";
        }


        private void MainMenuForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.Q))
            {
                searchToolStripTextBox.Focus();
            }
        }
    }
}
