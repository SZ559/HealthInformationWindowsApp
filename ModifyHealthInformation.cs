using EmployeeInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class ModifyHealthInformation : Form
    {
        private MainMenu mainMenu;
        private FormatValidator formatValidator = new FormatValidator();
        private Person employee;
        private int id;
        public ModifyHealthInformation(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            mainMenu.Hide();
            //EnterHealthInformation enter = new EnterHealthInformation();
            //enter.TopLevel = false;
            //enter.TopMost = true;
            //panel1.Controls.Add(enter);
            //enter.Show();
        }


        private void enterID_TextChanged(object sender, EventArgs e)
        {
            errorID.Visible = formatValidator.FindError_ID(enterID.Text);
            if (errorID.Visible == false)
            {
                //Integrate with Console App later, reivise the format validator and 
                id = Int32.Parse(enterID.Text);
                // if (myHealthRecord.ContainsKey(id))
                //{
                //
                //displayHealthInformation.Text = myHealthRecord[id].ToString();
                //displayHealthInformation.Visible = true;
                // }
                //else
                // {
                //displayHealthInformation.Text = "The ID You Entered is Not in The Health Record. Please Check.";
                //displayHealthInformation.Visible = true;
                // }
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            if (errorID.Visible == false && displayHealthInformation.Text != "The ID You Entered is Not in The Health Record. Please Check.")
            {
                modifyPanel.Visible = true;
                //Integrate with Console App later, reivise the modify function
                //employee = myHealthRecord[id];
                ResetEnterIDPanel();
                MessageBox.Show(errorID.Visible.ToString());
            }
            else
            {
                MessageBox.Show("Invalid ID! Please check and enter again!");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (errorID.Visible == false && displayHealthInformation.Text != "The ID You Entered is Not in The Health Record. Please Check.")
            {
                //Integrate with Console App later, reivise the remove function
                //employee = myHealthRecord.Remove(id);
                ResetEnterIDPanel();
            }
        }

        private void ResetEnterIDPanel()
        {
            enterID.Text = String.Empty;
            errorID.Visible = false;
            displayHealthInformation.Visible = false;
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }
        //Instead of using comboBox to change field one by one, choose to display and change all the fields? Need to revise the ConsoleApp and model
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "ID":
                    break;
                case "Name":
                    break;
                case "Visited Hubei Recently":
                    break;
                case "Has Abnormal Symptom":
                    break;
                case "Temperature":
                    break;
                default:
                    break;
            }
        }
    }
}
