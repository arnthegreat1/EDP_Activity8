namespace Bonaobra_Act7_EDP
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadProducts = new System.Windows.Forms.Button();
            this.btnLoadCustomers = new System.Windows.Forms.Button();
            this.btnLoadEmployees = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddEmployees = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnEditEmployees = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnDeleteEmployees = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLoadProducts
            // 
            this.btnLoadProducts.Location = new System.Drawing.Point(152, 367);
            this.btnLoadProducts.Name = "btnLoadProducts";
            this.btnLoadProducts.Size = new System.Drawing.Size(120, 52);
            this.btnLoadProducts.TabIndex = 1;
            this.btnLoadProducts.Text = "Load Products";
            this.btnLoadProducts.Click += new System.EventHandler(this.btnLoadProducts_Click);
            // 
            // btnLoadCustomers
            // 
            this.btnLoadCustomers.Location = new System.Drawing.Point(332, 367);
            this.btnLoadCustomers.Name = "btnLoadCustomers";
            this.btnLoadCustomers.Size = new System.Drawing.Size(120, 52);
            this.btnLoadCustomers.TabIndex = 2;
            this.btnLoadCustomers.Text = "Load Customers";
            this.btnLoadCustomers.Click += new System.EventHandler(this.btnLoadCustomers_Click);
            // 
            // btnLoadEmployees
            // 
            this.btnLoadEmployees.Location = new System.Drawing.Point(508, 367);
            this.btnLoadEmployees.Name = "btnLoadEmployees";
            this.btnLoadEmployees.Size = new System.Drawing.Size(120, 52);
            this.btnLoadEmployees.TabIndex = 3;
            this.btnLoadEmployees.Text = "Load Employees";
            this.btnLoadEmployees.Click += new System.EventHandler(this.btnLoadEmployees_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(152, 425);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 30);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(332, 425);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(120, 30);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddEmployees
            // 
            this.btnAddEmployees.Location = new System.Drawing.Point(508, 425);
            this.btnAddEmployees.Name = "btnAddEmployees";
            this.btnAddEmployees.Size = new System.Drawing.Size(120, 30);
            this.btnAddEmployees.TabIndex = 7;
            this.btnAddEmployees.Text = "Add Employee";
            this.btnAddEmployees.Click += new System.EventHandler(this.btnAddEmployees_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(152, 465);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(63, 25);
            this.btnEditProduct.TabIndex = 9;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(332, 465);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(63, 25);
            this.btnEditCustomer.TabIndex = 10;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnEditEmployees
            // 
            this.btnEditEmployees.Location = new System.Drawing.Point(508, 465);
            this.btnEditEmployees.Name = "btnEditEmployees";
            this.btnEditEmployees.Size = new System.Drawing.Size(63, 25);
            this.btnEditEmployees.TabIndex = 11;
            this.btnEditEmployees.Text = "Edit Employee";
            this.btnEditEmployees.Click += new System.EventHandler(this.btnEditEmployees_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(217, 465);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(55, 25);
            this.btnDeleteProduct.TabIndex = 13;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(397, 465);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(55, 25);
            this.btnDeleteCustomer.TabIndex = 14;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnDeleteEmployees
            // 
            this.btnDeleteEmployees.Location = new System.Drawing.Point(573, 465);
            this.btnDeleteEmployees.Name = "btnDeleteEmployees";
            this.btnDeleteEmployees.Size = new System.Drawing.Size(55, 25);
            this.btnDeleteEmployees.TabIndex = 15;
            this.btnDeleteEmployees.Text = "Delete Employee";
            this.btnDeleteEmployees.Click += new System.EventHandler(this.btnDeleteEmployees_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(767, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(59, 41);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Export to Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnExportToExcel_Click);
            // 
            // EmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(836, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadProducts);
            this.Controls.Add(this.btnLoadCustomers);
            this.Controls.Add(this.btnLoadEmployees);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnAddEmployees);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnEditEmployees);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnDeleteEmployees);
            this.Controls.Add(this.btnLogout);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView1;

        // Load
        private System.Windows.Forms.Button btnLoadProducts;
        private System.Windows.Forms.Button btnLoadCustomers;
        private System.Windows.Forms.Button btnLoadEmployees;

        // Add
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddEmployees;

        // Edit
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnEditEmployees;

        // Delete
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnDeleteEmployees;

        // Logout
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
    }
}
