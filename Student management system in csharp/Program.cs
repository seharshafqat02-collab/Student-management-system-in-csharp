using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    // Entry point of the application
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // App starts from LoginForm
            Application.Run(new Forms.LoginForm());
        }
    }
}