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

namespace WindowsFormsApp6
{
    public partial class EnterHealthInformation : Form
    {
        private int ginNumber;
        private string name;
        private double temperature;
        private bool visitHubei;
        private bool hasAbnormalSymptom;
        private MainMenu mainMenu;
        private FormatValidator formatValidator = new FormatValidator();

        public EnterHealthInformation(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            mainMenu.Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            errorID.Visible = formatValidator.FindError_ID(idTextbox.Text);
            errorName.Visible = formatValidator.FindError_Name(nameTextBox.Text); 
            errorTemperature.Visible = formatValidator.FindError_Temperature(temperatureTextbox.Text);
            CheckVisitHubei();
            CheckAbnormalSymptom();

            if (errorVisitHubei.Visible == true || errorTemperature.Visible == true || errorName.Visible == true || errorID.Visible == true || errorAbnormalSymptom.Visible == true)
            {
                MessageBox.Show("Please check the information you entered! Some fields are empty or invalid!");
            }
            else
            {
                ginNumber = Int32.Parse(idTextbox.Text);
                name = nameTextBox.Text;
                temperature = Double.Parse(temperatureTextbox.Text);
                ResetButton_Click(sender,e);
                //Integrage with Console App, add the information to model
            }
        }

        private void CheckAbnormalSymptom()
        {
            if (abnormalSymptomYes.CheckState == CheckState.Checked)
            {
                hasAbnormalSymptom = true;
                errorAbnormalSymptom.Visible = false;
            }
            else if (abnormalSymptomNo.CheckState == CheckState.Checked)
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
            if (visitHubeiYes.CheckState == CheckState.Checked)
            {
                visitHubei = true;
                errorVisitHubei.Visible = false;
            }
            else if (visitHubeiNo.CheckState == CheckState.Checked)
            {
                visitHubei = false;
                errorVisitHubei.Visible = false;
            }
            else
            {
                errorVisitHubei.Visible = true;
            }
        }
        private void VisitHubeiYes_CheckedChanged(object sender, EventArgs e)
        {
            if (visitHubeiYes.CheckState == CheckState.Checked && visitHubeiNo.CheckState == CheckState.Checked)
            {
                visitHubeiNo.CheckState = CheckState.Unchecked;
            }
        }

        private void VisitHubeiNo_CheckedChanged(object sender, EventArgs e)
        {
            if (visitHubeiYes.CheckState == CheckState.Checked && visitHubeiNo.CheckState == CheckState.Checked)
            {
                visitHubeiYes.CheckState = CheckState.Unchecked;
            }
        }

        private void HasAbnormalSymptomYes_CheckedChanged(object sender, EventArgs e)
        {
            if (abnormalSymptomNo.CheckState == CheckState.Checked && abnormalSymptomYes.CheckState == CheckState.Checked)
            {
                abnormalSymptomNo.CheckState = CheckState.Unchecked;
            }
        }

        private void HasAbnormalSymptomNo_CheckedChanged(object sender, EventArgs e)
        {
            if (abnormalSymptomYes.CheckState == CheckState.Checked && abnormalSymptomNo.CheckState == CheckState.Checked)
            {
                abnormalSymptomYes.CheckState = CheckState.Unchecked;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            idTextbox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            temperatureTextbox.Text = String.Empty;
            
            visitHubeiYes.CheckState = CheckState.Unchecked;
            visitHubeiNo.CheckState = CheckState.Unchecked;
            abnormalSymptomNo.CheckState = CheckState.Unchecked;
            abnormalSymptomYes.CheckState = CheckState.Unchecked;

            errorAbnormalSymptom.Visible = false;
            errorID.Visible = false;
            errorName.Visible = false;
            errorVisitHubei.Visible = false;
            errorTemperature.Visible = false;
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }
    }
}
