using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Schema;
using hospital_management_system;

namespace HMS
{
    public partial class Form2 : Form
    {
        //I will Add data base connection and operations here for patient registration 
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
            
            // Wire click events that are unwired in designer
            this.save.Click += new EventHandler(this.save_Click);
            this.buttonUpdate.Click += new EventHandler(this.buttonUpdate_Click);
            this.clear.Click += new EventHandler(this.clear_Click);
        }

        private void update(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide(); // Hide the current form (Form2) when opening Form1
        }

        private void registationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 listForm = new Form3();
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
            string name = p_name.Text.Trim();
            string id = p_id.Text.Trim();
            string bday = p_bday.Text.Trim();
            string gender = male_button.Checked ? "Male" : "Female";
            string contact = p_contact.Text.Trim();
            string email = p_mail.Text.Trim();
            string address = p_home.Text.Trim();

            //Check ID and Name fields are not empty before saving
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter both Name and ID fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Calculate age roughly if possible, or leave as string representation
                string age = "";
                if (!string.IsNullOrEmpty(bday))
                {
                    try
                    {
                        DateTime birthDate = DateTime.Parse(bday);
                        age = (DateTime.Today.Year - birthDate.Year).ToString();
                    }
                    catch { age = "0"; }
                }

                var patient = new Patient(id, name, age, gender, contact, email, address, bday);
                DataManager.AddPatient(patient);

                MessageBox.Show($"Patient '{name}' registered successfully!", "Patient Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            p_name.Focus(); // Cursor is set to the name field
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string id = p_id.Text.Trim();
            string name = p_name.Text.Trim();
            string bday = p_bday.Text.Trim();
            string gender = male_button.Checked ? "Male" : "Female";
            string contact = p_contact.Text.Trim();
            string email = p_mail.Text.Trim();
            string address = p_home.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter the ID of the patient to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the patient's name to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string age = "";
                if (!string.IsNullOrEmpty(bday))
                {
                    try
                    {
                        DateTime birthDate = DateTime.Parse(bday);
                        age = (DateTime.Today.Year - birthDate.Year).ToString();
                    }
                    catch { age = "0"; }
                }

                var patient = new Patient(id, name, age, gender, contact, email, address, bday);
                DataManager.UpdatePatient(patient);

                MessageBox.Show($"Patient with ID: {id} has been updated.", "Update Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void save_Click_1(object sender, EventArgs e)
        {

        }

        private void clear_Click_1(object sender, EventArgs e)
        {

        }
    }
}
