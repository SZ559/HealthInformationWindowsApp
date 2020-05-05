using System;
using System.Windows.Forms;
using EmployeeHealthRecord;
using FormatValidator;

namespace WindowsApp
{
    public partial class FormForAddAndEdit : Form
    {      
        private string option;
        private Person originalPerson;
        private HealthInformation originalHealthInformation;
        private FormatCheck formatValidator = new FormatCheck();
        internal event EditHealthRecord editHealthRecord;
        internal event UpdateHealthRecord updateHealthRecord;
        internal event EventHandler statusBarUpdate_SubFormClosed;

        public FormForAddAndEdit(string option, Person person, HealthInformation healthRecord)
        {
            InitializeComponent();
            this.option = option;
            this.originalPerson = person;
            this.originalHealthInformation = healthRecord;
            
            dateTimePicker.MaxDate = DateTime.Today;
            dateTimePicker.Value = DateTime.Today;
            switch (option)
            {
                case "Add":
                    this.Text = "Add";
                    addOrSaveButton.Text = "Add";
                    clearButton.Visible = true;
                    deleteButton.Visible = false;
                    dateTimePicker.Checked = false;
                    dateTimePicker.ShowCheckBox = true;                  
                    break;
                case "Edit":
                    this.Text = "Edit";
                    addOrSaveButton.Text = "Save";
                    clearButton.Visible = false;
                    deleteButton.Visible = true;
                    dateTimePicker.Checked = true;
                    dateTimePicker.ShowCheckBox = false;
                    DisplayHealthRecord(originalPerson, originalHealthInformation);
                    break;
            }
        }

        private void DisplayHealthRecord(Person person, HealthInformation healthInformation)
        {
            ginNumberTextbox.Text = person.GinNumber.ToString();
            firstNameTextBox.Text = person.FirstName;
            lastNameTextBox.Text = person.LastName;
            dateTimePicker.Value = healthInformation.Date;
            bodyTemperatureTextbox.Text = healthInformation.BodyTemperature.ToString();
            visitHubeiYesRadioButton.Checked = healthInformation.VisitHubei;
            visitHubeiNoRadioButton.Checked = !healthInformation.VisitHubei;
            hasAbnormalSymptomYesRadioButton.Checked = healthInformation.HasAbnormalSymptom;
            hasAbnormalSymptomNoRadioButton.Checked = !healthInformation.HasAbnormalSymptom;
        }

        private void AddOrSaveButton_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
            {
                MessageBox.Show("Please check the information you entered! Some fields are empty or invalid!");
            }
            else
            {
                int ginNumber = int.Parse(ginNumberTextbox.Text);
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                DateTime date = dateTimePicker.Value;
                double temperature = Double.Parse(bodyTemperatureTextbox.Text);
                bool visitHubei = visitHubeiYesRadioButton.Checked;
                bool hasAbnormalSymptom = hasAbnormalSymptomYesRadioButton.Checked;
                Person updatedPerson = new Person(ginNumber, firstName, lastName);
                HealthInformation updatedHealthInformation = new HealthInformation(date, visitHubei, hasAbnormalSymptom, temperature);
                switch (option)
                {
                    case "Add":
                        if (updateHealthRecord(updatedPerson, updatedHealthInformation))
                        {
                            ResetAll();
                        }
                        break;
                    case "Edit":
                        if (editHealthRecord(originalPerson, originalHealthInformation, updatedPerson, updatedHealthInformation))
                        {
                            Close();
                        }
                        break;
                }
            }   
        }

        private bool IsValidInput()
        {
            errorGinNumber.Visible = formatValidator.HasFormatError_GinNumber(ginNumberTextbox.Text);
            errorFirstName.Visible = formatValidator.HasFormatError_Name(firstNameTextBox.Text);
            errorLastName.Visible = formatValidator.HasFormatError_Name(lastNameTextBox.Text);
            errorDateLabel.Visible = !dateTimePicker.Checked;
            errorVisitHubei.Visible = (!visitHubeiYesRadioButton.Checked) && (!visitHubeiNoRadioButton.Checked);
            errorAbnormalSymptom.Visible = (!hasAbnormalSymptomYesRadioButton.Checked) && (!hasAbnormalSymptomNoRadioButton.Checked);
            errorBodyTemperature.Visible = formatValidator.HasFormatError_BodyTemperature(bodyTemperatureTextbox.Text);
            
            return !(errorGinNumber.Visible || errorFirstName.Visible || errorLastName.Visible || errorDateLabel.Visible || errorVisitHubei.Visible || errorAbnormalSymptom.Visible || errorBodyTemperature.Visible);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (updateHealthRecord(originalPerson, originalHealthInformation))
            {
                Close(); 
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void ResetAll()
        {
            ginNumberTextbox.Text = String.Empty;
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = string.Empty;
            dateTimePicker.Value = DateTime.Today;
            dateTimePicker.Checked = false;
            bodyTemperatureTextbox.Text = String.Empty;
            hasAbnormalSymptomNoRadioButton.Checked = false;
            hasAbnormalSymptomYesRadioButton.Checked = false;
            visitHubeiNoRadioButton.Checked = false;
            visitHubeiYesRadioButton.Checked = false;

            errorGinNumber.Visible = false;
            errorDateLabel.Visible = false;
            errorFirstName.Visible = false;
            errorFirstName.Visible = false;
            errorLastName.Visible = false;
            errorVisitHubei.Visible = false;
            errorAbnormalSymptom.Visible = false;
            errorBodyTemperature.Visible = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormForAddAndEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            statusBarUpdate_SubFormClosed?.Invoke(sender, FormClosedEventArgs.Empty);
        }
    }
}
