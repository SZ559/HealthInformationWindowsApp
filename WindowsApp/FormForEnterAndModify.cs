using System;
using System.Windows.Forms;
using EmployeeInformation;
using DatabaseOperation;

namespace WindowsApp
{
    public partial class FormForAddAndModify : Form
    {      
        private MainMenuForm mainMenu;
        private string option;
        private Person originalPerson;

        private bool hasAbnormalSymptom;
        private bool visitHubei;

        private FormatValidator formatValidator = new FormatValidator();

        public FormForAddAndModify(MainMenuForm mainMenu, string option, Person originalPersonInformation)
        {
            InitializeComponent();
            
            this.mainMenu = mainMenu;
            this.option = option;
            this.originalPerson = originalPersonInformation;
            switch (option)
            {
                case "Add":
                    this.Text = "Add";
                    break;
                case "Modify":
                    this.Text = "Modify";
                    addButton.Text = "Confirm";
                    displayHealthInformationOfPerson(originalPerson);
                    break;
            }
        }

        private void displayHealthInformationOfPerson(Person originalPerson)
        {
            ginNumberTextbox.Text = originalPerson.GinNumber.ToString();
            nameTextBox.Text = originalPerson.Name;
            temperatureTextbox.Text = originalPerson.Temperature.ToString();
            visitHubeiYesRadioButton.Checked = originalPerson.VisitHubei;
            visitHubeiNoRadioButton.Checked = !originalPerson.VisitHubei;
            hasAbnormalSymptomYesRadioButton.Checked = originalPerson.HasAbnormalSymptom;
            hasAbnormalSymptomNoRadioButton.Checked = !originalPerson.HasAbnormalSymptom;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            errorGinNumber.Visible = formatValidator.HasFormatError_GinNumber(ginNumberTextbox.Text);
            errorName.Visible = formatValidator.HasFormatError_Name(nameTextBox.Text); 
            errorTemperature.Visible = formatValidator.HasFormatError_Temperature(temperatureTextbox.Text);
            CheckVisitHubei();
            CheckAbnormalSymptom();
            if (errorVisitHubei.Visible == true || errorTemperature.Visible == true || errorName.Visible == true || errorGinNumber.Visible == true || errorAbnormalSymptom.Visible == true)
            {
                MessageBox.Show("Please check the information you entered! Some fields are empty or invalid!");
            }
            else
            {
                int ginNumber = Int32.Parse(ginNumberTextbox.Text);
                string name = nameTextBox.Text;
                double temperature = Double.Parse(temperatureTextbox.Text);

                Person newPerson = new Person(ginNumber, name, visitHubei, hasAbnormalSymptom, temperature);
                switch(option)
                {
                    case "Add":
                        if (mainMenu.AddPerson(newPerson) == true)
                        {
                            ResetButton_Click(sender, e);
                        }
                        break;
                    case "Modify":
                        if (mainMenu.ModifyChosenPerson(originalPerson.GinNumber, newPerson) == true)
                        {
                            Close_Click(sender, e);
                        }
                        break;
                }
            }
        }

        private void CheckAbnormalSymptom()
        {
            if(hasAbnormalSymptomYesRadioButton.Checked == true)
            {
                hasAbnormalSymptom = true;
                errorAbnormalSymptom.Visible = false;
            }
            else if(hasAbnormalSymptomNoRadioButton.Checked == true)
            {
                hasAbnormalSymptom = false;
                errorAbnormalSymptom.Visible = false;
            }
            else
            {
                errorAbnormalSymptom.Visible = true;
            }
        }

        private void CheckVisitHubei()
        {
            if(visitHubeiYesRadioButton.Checked == true)
            {
                visitHubei = true;
                errorVisitHubei.Visible = false;
            }
            else if(visitHubeiNoRadioButton.Checked == true)
            {
                visitHubei = false;
                errorVisitHubei.Visible = false;
            }
            else
            {
                errorVisitHubei.Visible = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ginNumberTextbox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            temperatureTextbox.Text = String.Empty;

            hasAbnormalSymptomNoRadioButton.Checked = false;
            hasAbnormalSymptomYesRadioButton.Checked = false;

            visitHubeiNoRadioButton.Checked = false;
            visitHubeiYesRadioButton.Checked = false;

            errorGinNumber.Visible = false;
            errorName.Visible = false;
            errorVisitHubei.Visible = false;
            errorAbnormalSymptom.Visible = false;
            errorTemperature.Visible = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
