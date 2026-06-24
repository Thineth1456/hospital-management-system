using System;
using System.Drawing;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class Form1 : Form
    {
        public static string LoggedInUserID { get; internal set; }
        public static string LoggedInUserName { get; internal set; }

        public Form1()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = Color.FromArgb(15, 23, 42); // Slate 900
            this.ForeColor = Color.FromArgb(241, 245, 249); // Slate 100
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System - Login";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Title styling
            lblTitle.ForeColor = Color.FromArgb(59, 130, 246); // Modern Blue
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            // Label styling
            label1.ForeColor = Color.FromArgb(148, 163, 184); // Slate 400
            label1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            
            lbl.ForeColor = Color.FromArgb(148, 163, 184); // Slate 400
            lbl.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);

            // Inputs styling
            txtUsername.BackColor = Color.FromArgb(30, 41, 59); // Slate 800
            txtUsername.ForeColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10.5F);

            txtPassword.BackColor = Color.FromArgb(30, 41, 59); // Slate 800
            txtPassword.ForeColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.UseSystemPasswordChar = true; // Use system password characters for clean masking
            txtPassword.Font = new Font("Segoe UI", 10.5F);

            // Buttons styling
            btnLogin.BackColor = Color.FromArgb(59, 130, 246); // Modern Blue
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;

            btnClear.BackColor = Color.FromArgb(71, 85, 105); // Slate 600
            btnClear.ForeColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnClear.Cursor = Cursors.Hand;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["HMSConnectionString"]?.ConnectionString 
                ?? @"Data Source=localhost;Initial Catalog=HospitalManagementDB;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    string query = "SELECT Username, Role, FullName FROM Users WHERE Username = @Username AND PasswordHash = @Password";
                    using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                LoggedInUserID = reader["Username"].ToString();
                                LoggedInUserName = reader["FullName"].ToString();

                                var regForm = new HospitalDashboard();
                                regForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid Username or Password!",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Login Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}