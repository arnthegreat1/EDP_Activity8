using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bonaobra_Act7_EDP
{
    public partial class AddEmployeeForm : Form
    {
        string connectionString = "server=localhost;user id=root;password=password1234;database=ECommerceDB;";

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string hireDate = dtpHireDate.Value.ToString("yyyy-MM-dd");

            if (firstName == "" || lastName == "" || position == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO employees (first_name, last_name, hire_date, position) " +
                               "VALUES (@firstName, @lastName, @hireDate, @position)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@hireDate", hireDate);
                cmd.Parameters.AddWithValue("@position", position);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee added successfully!");
                    this.Close(); // close form after add
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding employee: " + ex.Message);
                }
            }
        }
    }
}
