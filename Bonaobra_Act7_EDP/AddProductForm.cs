using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Bonaobra_Act7_EDP
{
    public partial class AddProductForm : Form
    {
        string connectionString = "server=localhost;user id=root;password=password1234;database=ECommerceDB;";

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal price;

            if (string.IsNullOrWhiteSpace(name) || !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter valid product details.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO products (name, price) VALUES (@name, @price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal price;

            if (string.IsNullOrWhiteSpace(name) || !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter valid product details.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=password1234;database=ECommerceDB;"))
            {
                string query = "INSERT INTO products (product_name, price) VALUES (@name, @price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
