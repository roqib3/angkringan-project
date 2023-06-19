using Project_Angkringan.Angkringan;

namespace Project_Angkringan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the LoginForm
            LoginForm loginForm = new LoginForm();

            // Check if the login is successful
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Angkringan.Menu_Utama());
            }
        }
    }
}