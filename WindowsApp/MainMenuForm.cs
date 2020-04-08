using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FileOperation;
using EmployeeInformation;
using DatabaseOperation;

namespace WindowsApp
{
    public partial class MainMenuForm : Form
    {
        private HealthDatabase myHealthRecord;
        private FormatValidator formatValidator = new FormatValidator();
        private FormForAddAndModify formForEnterAndModify;
        public MainMenuForm()
        {
            InitializeComponent();
            myHealthRecord = new HealthDatabase();
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecord.Values.ToList();
            healthDataGridView.DataSource = healthDatabaseBindingSource;
            InitializeColumnHeader(healthDataGridView);

            suspectedCaseBindingSource.DataSource = myHealthRecord.SuspectedCaseList;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((formForEnterAndModify == null) || (formForEnterAndModify.IsDisposed))
            {
                formForEnterAndModify = new FormForAddAndModify(this, "Add", null);
                formForEnterAndModify.Show();
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if ((formForEnterAndModify == null) || (formForEnterAndModify.IsDisposed))
            {
                int ginNumber = CheckGinNumber();
                if (ginNumber != -1)
                {
                    Person originalPerson = myHealthRecord.HealthRecord[ginNumber];
                    formForEnterAndModify = new FormForAddAndModify(this, "Modify", originalPerson);
                    formForEnterAndModify.Show();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int ginNumber = CheckGinNumber();

            if (ginNumber != -1)
            {
                Person personToBeDeleted = myHealthRecord.HealthRecord[ginNumber];
                var confirmResult = MessageBox.Show("Are you sure to delete this person: " + personToBeDeleted.ToString(), "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    myHealthRecord.DeletePerson(ginNumber);
                    healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecord.Values.ToList();
                    suspectedCaseBindingSource.DataSource = myHealthRecord.SuspectedCaseList;
                }
            } 
        }
        private void IntegerCheck(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            errorGinNumberLabel.Visible = e.Handled;
        }

        private int CheckGinNumber()
        {
            if (ginNumberTextBox.Text != String.Empty)
            {
                int ginNumber = Int32.Parse(ginNumberTextBox.Text);
                errorCannotFindGinNumberLabel.Visible = !myHealthRecord.HealthRecord.ContainsKey(ginNumber);

                if (errorCannotFindGinNumberLabel.Visible == false)
                {
                    return ginNumber;
                }
            }
            return -1;
        }

        private void InputFromFileButton_Click(object sender, EventArgs e)
        {
            if ((formForEnterAndModify == null) || (formForEnterAndModify.IsDisposed))
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string inputResult = DataFileOperation.InputFromCSVFile(ref myHealthRecord, filePath);
                    MessageBox.Show(inputResult);
                    healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecord.Values.ToList();
                    suspectedCaseBindingSource.DataSource = myHealthRecord.SuspectedCaseList;
                }
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if ((formForEnterAndModify == null) || (formForEnterAndModify.IsDisposed)) 
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    string saveResult = DataFileOperation.SaveAsCSV(ref myHealthRecord, filePath);
                    MessageBox.Show(saveResult);
                }
            }
        }

        private void InitializeColumnHeader(DataGridView datagridview)
        {
            datagridview.Columns[0].HeaderCell.Value = "Gin Number";
            datagridview.Columns[1].HeaderCell.Value = "Name";
            datagridview.Columns[2].HeaderCell.Value = "Visit Hubei Recently";
            datagridview.Columns[3].HeaderCell.Value = "Has Abnormal Symptom";
            datagridview.Columns[4].HeaderCell.Value = "Body Temperature";
        }

        internal bool AddPerson(Person newPerson)
        {
            if (myHealthRecord.AddNewPerson(newPerson) == false)
            {
                MessageBox.Show("Add Failed! The Gin Number you entered already exists.");
                return false;
            }
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecord.Values.ToList();
            suspectedCaseBindingSource.DataSource = myHealthRecord.SuspectedCaseList;
            return true;
        }

        internal bool ModifyChosenPerson(int myGinNumber, Person updatedPerson)
        {
            if (myHealthRecord.ModifyPerson(myGinNumber, updatedPerson) == false)
            {
                MessageBox.Show("Modify Failed! The Gin Number you entered already exists.");
                return false;
            }
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecord.Values.ToList();
            suspectedCaseBindingSource.DataSource = myHealthRecord.SuspectedCaseList;
            return true;
        }

        private void DisplaySuspectedCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (displaySuspectedCaseCheckBox.Checked == true)
            {
                healthDataGridView.DataSource = suspectedCaseBindingSource;
            }
            else
            {
                healthDataGridView.DataSource = healthDatabaseBindingSource;
            }
        }



        //private void displayButton_Click(object sender, EventArgs e)
        //{
        //    healthRecordDataGridView.Rows.Clear();
        //    foreach (Person person in myHealthRecord.HealthRecord.Values)
        //    {
        //        healthRecordDataGridView.Rows.Add(person.ToStringArray());
        //    }
        //}

        //private void displaySuspectedButton_Click(object sender, EventArgs e)
        //{
        //    healthRecordDataGridView.Rows.Clear();
        //    foreach (Person person in myHealthRecord.HealthRecord.Values)
        //    {
        //        if (person.IsPersonSuspected())
        //        {
        //            healthRecordDataGridView.Rows.Add(person.ToStringArray());
        //        }
        //    }
        //}


    }
}
