using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsApp;
using EmployeeHealthRecord;

namespace WindowsFormsApp
{
    public class Program
    {
        [STAThread]
        static void Main(string[] argument)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainMenuForm mainMenu = new MainMenuForm();
            Application.Run(mainMenu);
          

        }
    }
}


