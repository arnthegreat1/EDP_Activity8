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
    public partial class EditEmployeeForm : Form
    {
        int employeeId;
        string connectionString = "server=localhost;user id=root;password=password1234;database=ECommerceDB;";

        public EditEmployeeForm(int id, string firstName, string lastName, DateTime hireDate, string position)
        {
            InitializeComponent();
            employeeId = id;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            dtpHireDate.Value = hireDate;
            txtPosition.Text = position;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string position = txtPosition.Text.Trim();
            DateTime hireDate = dtpHireDate.Value;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE employees SET first_name=@firstName, last_name=@lastName, hire_date=@hireDate, position=@position WHERE employee_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@hireDate", hireDate);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@id", employeeId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee updated successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating employee: " + ex.Message);
                }
            }
        }
    }
}