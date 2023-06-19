using Microsoft.VisualBasic.Logging;
using Project_Angkringan;
using Project_Angkringan.Angkringan;

namespace Project_Angkringan
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the LoginForm
            Login login = new Login();

            // Check if the login is successful
            if (login.ShowDialog() == DialogResult.OK)
            {
                // If login is successful, open the ManajamenStok form
                Application.Run(new FormMainMenu());
            }
        }
    }
}