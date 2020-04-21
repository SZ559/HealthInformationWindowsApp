using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsApp;


namespace WindowsFormsApp
{
    public class Program
    {
        //[DllImport("kernel32.dll")]
        //static extern bool AttachConsole(int dwProcessId);
        //private const int ATTACH_PARENT_PROCESS = -1;
        [STAThread]
        //static void Main()
        static void Main(string[] argument)
        {
            //AttachConsole(ATTACH_PARENT_PROCESS);
            //if (argument.Length == 0)
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainMenuForm mainMenu = new MainMenuForm();
                Application.Run(mainMenu);
            //}
            //else
            //{
                //Console.WriteLine("You are using the console app.");
                //UserInterface program = new UserInterface();
                //program.Run();
            //}
        }
    }
}


