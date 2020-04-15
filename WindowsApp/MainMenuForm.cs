using System;
using System.Windows.Forms;
using FileOperation;
using EmployeeInformation;
using DatabaseOperation;

namespace WindowsApp
{
    public delegate bool UpdateHealthRecord(Person person);
    public delegate bool EditHealthInformation(int myGinNumber, Person updatedPerson);
    public partial class MainMenuForm : Form
    {
        private HealthDatabase myHealthRecord;
        private FilterOperation filter = new FilterOperation();
        private DataGridViewFormatSetting dataGridViewFormatSetting = new DataGridViewFormatSetting();
        private int selectedGinNumber = -1;
        public MainMenuForm()
        {
            InitializeComponent();
            myHealthRecord = new HealthDatabase();
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
            healthDataGridView.DataSource = healthDatabaseBindingSource;
            healthDataGridView = dataGridViewFormatSetting.InitializeColumnHeader(healthDataGridView);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened())
            {
                FormForAddAndEdit formForAddAndEdit = new FormForAddAndEdit("Add", null);
                formForAddAndEdit.updateHealthRecrod += new UpdateHealthRecord(AddPerson);
                formForAddAndEdit.statusBarUpdate_SubFormClosed += new EventHandler(StatusBarUpdate_SubFormClosed);
                formForAddAndEdit.Show();
                currentStatusToolStripStatusLabel.Text = "Adding";
            }
        }
        private void StatusBarUpdate_SubFormClosed(object sender, EventArgs e)
        {
            currentStatusToolStripStatusLabel.Text = sender.ToString();
            warningToolStripStatusLabel1.Visible = false;
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            OpenEditForm(selectedGinNumber);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedGinNumber != -1)
            {
                Person personToBeDeleted = myHealthRecord.HealthRecord[selectedGinNumber];
                DeletePerson(personToBeDeleted);
            }
        }
        private void ImportFromFileButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened())
            {
                currentStatusToolStripStatusLabel.Text = "Loading File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string inputResult = DataFileOperation.InputFromCSVFile(ref myHealthRecord, filePath);
                    currentStatusToolStripStatusLabel.Text = inputResult;
                    healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
                }
            }
            currentStatusToolStripStatusLabel.Text = "Ready";
        }
        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened())
            {
                currentStatusToolStripStatusLabel.Text = "Saving File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string saveResult = DataFileOperation.SaveAsCSV(ref myHealthRecord, filePath);
                    currentStatusToolStripStatusLabel.Text = saveResult;
                }
            }
            currentStatusToolStripStatusLabel.Text = "Ready";
        }
        private void SearchToolStripTextBox_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormatValidator formatvalidator = new FormatValidator();
                if (formatvalidator.HasFormatError_GinNumber(searchToolStripTextBox.Text))
                {
                    MessageBox.Show("The Gin Number must be a valid positive integer.");
                    return;
                }
                e.SuppressKeyPress = true;
                int ginNumber = ValidateGinNumber(searchToolStripTextBox.Text);
                if (ginNumber == -1)
                {
                    ResetSearchToolStripTextBox();
                    return;
                }
                OpenEditForm(ginNumber);
            }
        }
        private void ViewEmployeeHealthDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter.Filter = "";
            healthDatabaseBindingSource.Filter = filter.Filter;
            hasAbnormalSymptomFilterCheckBox.Checked = false;
            visitHubeiFilterCheckBox.Checked = false;
            viewSuspectedCaseCheckBox.Checked = false;
        }
        private void ViewCurrentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewCurrentStatusToolStripMenuItem.Checked = !statusStrip1.Visible;
            statusStrip1.Visible = viewCurrentStatusToolStripMenuItem.Checked;
            statusStrip2.Visible = viewCurrentStatusToolStripMenuItem.Checked;
        }
        private void HideStatusBar_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
            statusStrip2.Visible = false;
            viewCurrentStatusToolStripMenuItem.Checked = false;
        }
        private void viewToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewToolBarToolStripMenuItem.Checked = !mainMenuToolStrip.Visible;
            mainMenuToolStrip.Visible = viewToolBarToolStripMenuItem.Checked;
        }
        private void ViewSuspectedCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            healthDatabaseBindingSource.Filter = filter.UpdateFilter(viewSuspectedCaseCheckBox, "(VisitHubei = 'True' OR HasAbnormalSymptom = 'True' OR Temperature > 37.3)");
        }
        private void VisitHubeiFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            healthDatabaseBindingSource.Filter = filter.UpdateFilter(visitHubeiFilterCheckBox, "VisitHubei = 'True'");
        }
        private void HasAbnormalSymptomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            healthDatabaseBindingSource.Filter = filter.UpdateFilter(hasAbnormalSymptomFilterCheckBox, "HasAbnormalSymptom = 'True'");
        }
        private void SearchToolStripTextBox_Enter(object sender, EventArgs e)
        {
            ResetSearchToolStripTextBox();
        }
        private void SearchToolStripTextBox_Leave(object sender, EventArgs e)
        {
            searchToolStripTextBox.Text = "Search By Gin Number (Ctrl+Q)";
            searchToolStripTextBox.ForeColor = System.Drawing.Color.DarkGray;
        }
        private void ResetSearchToolStripTextBox()
        {
            searchToolStripTextBox.Text = String.Empty;
            searchToolStripTextBox.ForeColor = System.Drawing.Color.Black;
        }
        private void OpenEditForm(int ginNumber) 
        {
            if (!IsAnotherFormOpened() && ginNumber != -1)
            { 
                Person personToBeEdited = myHealthRecord.HealthRecord[ginNumber];
                FormForAddAndEdit formForAddAndEdit = new FormForAddAndEdit("Edit", personToBeEdited);
                formForAddAndEdit.editHealthInformation += new EditHealthInformation(EditChosenPerson);
                formForAddAndEdit.updateHealthRecrod += new UpdateHealthRecord(DeletePerson);
                formForAddAndEdit.statusBarUpdate_SubFormClosed += new EventHandler(StatusBarUpdate_SubFormClosed);
                formForAddAndEdit.Show();
                currentStatusToolStripStatusLabel.Text = "Editing";
            }
        }
        private int ValidateGinNumber(string ginNumberString)
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
        private void UpdateRowSelected(object sender, EventArgs e)
        {    
            if (healthDataGridView.RowCount > 0)
            {
                int index = healthDataGridView.CurrentRow.Index;
                selectedGinNumber = (int) healthDataGridView.Rows[index].Cells["GinNumber"].Value;
            }
        }
        private bool AddPerson(Person newPerson)
        {
            if (myHealthRecord.AddNewPerson(newPerson) == false)
            {
                MessageBox.Show("Add Failed! The Gin Number you entered already exists.");
                return false;
            }
            currentStatusToolStripStatusLabel.Text = "Health Information Added";
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
            return true;
        }
        private bool EditChosenPerson(int myGinNumber, Person updatedPerson)
        {
            if (myHealthRecord.ModifyPerson(myGinNumber, updatedPerson) == false)
            {
                MessageBox.Show("Modify Failed! The Gin Number you entered already exists.");
                return false;
            }
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
            return true;
        }
        private bool DeletePerson(Person person)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this person: " + person.ToString(), "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                myHealthRecord.DeletePerson(person.GinNumber);
                healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
                return true;
            }
            return false;
        }
        private void MainMenuForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.Q))
            {
                searchToolStripTextBox.Focus();
            }
        }
        private void MainMenuForm_SizeChanged(object sender, EventArgs e)
        {
            string size = "Size: " + this.Width.ToString() + ", " + this.Height.ToString();
            sizeToolStripStatusLabel2.Text = size;
        }

        private bool IsAnotherFormOpened()
        {
            if (Application.OpenForms.Count < 2) 
            {
                return false;
            }
            warningToolStripStatusLabel1.Text = "Please close the current form!";
            warningToolStripStatusLabel1.Visible = true;
            return true;
        }
    }
}
