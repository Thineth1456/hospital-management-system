using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HMS
{
    public partial class doctor_registration : Form
    {
        //I will Add data base connection and operations here for doctor registration
        public doctor_registration()
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
                MessageBox.Show("Please fill in both Name and ID fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Show a message box to confirm saving the doctor data
            MessageBox.Show($"Doctor Information:\n\nName: {name}\nID: {id}\n" +
                $"Specialization: {specialization}\nContact: {contact}\nEmail: {email}\n" +
                $"Address: {address}\nGender: {gender}", "Doctor Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields(); // Clear input fields after saving
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
    }
}