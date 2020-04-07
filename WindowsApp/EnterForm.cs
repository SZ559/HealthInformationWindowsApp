using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInformation;
using DatabaseOperation;
using System.Xml;

namespace WindowsApp
{
    public partial class EnterForm : Form
    {
        private int ginNumber;
        private string name;
        private double temperature;
        private bool visitHubei;
        private bool hasAbnormalSymptom;
        
        private MainMenuForm mainMenu;
        private string option;
        private Person originalPerson;

        private FormatValidator formatValidator = new FormatValidator();

        public EnterForm(MainMenuForm mainMenu, string option, Person originalPersonInformation)
        {
            InitializeComponent();
            this.Text = "Enter";
            this.mainMenu = mainMenu;
            this.option = option;
            this.originalPerson = originalPersonInformation;
            if (option == "Modify")
            {
                this.Text = "Modify";
                ginNumberTextbox.Text = originalPerson.GinNumber.ToString();
                nameTextBox.Text = originalPerson.Name;
                temperatureTextbox.Text = originalPerson.Temperature.ToString();
                if (originalPerson.VisitHubei == true)
                {
                    visitHubeiYesRadioButton.Checked = true;
                }
                else
                {
                    visitHubeiNoRadioButton.Checked = true;
                }

                if (originalPerson.HasAbnormalSymptom == true)
                {
                    hasAbnormalSymptomYesRadioButton.Checked = true;
                }
                else
                {
                    hasAbnormalSymptomNoRadioButton.Checked = true;
                }
            }
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
                ginNumber = Int32.Parse(ginNumberTextbox.Text);
                name = nameTextBox.Text;
                temperature = Double.Parse(temperatureTextbox.Text);

                Person newPerson = new Person(ginNumber, name, visitHubei, hasAbnormalSymptom, temperature);
                switch(option)
                {
                    case "Enter":
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
            //if (abnormalSymptomYesCheckBox.CheckState == CheckState.Checked)
            if(hasAbnormalSymptomYesRadioButton.Checked == true)
            {
                hasAbnormalSymptom = true;
                errorAbnormalSymptom.Visible = false;
            }
            //else if (abnormalSymptomNoCheckBox.CheckState == CheckState.Checked)
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
            //if (visitHubeiYesCheckBox.CheckState == CheckState.Checked)
            if(visitHubeiYesRadioButton.Checked == true)
            {
                visitHubei = true;
                errorVisitHubei.Visible = false;
            }
            //else if (visitHubeiNoCheckBox.CheckState == CheckState.Checked)
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
        //private void VisitHubeiYes_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (visitHubeiYesCheckBox.CheckState == CheckState.Checked && visitHubeiNoCheckBox.CheckState == CheckState.Checked)
        //    {
        //        visitHubeiNoCheckBox.CheckState = CheckState.Unchecked;
        //    }
        //}

        //private void VisitHubeiNo_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (visitHubeiYesCheckBox.CheckState == CheckState.Checked && visitHubeiNoCheckBox.CheckState == CheckState.Checked)
//            {
  //              visitHubeiYesCheckBox.CheckState = CheckState.Unchecked;
   //         }
    //    }

        //private void HasAbnormalSymptomYes_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (abnormalSymptomNoCheckBox.CheckState == CheckState.Checked && abnormalSymptomYesCheckBox.CheckState == CheckState.Checked)
        //    {
        //        abnormalSymptomNoCheckBox.CheckState = CheckState.Unchecked;
        //    }
        //}

        //private void HasAbnormalSymptomNo_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (abnormalSymptomYesCheckBox.CheckState == CheckState.Checked && abnormalSymptomNoCheckBox.CheckState == CheckState.Checked)
            //{
              //  abnormalSymptomYesCheckBox.CheckState = CheckState.Unchecked;
            //}
        //}

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ginNumberTextbox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            temperatureTextbox.Text = String.Empty;

            hasAbnormalSymptomNoRadioButton.Checked = false;
            hasAbnormalSymptomYesRadioButton.Checked = false;

            visitHubeiNoRadioButton.Checked = false;
            visitHubeiYesRadioButton.Checked = false;


            errorAbnormalSymptom.Visible = false;
            errorGinNumber.Visible = false;
            errorName.Visible = false;
            errorVisitHubei.Visible = false;
            errorTemperature.Visible = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
