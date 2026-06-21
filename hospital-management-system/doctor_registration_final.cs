using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Add reference to MySql.Data for database operations
namespace HMS
{
    public partial class doctor_registration_final : Form
    {
        //Add data base connection and operations here for doctor registration
        string connectionString = "Server=localhost;Database=hms_db;Uid=root;Pwd=;";
        public doctor_registration_final()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(doctor_registration_FormClosing);
        }

        private void doctor_registration_Load(object sender, EventArgs e)
        {

        }

        private void doctor_registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void d_save_Click(object sender, EventArgs e)
        {
            string name = d_name.Text;
            string id = d_id.Text;
            string specialization = special.Text;
            string contact = d_phone.Text;
            string email = d_mail.Text;
            string address = d_home.Text;
            string gender = dfemale.Checked ? "Female" : "Male";

            //Verify ID and Name fields are not empty before saving
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please fill in both Name and ID fields.", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Add sql queries
            string doctorQuery = "INSERT INTO doctors (id, name, specialization, gender, contact, email, address) " +
                     "VALUES (@id, @name, @specialization, @gender, @contact, @email, @address)";
            //ADO.net code to execute the query and save doctor data to the database would go here
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();   // Open the connection to the database
                    using (MySqlCommand cmd = new MySqlCommand(doctorQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@specialization", specialization);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@address", address);


                        int result = cmd.ExecuteNonQuery(); // Execute the insert command
                        if (result > 0)
                        {
                            MessageBox.Show("Doctor information saved successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields(); // Clear input fields after successful save
                        }

                    }
                }
                    catch (Exception ex)
                {
                    MessageBox.Show($"Error saving doctor information: {ex.Message}",
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                        //Show a message box to confirm saving the doctor data
                        MessageBox.Show($"Doctor Information:\n\nName: {name}\nID: {id}\n" +
                        $"Specialization: {specialization}\nContact: {contact}\nEmail: {email}\n" +
                        $"Address: {address}\nGender: {gender}", "Doctor Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields(); // Clear input fields after saving
                    }
                }

               
                
        //clear button click event handler to clear all input fields
        private void ClearFields()
        {
            d_name.Clear();
            d_id.Clear();
            special.Clear();
            d_phone.Clear();
            d_mail.Clear();
            d_home.Clear();
            dfemale.Checked = true;
            d_name.Focus(); // Set focus to the name field after clearing)
        }

        private void d_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void dUpdate_Click(object sender, EventArgs e)
        {
            string id = d_id.Text.Trim();
            string name = d_name.Text;
            string specialization = special.Text;
            string gender = dmale.Checked ? "Male" : "Female";
            string contact = d_phone.Text;
            string email = d_mail.Text;
            string address = d_home.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Doctor ID and Name are required to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string updateQuery = "UPDATE doctors SET name=@name, specialization=@specialization, gender=@gender, contact=@contact, email=@email, address=@address WHERE id=@id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@specialization", specialization);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@address", address);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show($"Doctor with ID: {id} has been successfully updated!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Make sure the Doctor ID exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating doctor: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
