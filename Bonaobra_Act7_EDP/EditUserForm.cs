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

namespace Bonaobra_Act7_EDP
{
    public partial class EditUserForm : Form
    {
        private int userId;
        string connectionString = "server=localhost;user id=root;password=password1234;database=ECommerceDB;";

        public EditUserForm(int id, string username, string role)
        {
            InitializeComponent();
            userId = id;
            txtUsername.Text = username;
            cmbRole.SelectedItem = role;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string role = cmbRole.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE system_users SET username = @username, role = @role WHERE user_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@id", userId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully!");
                    this.Close(); // Close after saving
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }
    }
}
