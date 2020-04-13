﻿using System;
using System.Windows.Forms;
using EmployeeInformation;
using DatabaseOperation;

namespace WindowsApp
{
    public partial class FormForAddAndEdit : Form
    {      
        private MainMenuForm mainMenu;
        private string option;
        private Person originalPerson;
        private bool hasAbnormalSymptom;
        private bool visitHubei;
        private FormatValidator formatValidator = new FormatValidator();
        public FormForAddAndEdit(MainMenuForm mainMenu, string option, Person originalPersonInformation)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.option = option;
            this.originalPerson = originalPersonInformation;
            switch (option)
            {
                case "Add":
                    this.Text = "Add";
                    clearButton.Visible = true;
                    deleteButton.Visible = false;
                    addConfirmButton.Text = "Add";
                    break;
                case "Edit":
                    this.Text = "Edit";
                    addConfirmButton.Text = "Save";
                    clearButton.Visible = false;
                    deleteButton.Visible = true;
                    DisplayHealthInformationOfPerson(originalPerson);
                    break;
            }
        }
        private void DisplayHealthInformationOfPerson(Person originalPerson)
        {
            ginNumberTextbox.Text = originalPerson.GinNumber.ToString();
            nameTextBox.Text = originalPerson.Name;
            temperatureTextbox.Text = originalPerson.Temperature.ToString();
            visitHubeiYesRadioButton.Checked = originalPerson.VisitHubei;
            visitHubeiNoRadioButton.Checked = !originalPerson.VisitHubei;
            hasAbnormalSymptomYesRadioButton.Checked = originalPerson.HasAbnormalSymptom;
            hasAbnormalSymptomNoRadioButton.Checked = !originalPerson.HasAbnormalSymptom;
        }

        private void AddConfirmButton_Click(object sender, EventArgs e)
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
                            ClearButton_Click(sender, e);
                        }
                        break;
                    case "Edit":
                        if (mainMenu.EditChosenPerson(originalPerson.GinNumber, newPerson) == true)
                        {
                            Close_Click(sender, e);
                        }
                        break;
                }
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (mainMenu.DeletePerson(originalPerson.GinNumber))
            {
                Close_Click(sender, e); 
            }
        }
        private void CheckAbnormalSymptom()
        {
            errorAbnormalSymptom.Visible = (!hasAbnormalSymptomYesRadioButton.Checked) && (!hasAbnormalSymptomNoRadioButton.Checked);
            if (errorAbnormalSymptom.Visible == false)
            {
                hasAbnormalSymptom = hasAbnormalSymptomYesRadioButton.Checked;
            }
        }

        private void CheckVisitHubei()
        {
            errorVisitHubei.Visible = (!visitHubeiYesRadioButton.Checked) && (!visitHubeiNoRadioButton.Checked);
            if (errorVisitHubei.Visible == false)
            {
                visitHubei = visitHubeiYesRadioButton.Checked;
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
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
