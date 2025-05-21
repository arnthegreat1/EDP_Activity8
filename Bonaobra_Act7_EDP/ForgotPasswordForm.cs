using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace Bonaobra_Act7_EDP
{
    public partial class ForgotPasswordForm : Form
    {
        string connectionString = "server=localhost;user id=root;password=password1234;database=ECommerceDB;";
        string currentUsername = "";

        public ForgotPasswordForm()
        {
            InitializeComponent();

            lblQuestion.Visible = false;
            txtAnswer.Visible = false;
            txtNewPassword.Visible = false;
            btnResetPassword.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (username == "")
            {
                MessageBox.Show("Enter your username.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT security_question FROM system_users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    
                    lblQuestion.Visible = true;
                    txtAnswer.Visible = true;
                    txtNewPassword.Visible = true;
                    btnResetPassword.Visible = true;
                    currentUsername = username;
                }
                else
                {
                    MessageBox.Show("Username not found.");
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string answer = txtAnswer.Text.Trim();
            string newPassword = txtNewPassword.Text;

            if (answer == "" || newPassword == "")
            {
                MessageBox.Show("Answer and new password are required.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT security_answer FROM system_users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", currentUsername);

                object result = cmd.ExecuteScalar();

                if (result != null && result.ToString().Equals(answer, StringComparison.OrdinalIgnoreCase))
                {
                    string hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                    string updateQuery = "UPDATE system_users SET password = @newPassword WHERE username = @username";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@newPassword", hashedNewPassword);
                    updateCmd.Parameters.AddWithValue("@username", currentUsername);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Password reset successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect answer to security question.");
                }
            }
        }
    }
}

