using DatabaseOperation;
using EmployeeInformation;
using FileOperation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsApp
{
    public delegate bool UpdateHealthRecord(Person person, HealthInformation newHealthInformation);
    public delegate bool EditHealthInformation(Person person, HealthInformation healthInformation, Person updatedPerson, HealthInformation updatedHealthInformation);
    public delegate void ReplaceHealthInformation(Person person, HealthInformation healthInformation, Person updatedPerson, HealthInformation updatedHealthInformation);
    public partial class MainMenuForm : Form
    {
        private EmployeeHealthDatabase myHealthRecord;
        private FilterOperation filter = new FilterOperation();
        private DateTime filterDate;
        private List<Person> selectedPersons = new List<Person>();
        private List<HealthInformation> selectedHealthRecords = new List<HealthInformation>();
        public MainMenuForm()
        {
            InitializeComponent();
            myHealthRecord = new EmployeeHealthDatabase();
            dateTimePicker.MaxDate = DateTime.Today;
            dateTimePicker.Value = DateTime.Today;
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordsDataTable;
            healthDataGridView.DataSource = healthDatabaseBindingSource;
            DataGridViewSetting.InitializeColumnHeader(healthDataGridView);
        }
        private void StatusBarUpdate_SubFormClosed(object sender, EventArgs e)
        {
            currentStatusToolStripStatusLabel.Text = "Ready";
            warningToolStripStatusLabel1.Visible = false;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened())
            {
                FormForAddAndEdit formForAddAndEdit = new FormForAddAndEdit("Add", null, null);
                formForAddAndEdit.updateHealthRecrod += new UpdateHealthRecord(AddNewRecord);
                formForAddAndEdit.statusBarUpdate_SubFormClosed += new EventHandler(StatusBarUpdate_SubFormClosed);
                formForAddAndEdit.Show();
                currentStatusToolStripStatusLabel.Text = "Adding";
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened() && selectedHealthRecords.Count == 1)
            {
                OpenEditForm(selectedPersons[0], selectedHealthRecords[0]);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened() && selectedPersons.Count != 0)
            {
                if (selectedHealthRecords.Count == 0)
                {
                    DeleteChosenPersons(selectedPersons);
                }
                else if (selectedHealthRecords.Count == 1)
                {
                    DeleteChosenRecord(selectedPersons[0], selectedHealthRecords[0]);
                }
                else
                {
                    int countOfFailedDeletion = DeleteAllChosenHealthRecords(selectedPersons, selectedHealthRecords);
                    if (countOfFailedDeletion == 0)
                    {
                        MessageBox.Show("Delete Sucess!");
                    }
                    else if (countOfFailedDeletion > 0)
                    {
                        MessageBox.Show($"{countOfFailedDeletion} Deletion Failed!");
                    }
                }
            }
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened())
            {
                currentStatusToolStripStatusLabel.Text = "Loading File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string importResult = DataFileOperation.InputFromCSVFile(ref myHealthRecord, filePath);
                    MessageBox.Show(importResult);
                    ClearFilter();
                    UpdateDataGridViewDisplay();
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
                    MessageBox.Show(saveResult);
                }
            }
            currentStatusToolStripStatusLabel.Text = "Ready";
        }
        private void OpenEditForm(Person person, HealthInformation healthRecord)
        {
            FormForAddAndEdit formForAddAndEdit = new FormForAddAndEdit("Edit", person, healthRecord);
            formForAddAndEdit.editHealthInformation += new EditHealthInformation(EditChosenRecord);
            formForAddAndEdit.updateHealthRecrod += new UpdateHealthRecord(DeleteChosenRecord);
            formForAddAndEdit.statusBarUpdate_SubFormClosed += new EventHandler(StatusBarUpdate_SubFormClosed);
            formForAddAndEdit.Show();
            currentStatusToolStripStatusLabel.Text = "Editing";
        }
        private int ValidateGinNumber(string ginNumberString)
        {
            if (ginNumberString != String.Empty)
            {
                FormatValidator formatvalidator = new FormatValidator();
                if (formatvalidator.HasFormatError_GinNumber(ginNumberString))
                {
                    MessageBox.Show("The Gin Number must be a valid positive integer.");
                    return -1;
                }
                int ginNumber = Int32.Parse(ginNumberString);
                return ginNumber;
            }
            MessageBox.Show("Cannot find the Gin Number!");
            return -1;
        }
        private bool AddNewRecord(Person person, HealthInformation newHealthInformation)
        {
            if (myHealthRecord.AddHealthRecord(person, newHealthInformation) == false)
            {
                MessageBox.Show("Add Failed! The health information of this person at this date already exists.");
                return false;
            }
            currentStatusToolStripStatusLabel.Text = "Health Information Added";
            UpdateDataGridViewDisplay();
            return true;
        }
        private bool EditChosenRecord(Person personToBeEdited, HealthInformation healthInformationToBeEdited, Person updatedPerson, HealthInformation updatedHealthInformation)
        {
            if (!myHealthRecord.ModifyOneHealthRecord(personToBeEdited, healthInformationToBeEdited, updatedPerson, updatedHealthInformation))
            {
                MessageBox.Show("Modify Failed! The record you entered already exists.");
                return UpdatePerson(personToBeEdited, updatedPerson);
            }
            UpdatePerson(personToBeEdited, updatedPerson);
            UpdateDataGridViewDisplay();
            return true;
        }
        private bool UpdatePerson(Person personToBeEdited, Person updatedPerson)
        {
            if (personToBeEdited != updatedPerson && myHealthRecord.ContainsPerson(personToBeEdited))
            {
                var confirmResult = MessageBox.Show("Would you like to update the gin number and the name of this person in all records", "Confirm", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    List<HealthInformation>[] overlapedInformation = myHealthRecord.UpdatePerson(personToBeEdited, updatedPerson);
                    if (overlapedInformation[0].Count != 0)
                    {
                        OverlapedHealthInformationForm form = new OverlapedHealthInformationForm(personToBeEdited, overlapedInformation[0], updatedPerson, overlapedInformation[1]);
                        form.replaceHealthInformation += new ReplaceHealthInformation(ReplaceHealthRecordOfChosenPerson);
                        form.statusBarUpdate_SubFormClosed += new EventHandler(StatusBarUpdate_SubFormClosed);
                        form.Show();

                    }
                    else
                    {
                        MessageBox.Show("Edit Sucess!");
                    }
                    return true;
                }               
            }
            return false;
        }
        private void ReplaceHealthRecordOfChosenPerson(Person personToBeModified, HealthInformation healthInformationToBeModified, Person updatedPerson, HealthInformation updatedHealthInformation)
        {
            myHealthRecord.ModifyHealthRecordOfChosenPerson(personToBeModified, healthInformationToBeModified, updatedHealthInformation);
            myHealthRecord.DeleteHealthRecord(updatedPerson, updatedHealthInformation);
            UpdateDataGridViewDisplay();
        }

        private bool DeleteChosenRecord(Person person, HealthInformation healthRecord)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this person: " + person.ToString() + healthRecord.ToString(), "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                bool deleteResult = myHealthRecord.DeleteHealthRecord(person, healthRecord);
                UpdateDataGridViewDisplay();
                return deleteResult;
            }
            return false;
        }
        private int DeleteChosenPersons(List<Person> personToBeDeleted)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete all records of {personToBeDeleted.Count} persons", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int failedTime = 0;
                foreach (Person person in personToBeDeleted)
                {
                    if (!myHealthRecord.DeletePerson(person))
                    {
                        failedTime = failedTime + 1;
                    }
                }
                UpdateDataGridViewDisplay();
                return failedTime;
            }
            return -1;
        }
        private int DeleteAllChosenHealthRecords(List<Person> personToBeDeleted, List<HealthInformation> healthRecord)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete all {personToBeDeleted.Count} records?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                int failedTime = 0;
                for (int i = 0; i < healthRecord.Count; i = i + 1)
                {
                    if (!myHealthRecord.DeleteHealthRecord(personToBeDeleted[i], healthRecord[i]))
                    {
                        failedTime = failedTime + 1;
                    }
                }
                UpdateDataGridViewDisplay();
                return failedTime;
            }
            return -1;
        }
        private void SearchToolStripTextBox_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ginNumber = ValidateGinNumber(searchToolStripTextBox.Text);
                if (ginNumber == -1)
                {
                    ResetSearchToolStripTextBox();
                    return;
                }
                string filterString = String.Format("GinNumber = {0}", ginNumber);
                filter.AddFilter(filterString);
                healthDatabaseBindingSource.Filter = filter.Filter;
                e.SuppressKeyPress = true;
            }
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
        private void ViewEmployeeHealthDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }
        private void ClearFilterToolStripButton_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }
        private void ClearFilter()
        {
            filter.Filter = "";
            healthDatabaseBindingSource.Filter = filter.Filter;
            hasAbnormalSymptomFilterCheckBox.Checked = false;
            visitHubeiFilterCheckBox.Checked = false;
            viewSuspectedCaseCheckBox.Checked = false;
            dateTimePicker.Value = DateTime.Today;
            dateTimePicker.Checked = false;
        }
        private void ViewToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewToolBarToolStripMenuItem.Checked = !mainMenuToolStrip.Visible;
            mainMenuToolStrip.Visible = viewToolBarToolStripMenuItem.Checked;
        }
        private void ViewSuspectedCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            healthDatabaseBindingSource.Filter = filter.UpdateFilter_BasedOnCheckBox(viewSuspectedCaseCheckBox, "(VisitHubei = 'True' OR HasAbnormalSymptom = 'True' OR Temperature > 37.3)");
        }
        private void VisitHubeiFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            healthDatabaseBindingSource.Filter = filter.UpdateFilter_BasedOnCheckBox(visitHubeiFilterCheckBox, "VisitHubei = 'True'");
        }
        private void HasAbnormalSymptomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            healthDatabaseBindingSource.Filter = filter.UpdateFilter_BasedOnCheckBox(hasAbnormalSymptomFilterCheckBox, "HasAbnormalSymptom = 'True'");
        }
        private void SearchToolStripTextBox_Enter(object sender, EventArgs e)
        {
            currentStatusToolStripStatusLabel.Text = "Press Enter to Search";
            ResetSearchToolStripTextBox();
        }
        private void SearchToolStripTextBox_Leave(object sender, EventArgs e)
        {
            searchToolStripTextBox.Text = "Search By Gin Number (Ctrl+Q)";
            currentStatusToolStripStatusLabel.Text = "Ready";
            searchToolStripTextBox.ForeColor = System.Drawing.Color.DarkGray;
        }
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Checked)
            {
                filter.RemoveFilter(String.Format("Date = '{0:MM/dd/yyyy}'", filterDate));
                DateTime date = dateTimePicker.Value;
                string filterString = String.Format("Date = '{0:MM/dd/yyyy}'", date);
                filterDate = date;
                filter.AddFilter(filterString);
                healthDatabaseBindingSource.Filter = filter.Filter;
            }
        }
        private void ResetSearchToolStripTextBox()
        {
            searchToolStripTextBox.Text = String.Empty;
            searchToolStripTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void UpdateRowSelected(object sender, EventArgs e)
        {
            
        }
        private void ConvertRowsToPerson(DataGridViewRow currentRow)
        {
            var selectedGinNumber = (int)currentRow.Cells["GinNumber"].Value;
            var lastName = currentRow.Cells["LastName"].Value.ToString();
            var firstName = currentRow.Cells["FirstName"].Value.ToString();
            selectedPersons.Add(new Person(selectedGinNumber, firstName, lastName));

        }
        private void ConvertRowsToHealthRecord(DataGridViewRow currentRow)
        {
            var selectedDate = (DateTime)currentRow.Cells["Date"].Value;
            bool visitHubei = (bool)currentRow.Cells["VisitHubei"].Value;
            bool hasAbnormalSymptom = (bool)currentRow.Cells["HasAbnormalSymptom"].Value;
            double temperature = (double)currentRow.Cells["Temperature"].Value;
            selectedHealthRecords.Add(new HealthInformation(selectedDate, visitHubei, hasAbnormalSymptom, temperature));
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

        private void TreeViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchTreeView();
        }

        private void SwitchTreeView()
        {
            switch ((string)treeViewComboBox.SelectedItem)
            {
                case "Date TreeView":
                    InitializeTreeViewDate(GenerateDateList());
                    break;
                case "Name & Gin Number TreeView":
                    InitializeTreeViewName(GenerateNameList());
                    break;
            }
        }
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ClearFilter();
            switch ((string)treeViewComboBox.SelectedItem)
            {
                case "Date TreeView":
                    TreeViewDate_Filter(e.Node);
                    break;
                case "Name & Gin Number TreeView":
                    TreeViewName_Filter(e.Node);
                    break;
            }
            selectedPersons.Clear();
            selectedHealthRecords.Clear();
            foreach (DataGridViewRow row in healthDataGridView.Rows)
            {
                ConvertRowsToPerson(row);
                ConvertRowsToHealthRecord(row);
            }
            //can be simplified here for name treeview, instead of reading all the rows, just read all the persons, consider to rivise it later. 
        }
        private void InitializeTreeViewName(SortedDictionary<string, List<Person>> personList)
        {
            treeView.BeginUpdate();
            treeView.Nodes.Clear();
            int indexName = 0;
            foreach (var lastName in personList.Keys)
            {
                treeView.Nodes.Add(lastName.ToString());
                List<Person> listOfPersonHasSameLastName = personList[lastName];
                listOfPersonHasSameLastName.Sort((x, y) => string.Compare(x.FirstName, y.FirstName));
                foreach (Person person in personList[lastName])
                {
                    treeView.Nodes[indexName].Nodes.Add(person.ToString_DefualtNameFormat());
                }
                indexName = indexName + 1;
            }
            treeView.ExpandAll();
            treeView.EndUpdate();
        }
        private void InitializeTreeViewDate(SortedDictionary<int, SortedDictionary<int, SortedSet<DateTime>>> dateList)
        {
            treeView.BeginUpdate();
            treeView.Nodes.Clear();
            int indexYear = 0;
            foreach (var year in dateList.Keys)
            {
                treeView.Nodes.Add(year.ToString());
                int indexMonth = 0;
                foreach (var month in dateList[year].Keys)
                {
                    treeView.Nodes[indexYear].Nodes.Add(month.ToString());
                    foreach (var date in dateList[year][month])
                    {
                        treeView.Nodes[indexYear].Nodes[indexMonth].Nodes.Add(date.ToShortDateString());
                    }
                    indexMonth = indexMonth + 1;
                }
                indexYear = indexYear + 1;
            }
            treeView.ExpandAll();
            treeView.EndUpdate();
        }
        private SortedDictionary<int, SortedDictionary<int, SortedSet<DateTime>>> GenerateDateList()
        {
            SortedDictionary<int, SortedDictionary<int, SortedSet<DateTime>>> dateList = new SortedDictionary<int, SortedDictionary<int, SortedSet<DateTime>>>();
            foreach (EmployeeHealthRecord healthRecord in myHealthRecord.HealthRecords.Values)
            {
                foreach (HealthInformation healthInformation in healthRecord.EmployeeHealthRecords.Values)
                {
                    DateTime date = healthInformation.Date;
                    int year = date.Year;
                    int month = date.Month;
                    if (!dateList.ContainsKey(year))
                    {
                        dateList.Add(year, new SortedDictionary<int, SortedSet<DateTime>>());
                    }
                    if (!dateList[year].ContainsKey(month))
                    {
                        dateList[year].Add(month, new SortedSet<DateTime>());
                    }
                    dateList[year][month].Add(date);
                }
            }
            return dateList;
        }

        private SortedDictionary<string, List<Person>> GenerateNameList()
        {
            SortedDictionary<string, List<Person>> personList = new SortedDictionary<string, List<Person>>();
            foreach (EmployeeHealthRecord healthRecord in myHealthRecord.HealthRecords.Values)
            {
                Person person = healthRecord.Person;
                string lastName = person.LastName;

                if (!personList.ContainsKey(lastName))
                {
                    personList.Add(lastName, new List<Person>());
                }
                personList[lastName].Add(person);
            }
            return personList;
        }

        private void TreeViewDate_Filter(TreeNode node)
        {
            int countOfSubNodes = node.GetNodeCount(true);
            string nodeText = node.Text;
            if (node.Parent == null)
            {
                int year = Int32.Parse(node.Text);
                DateTime myYearMin = new DateTime(year, 01, 01);
                DateTime myYearMax = myYearMin.AddYears(1);
                healthDatabaseBindingSource.Filter = filter.FilterDateTime_MonthAndYearFilter(myYearMax, myYearMin);
            }
            else if (countOfSubNodes == 0)
            {
                string dateFilterString = String.Format("Date = '{0:MM/dd/yyyy}'", DateTime.Parse(nodeText));
                filter.AddFilter(dateFilterString);
                healthDatabaseBindingSource.Filter = filter.Filter;
            }
            else
            {
                int year = Int32.Parse(node.Parent.Text);
                int month = Int32.Parse(nodeText);
                DateTime myMonthMin = new DateTime(year, month, 01);
                DateTime myMonthMax = new DateTime(year, month, 01).AddMonths(1);
                healthDatabaseBindingSource.Filter = filter.FilterDateTime_MonthAndYearFilter(myMonthMax, myMonthMin);
            }
        }
        private void TreeViewName_Filter(TreeNode node)
        {
            string nodeText = node.Text;
            TreeNode nodePrent = node.Parent;
            if (nodePrent != null)
            {
                string filterString = String.Format("GinNumber = '{0}'", nodeText.Split(',')[0]);
                filter.AddFilter(filterString);
                healthDatabaseBindingSource.Filter = filter.Filter;
            }
            else
            {
                string filterString = String.Format("LastName = '{0}'", nodeText.ToString());
                filter.AddFilter(filterString);
                healthDatabaseBindingSource.Filter = filter.Filter;
            }
        }
        private void UpdateDataGridViewDisplay()
        {
            SwitchTreeView();
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordsDataTable;
        }

        private void UpdateRowSelected(object sender, DataGridViewCellEventArgs e)
        {
            selectedPersons.Clear();
            selectedHealthRecords.Clear();
            if (healthDataGridView.RowCount > 0)
            {
                var currentRow = healthDataGridView.CurrentRow;
                ConvertRowsToPerson(currentRow);
                ConvertRowsToHealthRecord(currentRow);
                return;
            }
        }
    }
}
