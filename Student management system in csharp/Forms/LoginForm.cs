using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Login button click - check username and password
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Check empty fields
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.", "Warning");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT * FROM Users WHERE Username=@u AND Password=@p";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Login success - open dashboard
                        string role = reader["Role"].ToString();
                        MessageBox.Show("Welcome " + username + "!", "Login Success");
                        DashboardForm dashboard = new DashboardForm(username, role);
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Wrong credentials
                        MessageBox.Show("Invalid username or password.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
    }
}