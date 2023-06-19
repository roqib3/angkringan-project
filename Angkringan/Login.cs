using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Angkringan.Angkringan
{
    public partial class Login : Form
    {
        private FormMainMenu mainMenuForm;
        private string connectionString = "server=localhost;database=angkringan;uid=root;pwd=\"\";";

        public Login()
        {
            InitializeComponent();
        }

        private bool ValidateLogin(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM users WHERE Username = @Username AND Password = @Password";
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Login successful!"); // Menampilkan pesan login berhasil
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
                    // Clear the login form
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
