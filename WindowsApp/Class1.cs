using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformation;
using System.Windows.Forms;

namespace WindowsApp
{
    public class UpdateDataBase
    {
        private bool AddPerson(ref HealthDatabase myHealthRecord, ref BindingSource healthDatabaseBindingSource,   Person newPerson)
        {
            if (myHealthRecord.AddNewPerson(newPerson) == false)
            {
                MessageBox.Show("Add Failed! The Gin Number you entered already exists.");
                return false;
            }
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
            return true;
        }
        private bool EditChosenPerson(ref HealthDatabase myHealthRecord, ref BindingSource healthDatabaseBindingSource, int myGinNumber, Person updatedPerson)
        {
            if (myHealthRecord.ModifyPerson(myGinNumber, updatedPerson) == false)
            {
                MessageBox.Show("Modify Failed! The Gin Number you entered already exists.");
                return false;
            }
            healthDatabaseBindingSource.DataSource = myHealthRecord.HealthRecordDataTable;
            return true;
        }
        private bool DeletePerson(ref HealthDatabase myHealthRecord, ref BindingSource healthDatabaseBindingSource, Person person)
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
    }
}
