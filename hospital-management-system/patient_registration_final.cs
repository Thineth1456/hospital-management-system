using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Schema;
using MySql.Data.MySqlClient; // Add reference to MySql.Data for database operations

namespace HMS
{
    public partial class patient_registration_final : Form
    {
        //Add data base connection and operations here for patient registration 
        string connectionString = "Server=localhost;Database=hms_db;Uid=root;Pwd=;";
        public patient_registration_final()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
            // Attach the FormClosing event handler
        }

        private void update(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient_reciption homeForm = new patient_reciption();
            homeForm.Show();
            this.Hide(); // Hide the current form (Form2) when opening Form1
        }

        private void registationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient_list listForm = new patient_list();
            listForm.Show();
            this.Hide(); // Hide the current form (Form2) when opening Form3
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Save button click event handler to save patient data to the database
        private void save_Click(object sender, EventArgs e)
        {
            string name = p_name.Text;
            string id = p_id.Text;
            string bday = p_bday.Text;
            string gender = male_button.Checked ? "Male" : "Female";
            string contact = p_contact.Text;
            string email = p_mail.Text;
            string address = p_home.Text;

            //Check ID and Name fields are not empty before saving
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter both Name and ID fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Query the patient data to the database
            string patientQuery = "INSERT INTO patient_details (name, id, birthday, gender, contact, email, address)" +
                "VALUES (@name, @id, @birthday, @gender, @contact, @email, @address)";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(patientQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@birthday", bday);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@address", address);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Patient information saved successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving patient information: {ex.Message}",
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Show a message box with the entered patient information

            string patientInfo = $"Name: {name}\nID: {id}\nBirthday: {bday}\nGender: {gender}\nContact: {contact}\nEmail: {email}\nAddress: {address}";

            MessageBox.Show(patientInfo, "Patient Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the input fields after saving
            ClearFields();
        }
        private void ClearFields()
        {
            p_id.Clear();
            p_name.Clear();
            p_bday.Clear();
            male_button.Checked = true; // Default is male
            p_contact.Clear();
            p_mail.Clear();
            p_home.Clear();
            p_name.Focus(); // Cursor is set to the ID field for the next entry
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string id = p_id.Text.Trim();
            string name = p_name.Text.Trim();
            string bday = p_bday.Text.Trim();
            string gender = male_button.Text.Trim();
            string contact = p_contact.Text.Trim();
            string email = p_mail.Text.Trim();
            string address = p_home.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the ID and Name of the patient to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Query to update patient data in the database
            string updateQuery = "UPDATE patient_details SET name = @name, birthday = @birthday, " +
                "gender = @gender, contact = @contact," +
                " email = @email, address = @address WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@birthday", bday);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@address", address);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Patient information updated successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating patient information: {ex.Message}",
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
            //Show Update message box with the entered patient ID
            MessageBox.Show($"Patient with ID: {id} has been updated.", 
            "Update Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
