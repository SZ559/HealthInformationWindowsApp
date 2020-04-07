using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private FormForEnterAndModify formForEnterAndModify;
        public MainMenuForm()
        {
            InitializeComponent();
            myHealthRecord = new HealthDatabase();
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecord.Values.ToList();
            healthDataGridView.DataSource = healthDatabaseBindingSource;
            InitializeColumnHeader(healthDataGridView);

            suspectedCaseBindingSource.DataSource = myHealthRecord.SuspectedCaseList;
            suspectedCaseDataGridView.DataSource = suspectedCaseBindingSource;
            InitializeColumnHeader(suspectedCaseDataGridView);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if ((formForEnterAndModify == null) || (formForEnterAndModify.IsDisposed))
            {
                formForEnterAndModify = new FormForEnterAndModify(this, "Enter", null);
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
                    formForEnterAndModify = new FormForEnterAndModify(this, "Modify", originalPerson);
                    formForEnterAndModify.Show();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int ginNumber = CheckGinNumber();
            if (ginNumber != -1)
            {
                myHealthRecord.DeletePerson(ginNumber);
                healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecord.Values.ToList();
                suspectedCaseBindingSource.DataSource = myHealthRecord.SuspectedCaseList;
            } 
        }

        private int CheckGinNumber()
        {
            errorCannotFindGinNumberLabel.Visible = false;
            errorGinNumberLabel.Visible = formatValidator.HasFormatError_GinNumber(ginNumberTextBox.Text);

            if (errorGinNumberLabel.Visible == false)
            {
                int ginNumber = Int32.Parse(ginNumberTextBox.Text);
                if (myHealthRecord.HealthRecord.ContainsKey(ginNumber))
                {
                    return ginNumber;
                }
                else
                {
                    errorCannotFindGinNumberLabel.Visible = true;
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
                MessageBox.Show("Enter Failed! The Gin Number you entered already exists.");
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
