using FormatValidator;
using EmployeeHealthRecord;
using FileOperation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsApp
{
    public delegate bool UpdateHealthRecord(Person person, HealthInformation healthInformation);
    public delegate bool EditHealthRecord(Person person, HealthInformation healthInformation, Person personAfterUpdate, HealthInformation healthInformationAfterUpdate);
    public delegate void OverwriteHealthRecord(Person personToBeOverwritten, HealthInformation healthInformationToBeOverwritten, Person personAfterUpdate, HealthInformation healthInformationAfterUpdate);
    public partial class MainMenuForm : Form
    {
        private HealthRecordsOfAllEmployees myHealthRecord;        
        private FilterOperation filter = new FilterOperation();

        public MainMenuForm()
        {
            InitializeComponent();
            myHealthRecord = new HealthRecordsOfAllEmployees();
            
            dateTimePicker.MaxDate = DateTime.Today;
            dateTimePicker.Value = DateTime.Today;
            
            string size = "Size: " + this.Width.ToString() + ", " + this.Height.ToString();
            sizeToolStripStatusLabel.Text = size;
            
            healthRecordsBindingSource.DataSource = myHealthRecord.HealthRecordsDataTable;
            healthRecordsDataGridView.DataSource = healthRecordsBindingSource;  
            DataGridViewSetting.InitializeColumnHeader(healthRecordsDataGridView);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened())
            {
                healthRecordsDataGridView.Focus();
                FormForAddAndEdit formForAddAndEdit = new FormForAddAndEdit("Add", null, null);
                formForAddAndEdit.updateHealthRecord += new UpdateHealthRecord(AddNewRecord);
                formForAddAndEdit.statusBarUpdate_SubFormClosed += new EventHandler(StatusBarUpdate_SubFormClosed);
                formForAddAndEdit.Show();
                currentStatusToolStripStatusLabel.Text = "Adding";
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened() && healthRecordsDataGridView.CurrentRow != null)
            {
                healthRecordsDataGridView.Focus();
                Person selectedPerson = ConvertRowToPerson(healthRecordsDataGridView.CurrentRow);
                HealthInformation selectedHealthRecord = ConvertRowToHealthInformation(healthRecordsDataGridView.CurrentRow);
                OpenEditForm(selectedPerson, selectedHealthRecord);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened() && healthRecordsDataGridView.CurrentRow != null)
            {
                Person personToBeDeleted = ConvertRowToPerson(healthRecordsDataGridView.CurrentRow);
                HealthInformation healthRecordToBeDeleted = ConvertRowToHealthInformation(healthRecordsDataGridView.CurrentRow);
                DeleteSelectedHealthRecord(personToBeDeleted, healthRecordToBeDeleted);       
            }
        }

        private void DeleteAllToolStripButton_Click(object sender, EventArgs e)
        {
            if (!IsAnotherFormOpened())
            {
                DeleteAllHealthRecordsDisplayedInDataGridView();
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

        private void SaveFileButton_Click(object sender, EventArgs e)
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
            formForAddAndEdit.editHealthRecord += new EditHealthRecord(EditSelectedRecord);
            formForAddAndEdit.updateHealthRecord += new UpdateHealthRecord(DeleteSelectedHealthRecord);
            formForAddAndEdit.statusBarUpdate_SubFormClosed += new EventHandler(StatusBarUpdate_SubFormClosed);
            formForAddAndEdit.Show();
            currentStatusToolStripStatusLabel.Text = "Editing";
        }

        private int ValidateGinNumber(string ginNumberString)
        {
            if (ginNumberString != String.Empty)
            {
                FormatCheck formatvalidator = new FormatCheck();
                if (formatvalidator.HasFormatError_GinNumber(ginNumberString))
                {
                    MessageBox.Show("The Gin Number must be a valid positive integer.");
                    return -1;
                }
                int ginNumber = Int32.Parse(ginNumberString);
                return ginNumber;
            }
            MessageBox.Show("Please enter a Gin Number!");
            return -1;
        }

        private bool AddNewRecord(Person person, HealthInformation newHealthInformation)
        {
            if (!myHealthRecord.AddHealthRecord(person, newHealthInformation))
            {
                Person personInMyHealthRecords = myHealthRecord.HealthRecords[person.GinNumber].Person;
                if (!person.HasSameName(personInMyHealthRecords))
                {
                    MessageBox.Show($"Add Failed! Gin Number and Name do not match employee records. The Gin Number and Name in employee records: {personInMyHealthRecords.ToString_InDefaultNameFormat()}.");
                }
                else
                {
                    MessageBox.Show($"Add Failed! The health information of Gin Number:{person.GinNumber} and Date:{newHealthInformation.Date.ToShortDateString()} already exists.");
                }
                return false;
            }
            currentStatusToolStripStatusLabel.Text = "Health Information Added";
            UpdateDataGridViewDisplay();
            return true;
        }

        private bool EditSelectedRecord(Person personToBeEdited, HealthInformation healthInformationToBeEdited, Person personAfterUpdate, HealthInformation healthInformationAfterUpdate)
        {
            if (myHealthRecord.EditHealthRecord(personToBeEdited, healthInformationToBeEdited.Date, personAfterUpdate, healthInformationAfterUpdate))
            {
                UpdateExistedPerson(personToBeEdited, personAfterUpdate);
                UpdateDataGridViewDisplay();
                return true;
            }
            else
            {
                Person personInMyHealthRecords = myHealthRecord.HealthRecords[personAfterUpdate.GinNumber].Person;
                if (!personAfterUpdate.HasSameName(personInMyHealthRecords))
                {
                    MessageBox.Show($"Edit Failed! Gin Number and Name do not match employee records. The Gin Number and Name in employee records: {personInMyHealthRecords.ToString_InDefaultNameFormat()}.");
                    if (personToBeEdited.GinNumber == personAfterUpdate.GinNumber)
                    {
                        bool updateResult = UpdateExistedPerson(personToBeEdited, personAfterUpdate);
                        UpdateDataGridViewDisplay();
                        return updateResult;
                    }
                    return false;
                }
                else
                {
                    MessageBox.Show($"Edit Failed! The health information of Gin Number:{personAfterUpdate.GinNumber} and Date:{healthInformationAfterUpdate.Date.ToShortDateString()} already exists.");
                    return false;
                }
            }                
        }

        private bool UpdateExistedPerson(Person personToBeEdited, Person personAfterEdit)
        {
            if ((personToBeEdited.GinNumber != personAfterEdit.GinNumber || !personToBeEdited.HasSameName(personAfterEdit)) && myHealthRecord.ContainsPerson(personToBeEdited))
            {
                var confirmResult = MessageBox.Show("Would you like to update the Gin Number and the Name of this person in all records", "Confirm", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    List<HealthInformation>[] overlapedInformation = myHealthRecord.UpdatePerson(personToBeEdited, personAfterEdit);
                    if (overlapedInformation[0].Count != 0)
                    {
                        OverlappedHealthInformationForm form = new OverlappedHealthInformationForm(personAfterEdit, overlapedInformation[1], personToBeEdited, overlapedInformation[0]);
                        form.overwriteHealthRecord += new OverwriteHealthRecord(OverwriteSelectedHealthRecord);
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

        private void OverwriteSelectedHealthRecord(Person personToBeReplaced, HealthInformation healthInformationToBeReplaced, Person person, HealthInformation healthInformation)
        {
            myHealthRecord.EditHealthRecordOfChosenPerson(personToBeReplaced, healthInformationToBeReplaced.Date, healthInformation);
            myHealthRecord.DeleteHealthRecord(person, healthInformation.Date);
            UpdateDataGridViewDisplay();
        }

        private bool DeleteSelectedHealthRecord(Person person, HealthInformation healthRecord)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this person: " + person.ToString() + "," + healthRecord.ToString(), "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                myHealthRecord.DeleteHealthRecord(person, healthRecord.Date);
                MessageBox.Show("Delete Sucess!");
                UpdateDataGridViewDisplay();
                return true;
            }
            return false;
        }

        private void DeleteAllHealthRecordsDisplayedInDataGridView()
        {
            if (healthRecordsDataGridView.RowCount > 1)
            {
                var confirmResult = MessageBox.Show($"Are you sure to delete these {healthRecordsDataGridView.RowCount} records?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in healthRecordsDataGridView.Rows)
                    {
                        Person personToBeDeleted = ConvertRowToPerson(row);
                        HealthInformation healthRecord = ConvertRowToHealthInformation(row);
                        myHealthRecord.DeleteHealthRecord(personToBeDeleted, healthRecord.Date);
                    }
                    MessageBox.Show("Delete Sucess!");
                    UpdateDataGridViewDisplay();
                }
            }
            else if (healthRecordsDataGridView.RowCount == 1)
            {
                Person personToBeDeleted = ConvertRowToPerson(healthRecordsDataGridView.Rows[0]);
                HealthInformation healthRecord = ConvertRowToHealthInformation(healthRecordsDataGridView.Rows[0]);
                DeleteSelectedHealthRecord(personToBeDeleted, healthRecord);
            }
        }

        private void ViewToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewToolBarToolStripMenuItem.Checked = !mainMenuToolStrip.Visible;
            mainMenuToolStrip.Visible = viewToolBarToolStripMenuItem.Checked;
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

        private void ClearFilterLabel_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void ClearFilter()
        {
            filter.ClearFilter();
            healthRecordsBindingSource.Filter = "";
            hasAbnormalSymptomFilterCheckBox.Checked = false;
            visitHubeiFilterCheckBox.Checked = false;
            viewSuspectedCaseCheckBox.Checked = false;
            dateTimePicker.Checked = false;
            ClearGinNumberFilterToolStripButton_Click("e", EventArgs.Empty);
        }

        private void ViewSuspectedCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.UpdateFilter_BasedOnCheckBox(viewSuspectedCaseCheckBox, "SuspectedCaseFilter");
            healthRecordsBindingSource.Filter = filter.Filter;
        }

        private void VisitHubeiFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.UpdateFilter_BasedOnCheckBox(visitHubeiFilterCheckBox, "VisitedHubeiFilter");
            healthRecordsBindingSource.Filter = filter.Filter;
        }

        private void HasAbnormalSymptomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filter.UpdateFilter_BasedOnCheckBox(hasAbnormalSymptomFilterCheckBox, "HasAbnormalSymptomFilter");
            healthRecordsBindingSource.Filter = filter.Filter;
        }

        private void SearchToolStripTextBox_Enter(object sender, EventArgs e)
        {
            currentStatusToolStripStatusLabel.Text = "Press Enter to Search Gin Number";
            ResetSearchToolStripTextBox();
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
                filter.GinNumberFilter = String.Format("GinNumber = {0}", ginNumber);
                healthRecordsBindingSource.Filter = filter.Filter;
                e.SuppressKeyPress = true;
            }
        }

        private void ClearGinNumberFilterToolStripButton_Click(object sender, EventArgs e)
        {
            searchToolStripTextBox.Text = "Search By Gin Number (Ctrl+Q)";
            currentStatusToolStripStatusLabel.Text = "Ready";
            searchToolStripTextBox.ForeColor = System.Drawing.Color.DarkGray;
            filter.GinNumberFilter = "";
            healthRecordsBindingSource.Filter = filter.Filter;
        }

        private void ResetSearchToolStripTextBox()
        {
            searchToolStripTextBox.Text = String.Empty;
            searchToolStripTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            filter.UpdateFilter_Date(date, dateTimePicker.Checked);
            healthRecordsBindingSource.Filter = filter.Filter;
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
                    InitializeTreeViewName(GeneratePersonList());
                    break;
            }
        }
        private void InitializeTreeViewName(SortedDictionary<string, List<Person>> personList)
        {
            treeView.BeginUpdate();
            treeView.Nodes.Clear();
            int indexName = 0;
            treeView.Nodes.Add("All Health Records");
            foreach (var lastName in personList.Keys)
            {
                treeView.Nodes[0].Nodes.Add(lastName.ToString());
                List<Person> listOfPersonHasSameLastName = personList[lastName];
                listOfPersonHasSameLastName.Sort((x, y) => string.Compare(x.FirstName, y.FirstName));
                foreach (Person person in personList[lastName])
                {
                    treeView.Nodes[0].Nodes[indexName].Nodes.Add(person.ToString_InDefaultNameFormat());
                }
                indexName = indexName + 1;
            }
            treeView.ExpandAll();
            treeView.EndUpdate();
        }

        private SortedDictionary<string, List<Person>> GeneratePersonList()
        {
            SortedDictionary<string, List<Person>> personList = new SortedDictionary<string, List<Person>>();
            foreach (HealthRecordOfOneEmployee healthRecord in myHealthRecord.HealthRecords.Values)
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

        private void InitializeTreeViewDate(SortedDictionary<int, SortedDictionary<int, SortedSet<DateTime>>> dateList)
        {
            treeView.BeginUpdate();
            treeView.Nodes.Clear();
            treeView.Nodes.Add("All Health Records");
            int indexYear = 0;
            foreach (var year in dateList.Keys)
            {
                treeView.Nodes[0].Nodes.Add(year.ToString());
                int indexMonth = 0;
                foreach (var month in dateList[year].Keys)
                {
                    treeView.Nodes[0].Nodes[indexYear].Nodes.Add(month.ToString());
                    foreach (var date in dateList[year][month])
                    {
                        treeView.Nodes[0].Nodes[indexYear].Nodes[indexMonth].Nodes.Add(date.ToShortDateString());
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
            foreach (HealthRecordOfOneEmployee healthRecord in myHealthRecord.HealthRecords.Values)
            {
                foreach (HealthInformation healthInformation in healthRecord.Records.Values)
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
       
        private void TreeView_Select(object sender, TreeViewEventArgs e)
        {
            switch ((string)treeViewComboBox.SelectedItem)
            {
                case "Date TreeView":
                    TreeViewDate_Filter(e.Node);
                    break;
                case "Name & Gin Number TreeView":
                    TreeViewName_Filter(e.Node);
                    break;
            }
            healthRecordsBindingSource.Filter = filter.Filter;
        }  
        
        private void TreeViewDate_Filter(TreeNode node)
        {
            int countOfSubNodes = node.GetNodeCount(true);
            string nodeText = node.Text;
            if (node.Parent == null)
            {
                filter.TreeviewDateFilter = "";
            }
            else if (countOfSubNodes == 0)
            {
                filter.UpdateFilter_TreeViewDateFilter_FilterDate(DateTime.Parse(nodeText));
            }
            else if (node.Text.Length == 4)
            {
                int year = Int32.Parse(node.Text);
                DateTime myYearMin = new DateTime(year, 01, 01);
                DateTime myYearMax = myYearMin.AddYears(1);
                filter.UpdateFilter_TreeViewDateFilter_FilterYearOrMonth(myYearMin, myYearMax);
            }
            else
            {
                int year = Int32.Parse(node.Parent.Text);
                int month = Int32.Parse(nodeText);
                DateTime myMonthMin = new DateTime(year, month, 01);
                DateTime myMonthMax = new DateTime(year, month, 01).AddMonths(1);
                filter.UpdateFilter_TreeViewDateFilter_FilterYearOrMonth(myMonthMin, myMonthMax);
            }
        }

        private void TreeViewName_Filter(TreeNode node)
        {
            string nodeText = node.Text;
            TreeNode nodeParent = node.Parent;
            if (nodeParent == null)
            {
                filter.TreeviewNameFilter = "";
            }
            else
            {
                if (node.GetNodeCount(true) == 0)
                {
                    filter.TreeviewNameFilter = String.Format("GinNumber = '{0}'", nodeText.Split(',')[0]);
                }
                else
                {
                    filter.TreeviewNameFilter = String.Format("LastName = '{0}'", nodeText.ToString());
                }
            }
        }
        
        private void UpdateDataGridViewDisplay()
        {
            SwitchTreeView();
            healthRecordsBindingSource.DataSource = myHealthRecord.HealthRecordsDataTable;
        }

        private Person ConvertRowToPerson(DataGridViewRow currentRow)
        {
            var selectedGinNumber = (int)currentRow.Cells["GinNumber"].Value;
            var lastName = currentRow.Cells["LastName"].Value.ToString();
            var firstName = currentRow.Cells["FirstName"].Value.ToString();
            return new Person(selectedGinNumber, firstName, lastName);
        }

        private HealthInformation ConvertRowToHealthInformation(DataGridViewRow currentRow)
        {
            var selectedDate = (DateTime)currentRow.Cells["Date"].Value;
            bool visitHubei = (bool)currentRow.Cells["VisitHubei"].Value;
            bool hasAbnormalSymptom = (bool)currentRow.Cells["HasAbnormalSymptom"].Value;
            double temperature = (double)currentRow.Cells["Temperature"].Value;
            return new HealthInformation(selectedDate, visitHubei, hasAbnormalSymptom, temperature);
        }

        private void HealthRecordDataGridView_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode = null;
        }

        private void StatusBarUpdate_SubFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count < 2)
            {
                currentStatusToolStripStatusLabel.Text = "Ready";
                warningToolStripStatusLabel1.Visible = false;
            }
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
            sizeToolStripStatusLabel.Text = size;
        }
    }
}
