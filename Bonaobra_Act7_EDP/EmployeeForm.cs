using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ✅ Add this line to use MySQL
using MySql.Data.MySqlClient;
using OfficeOpenXml;

namespace Bonaobra_Act7_EDP
{
    public partial class EmployeeForm : Form
    {
        // ✅ Define your connection string here at the class level so it's available to all methods in the form
        string connectionString = "server=localhost;user id=root;password=password1234;database=ECommerceDB;";
        MySqlConnection conn;

        public EmployeeForm()
        {
            InitializeComponent();
            conn = new MySqlConnection(connectionString); // ✅ Initialize the connection
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // You can optionally test the connection here
            try
            {
                conn.Open();
                MessageBox.Show("Database connection successful!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM products"; // adjust table name as needed

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnLoadCustomers_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customers"; // Adjust table name as needed

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            addForm.ShowDialog(); // Show as modal
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
        }



        private void btnLoadEmployees_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM employees";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["product_id"].Value);
                string name = dataGridView1.CurrentRow.Cells["product_name"].Value.ToString();
                decimal price = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["price"].Value);

                EditProductForm editForm = new EditProductForm(productId, name, price);
                editForm.ShowDialog();

                // Reload products after editing
                btnLoadProducts.PerformClick();
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["product_id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM products WHERE product_id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", productId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product deleted successfully.");
                        btnLoadProducts.PerformClick(); // refresh the list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting product: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["customer_id"].Value);
                string firstName = dataGridView1.CurrentRow.Cells["first_name"].Value.ToString();
                string lastName = dataGridView1.CurrentRow.Cells["last_name"].Value.ToString();
                string email = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                string phone = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                string address = dataGridView1.CurrentRow.Cells["address"].Value.ToString();

                EditCustomerForm editForm = new EditCustomerForm(customerId, firstName, lastName, email, phone, address);
                editForm.ShowDialog();

                btnLoadCustomers.PerformClick(); // Reload after edit
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["customer_id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM customers WHERE customer_id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", customerId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Customer deleted successfully.");
                        btnLoadCustomers.PerformClick(); // Refresh
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting customer: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void btnEditEmployees_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int employeeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["employee_id"].Value);
                string firstName = dataGridView1.CurrentRow.Cells["first_name"].Value.ToString();
                string lastName = dataGridView1.CurrentRow.Cells["last_name"].Value.ToString();
                DateTime hireDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["hire_date"].Value);
                string position = dataGridView1.CurrentRow.Cells["position"].Value.ToString();

                EditEmployeeForm editForm = new EditEmployeeForm(employeeId, firstName, lastName, hireDate, position);
                editForm.ShowDialog();

                btnLoadEmployees.PerformClick(); // Refresh
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

        private void btnDeleteEmployees_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int employeeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["employee_id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM employees WHERE employee_id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Employee deleted successfully.");
                        btnLoadEmployees.PerformClick(); // Refresh
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting employee: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=password1234;database=ECommerceDB;";
            string query = "SELECT * FROM products"; // You can add WHERE clauses to filter data if needed

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();     
                    adapter.Fill(dt);

                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (ExcelPackage excel = new ExcelPackage())
                    {
                        ExcelWorksheet sheet = excel.Workbook.Worksheets.Add("Products");
                        sheet.Cells["A1"].LoadFromDataTable(dt, true);

                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                            saveFileDialog.Title = "Save Excel File";
                            saveFileDialog.FileName = "Products.xlsx";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                FileInfo fi = new FileInfo(saveFileDialog.FileName);
                                excel.SaveAs(fi);
                                MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }
    }
}

