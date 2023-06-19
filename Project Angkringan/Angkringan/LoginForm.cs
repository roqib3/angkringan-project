using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Angkringan.Angkringan
{
    public partial class LoginForm : Form
    {
        private string connetionString = "server=localhost;database=angkringan;uid=root;pwd=\"\";";

        public LoginForm()
        {
            InitializeComponent();

            // Set the DialogResult to OK if login is successful
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPw.Text;

            using (MySqlConnection connection = new MySqlConnection(connetionString))
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
                        // Login successful, open the ManajamenStok form
                        Menu_Utama Menu_UtamaForm = new Menu_Utama();
                        Menu_UtamaForm.ShowDialog();
                        this.Close(); // Menutup form login

                        // Clear the login form
                        textBoxUser.Clear();
                        textBoxPw.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
                }
            }
        }
    }
}
