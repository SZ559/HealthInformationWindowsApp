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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            EnterHealthInformation enterForm = new EnterHealthInformation(this);
            enterForm.Show();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            ModifyHealthInformation modifyForm = new ModifyHealthInformation(this);
            modifyForm.Show();
        }

        private void InputFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Integrate with Console App and Model later
               //openFileDialog.FileName;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Integrate with Console App and Model later
                ////saveFileDialog1.FileName;
            }
        }
    }
}
