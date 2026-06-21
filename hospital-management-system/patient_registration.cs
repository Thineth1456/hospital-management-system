using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Schema;

namespace HMS
{
    public partial class Form2 : Form
    {
        //I will Add data base connection and operations here for patient registration 
        public Form2()
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
            //I will add code here to save the patient data to the database
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
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter the ID of the patient to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Show Update message box with the entered patient ID
            MessageBox.Show($"Patient with ID: {id} has been updated.", "Update Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
